using _1.DAL.Models;
using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.View
{
    public partial class BookStore : Form
    {
        ITacGiaService iTacGia;
        INhaCungCapService iNhaCungCap;
        INXBService iNXB;
        ITheLoaiService iITheLoai;
        IHinhThucBiaService iHinhThucBia;
        ISanPhamService iSanPham;
        SanPham _ctsp;
        Guid id;

        private Image AnhURL;
        private string imgLocation;
        private string selectedImagePath;
        public BookStore()
        {
            InitializeComponent();
            iTacGia = new TacGiaService();
            iNhaCungCap = new NhaCungCapService();
            iNXB = new NXBService();
            iITheLoai = new TheLoaiService();
            iHinhThucBia = new HinhThucBiaService();
            iSanPham = new SanPhamService();
            LoadDataProduct();
            LoadCBB();
            ClearForm();
        }

        public void LoadDataProduct()
        {
            dtgProduct.ColumnCount = 14;
            dtgProduct.Columns[0].Name = "ID";
            dtgProduct.Columns[1].Name = "Mã sách";
            dtgProduct.Columns[2].Name = "Tên sách";
            dtgProduct.Columns[3].Name = "Tác giả";
            dtgProduct.Columns[4].Name = "Số lượng";
            dtgProduct.Columns[5].Name = "Giá nhập";
            dtgProduct.Columns[6].Name = "Giá bán";
            dtgProduct.Columns[7].Name = "Nhà cung cấp";
            dtgProduct.Columns[8].Name = "Nhà xuất bản";
            dtgProduct.Columns[9].Name = "Thể loại";
            dtgProduct.Columns[10].Name = "Loại bìa";
            dtgProduct.Columns[11].Name = "Mô tả";
            dtgProduct.Columns[12].Name = "Trạng thái";
            dtgProduct.Columns[0].Visible = false;
            dtgProduct.Rows.Clear();
            foreach (var x in iSanPham.GetAll())
            {
                dtgProduct.Rows.Add(x.IDsanPham, x.MaSP, x.TenSach, x.TenTG, x.SoLuongTon, x.GiaNhap, x.GiaBan, x.TenNCC, x.TenNXB,
                    x.TenTheLoai, x.LoaiBia, x.MoTa, x.TrangThai == 0 ? "Còn hàng" : "Hết hàng");
            }
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                // Tạo một hàng mới trong DataGridView
                int rowIndex = dtgProduct.Rows.Add();

                // Tạo đối tượng Image từ đường dẫn ảnh
                Image hinhAnh = Image.FromFile(selectedImagePath);

                // Gán ảnh vào cột kiểu hình ảnh của hàng vừa tạo
                dtgProduct.Rows[rowIndex].Cells["anhsp"].Value = hinhAnh;

                // Đặt lại selectedImagePath để chuẩn bị cho lần chọn ảnh tiếp theo
                selectedImagePath = null;
            }
        }
        public void ClearForm()
        {
            LoadDataProduct();
            tbxTenSach.Text = null;
            tbxSoLuong.Text = null;
            cbbTacGia.Text = null;
            tbxGiaNhap.Text = null;
            tbxGiaBan.Text = null;
            cbbBia.Text = null;
            cbbNCC.Text = null;
            cbbNXB.Text = null;
            cbbTL.Text = null;
            rBtnConHang.Checked = false;
            rBtnHetHang.Checked = false;
            tbxMoTa.Text = null;
            pcb_IMG.Image = null;
            txbTimSach.Text = null;
            //Action<Control.ControlCollection> funct = null;
            //funct = (controls) =>
            //{
            //    foreach (Control control in controls)

            //        if (control is TextBox)
            //            (control as TextBox).Clear();
            //        else
            //            funct(control.Controls);

            //};
            //funct(Controls);

        }

        private void LoadCBB()
        {
            foreach (var x in iHinhThucBia.GetAll())
            {
                cbbBia.Items.Add(x.LoaiBia);
            }
            foreach (var x in iNhaCungCap.GetAll())
            {
                cbbNCC.Items.Add(x.TenNCC);
            }
            foreach (var x in iNXB.GetAll())
            {
                cbbNXB.Items.Add(x.TenNXB);
            }
            foreach (var x in iTacGia.GetAll())
            {
                cbbTacGia.Items.Add(x.Ten);
            }
            foreach (var x in iITheLoai.GetAll())
            {
                cbbTL.Items.Add(x.TenTheLoai);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var checkMa = iSanPham.GetAll().Where(c => c.MaSP == Ma()).Count();
            if (checkMa > 1)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại");
                return;
            }

            string Ma()
            {
                string ma = "MS";
                Random rand = new Random();
                int a = rand.Next(1000, 9999);
                var so = a.ToString();
                return ma + so;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SanPhamView sp = new SanPhamView();
                sp.MaSP = Ma();
                sp.TenSach = tbxTenSach.Text;
                sp.SoLuongTon = Convert.ToInt32(tbxSoLuong.Text);
                sp.GiaNhap = Convert.ToDouble(tbxGiaNhap.Text);
                sp.GiaBan = Convert.ToDouble(tbxGiaBan.Text);
                sp.MoTa = tbxMoTa.Text;
                if (rBtnConHang.Checked)
                {
                    sp.TrangThai = 0;
                }
                if (rBtnHetHang.Checked)
                {
                    sp.TrangThai = 1;
                }
                sp.Anh = imgLocation;
                sp.idTacGia = iTacGia.GetAll().Where(c => c.Ten == cbbTacGia.Text).Select(c => c.idtacGia).FirstOrDefault();
                sp.idHinhThucBia = iHinhThucBia.GetAll().Where(c => c.LoaiBia == cbbBia.Text).Select(c => c.idBia).FirstOrDefault();
                sp.idNhaCungCap = iNhaCungCap.GetAll().Where(c => c.TenNCC == cbbNCC.Text).Select(c => c.idNhaCC).FirstOrDefault();
                sp.idNXB = iNXB.GetAll().Where(c => c.TenNXB == cbbNXB.Text).Select(c => c.idNXB).FirstOrDefault();
                sp.idTheLoai = iITheLoai.GetAll().Where(c => c.TenTheLoai == cbbTL.Text).Select(c => c.idTheLoai).FirstOrDefault();

                iSanPham.Add(sp);
                MessageBox.Show("Thêm thành công");
                LoadDataProduct();
                ClearForm();


            }

        }


        private void btnUpImg_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pcb_IMG.Image = new Bitmap(fileDialog.FileName);
                imgLocation = fileDialog.FileName;
            }
        }

        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= iSanPham.GetAll().Count) return;
            id = Guid.Parse(dtgProduct.CurrentRow.Cells[0].Value.ToString());
            var sp = iSanPham.GetAll().FirstOrDefault(c => c.IDsanPham.Equals(id));
            tbxTenSach.Text = sp.TenSach;
            tbxSoLuong.Text = Convert.ToString(sp.SoLuongTon);
            cbbTacGia.Text = sp.TenTG;
            tbxGiaNhap.Text = Convert.ToString(sp.GiaNhap);
            tbxGiaBan.Text = Convert.ToString(sp.GiaBan);
            cbbBia.Text = sp.LoaiBia;
            cbbNCC.Text = sp.TenNCC;
            cbbNXB.Text = sp.TenNXB;
            cbbTL.Text = sp.TenTheLoai;
            rBtnConHang.Checked = sp.TrangThai == 0;
            rBtnHetHang.Checked = sp.TrangThai == 1;
            tbxMoTa.Text = sp.MoTa;
            if (sp.Anh != null && sp.Anh.Length > 0)
            {
                pcb_IMG.Image = Image.FromFile(sp.Anh);
            }
            else
            {
                pcb_IMG.Image = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var sp = iSanPham.GetAll().FirstOrDefault(p => p.IDsanPham.Equals(id));
                sp.TenSach = tbxTenSach.Text;
                sp.SoLuongTon = Convert.ToInt32(tbxSoLuong.Text);
                sp.GiaNhap = Convert.ToDouble(tbxGiaNhap.Text);
                sp.GiaBan = Convert.ToDouble(tbxGiaBan.Text);
                sp.MoTa = tbxMoTa.Text;
                if (rBtnConHang.Checked)
                {
                    sp.TrangThai = 0;
                }
                if (rBtnHetHang.Checked)
                {
                    sp.TrangThai = 1;
                }
                sp.idTacGia = iTacGia.GetAll().Where(c => c.Ten == cbbTacGia.Text).Select(c => c.idtacGia).FirstOrDefault();
                sp.idHinhThucBia = iHinhThucBia.GetAll().Where(c => c.LoaiBia == cbbBia.Text).Select(c => c.idBia).FirstOrDefault();
                sp.idNhaCungCap = iNhaCungCap.GetAll().Where(c => c.TenNCC == cbbNCC.Text).Select(c => c.idNhaCC).FirstOrDefault();
                sp.idNXB = iNXB.GetAll().Where(c => c.TenNXB == cbbNXB.Text).Select(c => c.idNXB).FirstOrDefault();
                sp.idTheLoai = iITheLoai.GetAll().Where(c => c.TenTheLoai == cbbTL.Text).Select(c => c.idTheLoai).FirstOrDefault();

                // Kiểm tra xem người dùng đã chọn một hình ảnh mới chưa
                if (!string.IsNullOrEmpty(imgLocation))
                {
                    sp.Anh = imgLocation; // Cập nhật đường dẫn hình ảnh
                }

                iSanPham.Update(sp);
                MessageBox.Show("Sửa thành công");
                LoadDataProduct();
                ClearForm();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var sp = iSanPham.GetAll().FirstOrDefault(x => x.IDsanPham == id);
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                iSanPham.Delete(sp);
                MessageBox.Show("Xóa thành công");
                LoadDataProduct();
                ClearForm();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
        private void txbTimSach_TextChanged(object sender, EventArgs e)
        {
            dtgProduct.ColumnCount = 14;
            dtgProduct.Columns[0].Name = "ID";
            dtgProduct.Columns[1].Name = "Mã sách";
            dtgProduct.Columns[2].Name = "Tên sách";
            dtgProduct.Columns[3].Name = "Tác giả";
            dtgProduct.Columns[4].Name = "Số lượng";
            dtgProduct.Columns[5].Name = "Giá nhập";
            dtgProduct.Columns[6].Name = "Giá bán";
            dtgProduct.Columns[7].Name = "Nhà cung cấp";
            dtgProduct.Columns[8].Name = "Nhà xuất bản";
            dtgProduct.Columns[9].Name = "Thể loại";
            dtgProduct.Columns[10].Name = "Loại bìa";
            dtgProduct.Columns[11].Name = "Mô tả";
            dtgProduct.Columns[12].Name = "Trạng thái";
            dtgProduct.Columns[0].Visible = false;
            dtgProduct.Rows.Clear();
            foreach (var x in iSanPham.GetAll().Where(c => c.TenSach.StartsWith(txbTimSach.Text) || c.MaSP.StartsWith(txbTimSach.Text)))
            {
                dtgProduct.Rows.Add(x.IDsanPham, x.MaSP, x.TenSach, x.TenTG, x.SoLuongTon, x.GiaNhap, x.GiaBan, x.TenNCC, x.TenNXB,
                    x.TenTheLoai, x.LoaiBia, x.MoTa, x.TrangThai == 0 ? "Còn hàng" : "Hết hàng");
            }
            //if (!string.IsNullOrEmpty(selectedImagePath))
            //{
            //    // Tạo một hàng mới trong DataGridView
            //    int rowIndex = dtgProduct.Rows.Add();

            //    // Tạo đối tượng Image từ đường dẫn ảnh
            //    Image hinhAnh = Image.FromFile(selectedImagePath);

            //    // Gán ảnh vào cột kiểu hình ảnh của hàng vừa tạo
            //    dtgProduct.Rows[rowIndex].Cells["anhsp"].Value = hinhAnh;

            //    // Đặt lại selectedImagePath để chuẩn bị cho lần chọn ảnh tiếp theo
            //    selectedImagePath = null;
            //}
            if (string.IsNullOrEmpty(txbTimSach.Text))
            {
                ClearForm();
            }
        }
    }
}
