using _2.BUS.IService;
using _2.BUS.Service;
using Du_An_Ban_Sach._1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Printing;
using static System.Windows.Forms.AxHost;

namespace _3.GUI
{
    public partial class BillInFor : Form
    {
        IHoaDonChiTietService hoaDonChiTietService;
        IKhachHangService khachHangService;
        ISanPhamService sanPhamService;
        IHoaDonService hoaDonService;
        KhachHang KhachHang;
        List<HoaDonChiTietvIEW> _lstViewHDCT;
        string productName;
        private DateTime dateTime = new DateTime();
        Guid id;
        Guid idhd;

        public BillInFor()
        {
            InitializeComponent();
            hoaDonChiTietService = new HoaDonChiTietService();
            khachHangService = new KhachHangService();
            sanPhamService = new SanPhamService();
            hoaDonService = new HoaDonService();
            KhachHang = new KhachHang();
            _lstViewHDCT = new List<HoaDonChiTietvIEW>();
            LoadData();
            LoadCBB();
            Clear();
        }
        public void LoadData()
        {
            int stt = 1;
            dtgProduct.ColumnCount = 5;
            dtgProduct.Columns[0].HeaderText = "ID";
            dtgProduct.Columns[1].HeaderText = "STT";
            dtgProduct.Columns[2].HeaderText = "Tên sách";
            dtgProduct.Columns[3].HeaderText = "Số lượng";
            dtgProduct.Columns[4].HeaderText = "Thành tiền";
            dtgProduct.Columns[0].Visible = false;
            dtgProduct.Rows.Clear();
            var listHoaDonCT = hoaDonChiTietService.GetAll().Where(c => c.IdHoaDon == idhd).ToList();
            foreach (var x in listHoaDonCT)
            {
                dtgProduct.Rows.Add(x.idHoaDonCT, stt++, x.tenSach, x.soLuong, x.soLuong * x.giaBan);
            }
            dateTime = DateTime.Now;
            tbxTime.Text = dateTime.ToString("dd/MM/yyyy") + " " + dateTime.ToString("HH:mm");
        }
        public void LoadCBB()
        {
            foreach (var item in sanPhamService.GetAll())
            {
                string tenSachVaSoLuong = $" {item.SoLuongTon} | {item.TenSach.Trim()}";
                cbbSP.Items.Add(item.TenSach);
            }

        }
        string MaHD()
        {
            string ma = "HD";
            Random rand = new Random();
            int a = rand.Next(1000, 9999);
            var so = a.ToString();
            return ma + so;
        }
        string MaHDCT()
        {
            string ma = "HDCT";
            Random rand = new Random();
            int a = rand.Next(1000, 9999);
            var so = a.ToString();
            return ma + so;
        }
        private void btn_TaoHoanDon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tạo hóa đơn không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sdt = txtSDT.Text.Trim();

                // Kiểm tra xem SDT có giá trị hay không
                if (string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại khách hàng");
                    return;
                }
                double tong = 0;
                foreach (var x in _lstViewHDCT)
                {
                    tong += x.giaBan * x.soLuong;
                }
                idhd = Guid.NewGuid();
                id = khachHangService.GetAll().FirstOrDefault(x => x.sdt == txtSDT.Text).IdKhachHang;
                if (id != null)
                {
                    HoaDonView hd = new HoaDonView();
                    hd.iDhoaDon = idhd;
                    hd.iDkhachHang = id;
                    hd.MaHD = MaHD();
                    hd.ngayThanhToan = DateTime.Now;
                    hd.trangThai = 0;
                    hd.tenKH = khachHangService.GetAll().FirstOrDefault(x => x.sdt == txtSDT.Text).Ten.ToString();
                    hoaDonService.Add(hd);
                    MessageBox.Show("Tạo thành công");
                    label1.Text = $"{hd.MaHD}";
                }
            }
        }

        // ok
        public double GetPrice1(string tenSp)
        {
            var lst = sanPhamService.GetAll().FirstOrDefault(c => c.TenSach.Equals(tenSp));
            if (lst != null)
            {
                return lst.GiaBan;
            }
            return 0;
        }
        // ok
        private void cbbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSP.SelectedIndex >= 0)
            {
                double giaSp = GetPrice1(cbbSP.SelectedItem.ToString());
                tbxGia.Text = giaSp.ToString();
            }
            int soluongton = sanPhamService.GetAll().FirstOrDefault(x => x.TenSach == cbbSP.Text)?.SoLuongTon ?? 0;
            lbltonkho.Text = Convert.ToString(soluongton);
        }
        //ok
        public string GetSDT(string Sdt)
        {
            var lsdt = khachHangService.GetAll().FirstOrDefault(c => c.sdt.Equals(Sdt));
            if (lsdt != null)
            {
                return lsdt?.Ten;
            }
            return lbTenKH.Text = "...";
        }
        //ok

        private void txtSDT_TextChanged_1(object sender, EventArgs e)
        {
            string phoneNumber = txtSDT.Text;

            string name = GetSDT(phoneNumber);
            if (name != null)
            {
                lbTenKH.Text = name;
            }
        }
        private void UpdateTotalPrice()
        {
            double total = 0;

            // Kiểm tra xem có sản phẩm được chọn không
            if (cbbSP.SelectedItem != null)
            {
                // Lấy giá từ hàm GetPrice1 và chuyển đổi số lượng thành số
                double price = GetPrice1(cbbSP.SelectedItem.ToString());
                int quantity;

                // Kiểm tra xem có thể chuyển đổi được số lượng thành số không
                if (int.TryParse(tbxSoLuong.Text, out quantity))
                {
                    // Thêm giá của sản phẩm hiện tại vào tổng tiền
                    total += price * quantity;
                }
            }

            // Lặp qua tất cả các sản phẩm trong DataGridView và cộng dồn vào tổng tiền
            foreach (DataGridViewRow row in dtgProduct.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    total += Convert.ToDouble(row.Cells[4].Value);
                }
            }

            // Hiển thị tổng tiền trong TextBox hoặc nơi phù hợp
            tbxTien.Text = total.ToString();
        }

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= hoaDonChiTietService.GetAll().Count) return;
            id = Guid.Parse(dtgProduct.CurrentRow.Cells[0].Value.ToString());
            var hd = hoaDonChiTietService.GetAll().Where(x => x.idHoaDonCT == id).FirstOrDefault();
            cbbSP.Text = hd.tenSach;
            tbxGia.Text = Convert.ToString(hd.giaBan);
            tbxSoLuong.Text = Convert.ToString(hd.soLuong);
            tbxTien.Text = Convert.ToString(hd.tongTien);
        }

        private void tbxGia_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void tbxSoLuong_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
        public bool checkChu(string text)
        {
            return Regex.IsMatch(text, "[a-zA-Z]+");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                        var hdct = hoaDonChiTietService.GetAll().FirstOrDefault(x => x.idHoaDonCT.Equals(id));
                        hdct.soLuong = Convert.ToInt32(tbxSoLuong.Text);
                        hdct.tongTien = Convert.ToDouble(tbxTien.Text);
                        hdct.tenSach = cbbSP.Text;
                        hdct.giaBan = Convert.ToDouble(tbxGia.Text);
                        MessageBox.Show("Sửa thành công","Thông báo");
                        LoadData();
                        Clear();
                    


            }
               
            
            else
            {
                MessageBox.Show("Sửa không thành công","Thông báo");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string tenSach = cbbSP.Text;

                // Kiểm tra xem chuỗi có thể chuyển đổi thành số nguyên không
                if (int.TryParse(tbxSoLuong.Text, out int soLuongMoi) &&
                    double.TryParse(tbxGia.Text, out double giaBan))
                {
                    // Kiểm tra xem sản phẩm đã tồn tại trong hóa đơn chi tiết chưa
                    var existingProduct = hoaDonChiTietService.GetAll()
                        .FirstOrDefault(x => x.IdHoaDon == idhd && x.tenSach == tenSach);
                    if (Convert.ToInt32(lbltonkho.Text) < Convert.ToInt32(tbxSoLuong.Text))
                    {
                        MessageBox.Show("Số lượng tồn không đủ", "Thông báo");
                    }
                    else if (Convert.ToInt32(lbltonkho.Text) <= 0)
                    {
                        MessageBox.Show("Sản phẩm đã hết hàng", "Thông báo");
                    }
                    else if (existingProduct != null)
                    {
                        // Cập nhật số lượng và thành tiền
                        existingProduct.soLuong += soLuongMoi;
                        existingProduct.tongTien = existingProduct.soLuong * giaBan;
                        hoaDonChiTietService.Update(existingProduct);
                    }
                    else
                    {
                        // Nếu sản phẩm chưa tồn tại, thêm mới vào hóa đơn chi tiết
                        HoaDonChiTietvIEW hdct = new HoaDonChiTietvIEW
                        {
                            idHoaDonCT = Guid.NewGuid(),
                            MaHDCt = MaHDCT(),
                            soLuong = soLuongMoi,
                            tongTien = soLuongMoi * giaBan,
                            tenSach = tenSach,
                            giaBan = giaBan,
                            idSanPham = sanPhamService.GetAll().Where(x => x.TenSach == tenSach).Select(x => x.IDsanPham).FirstOrDefault(),
                            IdHoaDon = idhd,
                        };

                        hoaDonChiTietService.Add(hdct);
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        LoadData();
                        Clear();
                    }


                }
                else
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo");
                }
            }
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        HoaDonChiTietvIEW hdct = new HoaDonChiTietvIEW();
        //        hdct.idHoaDonCT = Guid.NewGuid();
        //        hdct.MaHDCt = MaHDCT();
        //        hdct.soLuong = Convert.ToInt32(tbxSoLuong.Text);
        //        hdct.tongTien = Convert.ToDouble(tbxTien.Text);
        //        hdct.tenSach = cbbSP.Text;
        //        hdct.giaBan = Convert.ToDouble(tbxGia.Text);
        //        hdct.idSanPham = sanPhamService.GetAll().Where(x => x.TenSach == cbbSP.Text).Select(x => x.IDsanPham).FirstOrDefault();
        //        hdct.IdHoaDon = hoaDonService.GetAll().Where(x => x.MaHD == label1.Text).Select(x => x.iDhoaDon).FirstOrDefault();
        //        var sanPham = sanPhamService.GetAll().FirstOrDefault(x => x.TenSach == cbbSP.Text);
        //        hoaDonChiTietService.Add(hdct);
        //        MessageBox.Show("Thêm thành công");
        //        LoadData();
        //        Clear();
        //    }
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var hdct = hoaDonChiTietService.GetAll().FirstOrDefault(x => x.idHoaDonCT == id);
            var sanPham = sanPhamService.GetAll().FirstOrDefault(x => x.IDsanPham == hdct.idSanPham);
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                hoaDonChiTietService.Delete(hdct);
                MessageBox.Show("Xóa thành công");
                LoadData();
                Clear();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtgProduct.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm để thanh toán.", "Thông báo");
                return; // Không có sản phẩm, không thực hiện các bước thanh toán khác
            }
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán hóa đơn không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Lấy thông tin hóa đơn
                string maHD = label1.Text; // Mã hóa đơn

                // Cập nhật trạng thái thanh toán và ngày thanh toán
                var hoaDon = hoaDonService.GetAll().FirstOrDefault(x => x.MaHD == maHD);
                hoaDon.trangThai = 1; // Trạng thái 1 có thể biểu thị là đã thanh toán
                hoaDon.ngayThanhToan = DateTime.Now;
                hoaDonService.Update(hoaDon);
                // Lấy thông tin chi tiết hóa đơn
                var chiTietHoaDon = hoaDonChiTietService.GetAll().Where(x => x.IdHoaDon == hoaDon.iDhoaDon);

                // Giảm số lượng tồn kho của từng sản phẩm trong hóa đơn chi tiết
                foreach (var chiTiet in chiTietHoaDon)
                {
                    var sanPham = sanPhamService.GetAll().FirstOrDefault(x => x.IDsanPham == chiTiet.idSanPham);
                    if (sanPham != null)
                    {
                        sanPham.SoLuongTon -= chiTiet.soLuong;
                        sanPhamService.Update(sanPham);
                    }
                }
                Clear();

                MessageBox.Show("Thanh toán thành công");
                DialogResult result1= MessageBox.Show("Bạn có muốn in hóa đơn không?","Thông báo", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(OnPrintPage);

                    // Hiển thị hộp thoại in và chọn máy in
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = pd;

                    DialogResult result2 = printDialog.ShowDialog();
                    if (result2 == DialogResult.OK)
                    {
                        // Bắt đầu quá trình in
                        pd.Print();
                    }
                }
                // Đóng form
                this.Close();
            }
        }
        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            decimal tongTienHoaDon = 0;
            Graphics g = e.Graphics;
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            Font contentFont = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Tiêu đề hóa đơn
            string title = "HÓA ĐƠN BÁN HÀNG";

            // Tính toán vị trí để đặt tiêu đề ở giữa trang
            float middleOfPage = e.MarginBounds.Width / 2 - g.MeasureString(title, headingFont).Width / 2;
            float verticalPosition = e.MarginBounds.Top;
            float startX = e.MarginBounds.Left;
            float startY = verticalPosition; // Lưu lại vị trí xuất phát để sử dụng sau này
            float horizontalSpacing = 200; // Khoảng cách giữa các cột

            // Vẽ tiêu đề ở giữa trang
            g.DrawString(title, headingFont, brush, new PointF(middleOfPage, verticalPosition));
            verticalPosition += g.MeasureString(title, headingFont).Height; // Tăng vị trí theo chiều dọc

            // Thông tin hóa đơn
            string maHoaDon = "Mã hóa đơn: " + label1.Text;
            string ngay = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");

            // Vẽ thông tin hóa đơn ở giữa trang
            g.DrawString(maHoaDon, contentFont, brush, new PointF(e.MarginBounds.Left, verticalPosition));
            verticalPosition += g.MeasureString(maHoaDon, contentFont).Height;

            g.DrawString(ngay, contentFont, brush, new PointF(e.MarginBounds.Left, verticalPosition));
            verticalPosition += g.MeasureString(ngay, contentFont).Height;

            // Vẽ một dòng phân cách giữa heading và chi tiết
            g.DrawLine(new Pen(Color.Black), e.MarginBounds.Left, verticalPosition, e.MarginBounds.Right, verticalPosition);
            verticalPosition += 10; // Tăng khoảng cách giữa heading và chi tiết

            // Thông tin chi tiết
            for (int i = 0; i < dtgProduct.Rows.Count; i++)
            {
                string tenSanPham = dtgProduct.Rows[i].Cells[2].Value?.ToString();
                string soLuong = dtgProduct.Rows[i].Cells[3].Value?.ToString();
                string giaTien = dtgProduct.Rows[i].Cells[4].Value?.ToString();

                if (decimal.TryParse(soLuong, out decimal soLuongTemp) && decimal.TryParse(giaTien, out decimal giaTienTemp))
                {
                    decimal tongTienSanPham = soLuongTemp * giaTienTemp;
                    tongTienHoaDon += tongTienSanPham;

                    // Vẽ thông tin chi tiết
                    g.DrawString("Tên sản phẩm: " + tenSanPham, contentFont, brush, new PointF(startX, verticalPosition));
                    g.DrawString("Số lượng: " + soLuong, contentFont, brush, new PointF(startX + horizontalSpacing, verticalPosition));
                    g.DrawString("Giá tiền: " + giaTien, contentFont, brush, new PointF(startX + 2 * horizontalSpacing, verticalPosition));

                    // Tăng khoảng cách giữa các sản phẩm
                    verticalPosition += g.MeasureString(tenSanPham, contentFont).Height + 10;
                }
            }
            string formattedTongTienHoaDon = tongTienHoaDon.ToString("C");
            g.DrawString("Tổng tiền hóa đơn: " + formattedTongTienHoaDon, contentFont, brush, new PointF(startX, verticalPosition));
        }
        private void Clear()
        {
            cbbSP.SelectedIndex = -1;
            tbxGia.Text = string.Empty;
            tbxSoLuong.Text = string.Empty;
        }

        private void btnLoadForm_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tbxSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhấn có phải là số không
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Nếu không phải là số, không cho phép nhập
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
           // Kiểm tra xem ký tự nhấn có phải là số không
    if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
    {
        // Nếu không phải là số, không cho phép nhập
        e.Handled = true;
    }
        }
    }
}
