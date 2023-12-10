using _1.DAL.IRepositories;
using _1.DAL.Migrations;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using _3.GUI.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.View
{
    public partial class Menu : Form
    {

        ITacGiaService iTacGia;
        INhaCungCapService iNhaCungCap;
        INXBService iNXB;
        ITheLoaiService iTheLoai;
        IHinhThucBiaService iHinhThucBia;
        Guid id;
        public Menu()
        {
            InitializeComponent();
            iTacGia = new TacGiaService();
            iNhaCungCap = new NhaCungCapService();
            iNXB = new NXBService();
            iTheLoai = new TheLoaiService();
            iHinhThucBia = new HinhThucBiaService();
            LoadData();
            LoadDataNXB();
            LoadDataNCC();
            LoadDataTL();
            LoadDataLB();
            ClearForm();

        }
        #region
        public void LoadData()
        {
            dtgAuthor.ColumnCount = 7;
            dtgAuthor.Columns[0].HeaderText = "ID";
            dtgAuthor.Columns[1].HeaderText = "Mã TG";
            dtgAuthor.Columns[2].HeaderText = "Tên TG";
            dtgAuthor.Columns[3].HeaderText = "SDT";
            dtgAuthor.Columns[4].HeaderText = "Địa chỉ";
            dtgAuthor.Columns[5].HeaderText = "Email";
            dtgAuthor.Columns[7].HeaderText = "Trạng thái";
            dtgAuthor.Columns[0].Visible = false;
            dtgAuthor.Rows.Clear();
            foreach (var item in iTacGia.GetAll())
            {
                dtgAuthor.Rows.Add(item.idtacGia, item.MaTG, item.Ten, item.SDT, item.diaChi, item.Email, item.trangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }
        string MaTG()
        {
            string ma = "TG";
            Random rand = new Random();
            int a = rand.Next(1000, 9999);
            var so = a.ToString();
            return ma + so;
        }
        public void ClearForm()
        {
            Action<Control.ControlCollection> funct = null;
            funct = (controls) =>
            {
                foreach (Control control in controls)

                    if (control is TextBox)
                        (control as TextBox).Clear();

                    else
                        funct(control.Controls);

            };
            funct(Controls);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var tg = new TacGiaView();

                tg.idtacGia = Guid.NewGuid();
                tg.MaTG = MaTG();
                tg.Ten = tbxTenTG.Text;
                tg.SDT = tbxSdtTG.Text;
                tg.diaChi = tbxDiaChiTG.Text;
                tg.Email = tbxEmailTG.Text;
                if (rbtntacGiaHD.Checked)
                {
                    tg.trangThai = 0;
                }
                if (rbtntacGiaNHD.Checked)
                {
                    tg.trangThai = 1;
                }

                iTacGia.Add(tg);
                MessageBox.Show("Thêm thành công");
                LoadData();
                ClearForm();

            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var x = iTacGia.GetAll().FirstOrDefault(c => c.idtacGia.Equals(id));
                x.Ten = tbxTenTG.Text;
                x.SDT = tbxSdtTG.Text;
                x.diaChi = tbxDiaChiTG.Text;
                x.Email = tbxEmailTG.Text;
                if (rbtntacGiaHD.Checked)
                {
                    x.trangThai = 0;
                }
                if (rbtntacGiaNHD.Checked)
                {
                    x.trangThai = 1;
                }
                iTacGia.Update(x);
                MessageBox.Show("Sửa thành công");
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var x = iTacGia.GetAll().FirstOrDefault(c => c.idtacGia.Equals(id));
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                iTacGia.Delete(x);
                MessageBox.Show("Xoa thanh cong");
                LoadData();
                ClearForm();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void txbTimTG_TextChanged(object sender, EventArgs e)
        {
            dtgAuthor.ColumnCount = 7;
            dtgAuthor.Columns[0].HeaderText = "ID";
            dtgAuthor.Columns[1].HeaderText = "Mã TG";
            dtgAuthor.Columns[2].HeaderText = "Tên TG";
            dtgAuthor.Columns[3].HeaderText = "Tuổi";
            dtgAuthor.Columns[4].HeaderText = "SDT";
            dtgAuthor.Columns[5].HeaderText = "Địa chỉ";
            dtgAuthor.Columns[6].HeaderText = "Email";
            dtgAuthor.Columns[0].Visible = false;
            dtgAuthor.Rows.Clear();
            foreach (var item in iTacGia.GetAll().Where(c => c.Ten.ToLower().Contains(txbTimTG.Text)))
            {
                dtgAuthor.Rows.Add(item.idtacGia, item.MaTG, item.Ten, item.SDT, item.diaChi, item.Email);
            }
        }

        private void dtgAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= iTacGia.GetAll().Count) return;
            id = Guid.Parse(Convert.ToString(dtgAuthor.Rows[rd].Cells[0].Value));
            var tg = iTacGia.GetAll().FirstOrDefault(c => c.idtacGia.Equals(id));
            tbxTenTG.Text = tg.Ten;
            tbxSdtTG.Text = tg.SDT;
            tbxDiaChiTG.Text = tg.diaChi;
            tbxEmailTG.Text = tg.Email;

        }
        #endregion

        #region
        public void LoadDataNXB()
        {
            dtgNXB.ColumnCount = 6;
            dtgNXB.Columns[0].HeaderText = "ID";
            dtgNXB.Columns[1].HeaderText = "Mã NXB";
            dtgNXB.Columns[2].HeaderText = "Tên NXB";
            dtgNXB.Columns[3].HeaderText = "SDT";
            dtgNXB.Columns[4].HeaderText = "Địa chỉ";
            dtgNXB.Columns[5].HeaderText = "Trạng thái";
            dtgNXB.Columns[0].Visible = false;
            dtgNXB.Rows.Clear();
            foreach (var item in iNXB.GetAll())
            {
                dtgNXB.Rows.Add(item.idNXB, item.MaNXB, item.TenNXB, item.SDT, item.diaChi, item.trangThai == 0 ? "Hoạt động" : "Ngưng hoạt động");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var tg = new NXBView();

                tg.idNXB = Guid.NewGuid();
                tg.MaNXB = tbxMaNXB.Text;
                tg.TenNXB = tbxTenNXB.Text;
                tg.SDT = tbxSdtNXB.Text;
                tg.diaChi = tbxDcNXB.Text;
                if (rBtnNxbHD.Checked)
                {
                    tg.trangThai = 0;
                }
                if (rbtnNxbNgungHD.Checked)
                {
                    tg.trangThai = 1;
                }


                iNXB.Add(tg);
                MessageBox.Show("Thêm thành công");
                LoadDataNXB();
                ClearForm();

            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var x = iNXB.GetAll().FirstOrDefault(c => c.idNXB.Equals(id));
                x.MaNXB = tbxMaNXB.Text;
                x.TenNXB = tbxTenNXB.Text;
                x.SDT = tbxSdtNXB.Text;
                x.diaChi = tbxDcNXB.Text;
                if (rBtnNxbHD.Checked)
                {
                    x.trangThai = 0;
                }
                if (rbtnNxbNgungHD.Checked)
                {
                    x.trangThai = 1;
                }
                iNXB.Update(x);
                MessageBox.Show("Sửa thành công");
                LoadDataNXB();
                ClearForm();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            var x = iNXB.GetAll().FirstOrDefault(c => c.idNXB.Equals(id));
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                iNXB.Delete(x);
                MessageBox.Show("Xoa thanh cong");
                LoadDataNXB();
                ClearForm();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void txbTimNXB_TextChanged(object sender, EventArgs e)
        {
            dtgNXB.ColumnCount = 6;
            dtgNXB.Columns[0].HeaderText = "ID";
            dtgNXB.Columns[1].HeaderText = "Mã NXB";
            dtgNXB.Columns[2].HeaderText = "Tên NXB";
            dtgNXB.Columns[3].HeaderText = "SDT";
            dtgNXB.Columns[4].HeaderText = "Địa chỉ";
            dtgNXB.Columns[5].HeaderText = "Trạng thái";
            dtgNXB.Columns[0].Visible = false;
            dtgNXB.Rows.Clear();
            foreach (var item in iNXB.GetAll().Where(c => c.TenNXB.ToLower().Contains(txbTimNXB.Text)))
            {
                dtgNXB.Rows.Add(item.idNXB, item.MaNXB, item.TenNXB, item.SDT, item.diaChi, item.trangThai == 0 ? "Hoạt động" : "Ngưng hoạt động");
            }
        }

        private void dtgNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= iNXB.GetAll().Count) return;
            id = Guid.Parse(Convert.ToString(dtgNXB.Rows[rd].Cells[0].Value));
            var tg = iNXB.GetAll().FirstOrDefault(c => c.idNXB.Equals(id));
            tbxMaNXB.Text = tg.MaNXB;
            tbxTenNXB.Text = tg.TenNXB;
            tbxSdtNXB.Text = tg.SDT;
            tbxDcNXB.Text = tg.diaChi;
            rBtnNxbHD.Checked = tg.trangThai == 0;
            rbtnNxbNgungHD.Checked = tg.trangThai == 1;
        }
        #endregion

        #region
        public void LoadDataNCC()
        {
            dtgNCC.ColumnCount = 5;
            dtgNCC.Columns[0].HeaderText = "ID";
            dtgNCC.Columns[1].HeaderText = "Mã nhà cung cấp";
            dtgNCC.Columns[2].HeaderText = "Tên nhà cung cấp";
            dtgNCC.Columns[3].HeaderText = "SDT";
            dtgNCC.Columns[4].HeaderText = "Địa chỉ";
            dtgNCC.Columns[5].HeaderText = "Trạng thái";
            dtgNCC.Columns[0].Visible = false;
            dtgNCC.Rows.Clear();
            foreach (var item in iNhaCungCap.GetAll())
            {
                dtgNCC.Rows.Add(item.idNhaCC, item.MaNhaCungCap, item.TenNCC, item.SDT, item.diaChi, item.trangThai == 0 ? "Hoạt động" : "Ngưng hoạt động");
            }
        }
        private void btnAddNCC_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var ncc = new NhaCungCapView();

                ncc.idNhaCC = Guid.NewGuid();
                ncc.MaNhaCungCap = tbxMaNCC.Text;
                ncc.TenNCC = tbxTenNCC.Text;
                ncc.SDT = tbxSdtNCC.Text;
                ncc.diaChi = tbxDiaChiNCC.Text;
                if (rbtnNccHD.Checked)
                {
                    ncc.trangThai = 0;
                }
                if (rbtnNccNHD.Checked)
                {
                    ncc.trangThai = 1;
                }

                iNhaCungCap.Add(ncc);
                MessageBox.Show("Thêm thành công");
                LoadDataNCC();
                ClearForm();

            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnEditNCC_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var x = iNhaCungCap.GetAll().FirstOrDefault(c => c.idNhaCC.Equals(id));
                x.MaNhaCungCap = tbxMaNCC.Text;
                x.TenNCC = tbxTenNCC.Text;
                x.SDT = tbxSdtNCC.Text;
                x.diaChi = tbxDiaChiNCC.Text;
                if (rbtnNccHD.Checked)
                {
                    x.trangThai = 0;
                }
                if (rbtnNccNHD.Checked)
                {
                    x.trangThai = 1;
                }
                iNhaCungCap.Update(x);
                MessageBox.Show("Sửa thành công");
                LoadDataNCC();
                ClearForm();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnDeleteNCC_Click(object sender, EventArgs e)
        {
            var x = iNhaCungCap.GetAll().FirstOrDefault(c => c.idNhaCC.Equals(id));
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                iNhaCungCap.Delete(x);
                MessageBox.Show("Xoa thanh cong");
                LoadDataNCC();
                ClearForm();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void tbxTimNCC_TextChanged(object sender, EventArgs e)
        {
            dtgNCC.ColumnCount = 5;
            dtgNCC.Columns[0].HeaderText = "ID";
            dtgNCC.Columns[1].HeaderText = "Mã nhà cung cấp";
            dtgNCC.Columns[2].HeaderText = "Tên nhà cung cấp";
            dtgNCC.Columns[3].HeaderText = "SDT";
            dtgNCC.Columns[4].HeaderText = "Địa chỉ";
            dtgNCC.Columns[5].HeaderText = "Trạng thái";
            dtgNCC.Columns[0].Visible = false;
            dtgNCC.Rows.Clear();
            foreach (var item in iNhaCungCap.GetAll().Where(c => c.TenNCC.ToLower().Contains(tbxTimNCC.Text)))
            {
                dtgNCC.Rows.Add(item.idNhaCC, item.MaNhaCungCap, item.TenNCC, item.SDT, item.diaChi, item.trangThai == 0 ? "Hoạt động" : "Ngưng hoạt động");
            }
        }
        private void dtgNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= iNXB.GetAll().Count) return;
            id = Guid.Parse(Convert.ToString(dtgNCC.Rows[rd].Cells[0].Value));
            var tg = iNhaCungCap.GetAll().FirstOrDefault(c => c.idNhaCC.Equals(id));
            tbxMaNCC.Text = tg.MaNhaCungCap;
            tbxTenNCC.Text = tg.TenNCC;
            tbxSdtNCC.Text = tg.SDT;
            tbxDiaChiNCC.Text = tg.diaChi;
            rbtnNccHD.Checked = tg.trangThai == 0;
            rbtnNccNHD.Checked = tg.trangThai == 1;
        }

        #endregion

        #region
        public void LoadDataTL()
        {
            dtgTL.ColumnCount = 3;
            dtgTL.Columns[0].HeaderText = "ID";
            dtgTL.Columns[1].HeaderText = "Mã thể loại";
            dtgTL.Columns[2].HeaderText = "Tên thể loại";
            dtgTL.Columns[0].Visible = false;
            dtgTL.Rows.Clear();
            foreach (var item in iTheLoai.GetAll())
            {
                dtgTL.Rows.Add(item.idTheLoai, item.MaTheLoai, item.TenTheLoai);
            }
        }
        string MaTL()
        {
            string ma = "TL";
            Random rand = new Random();
            int a = rand.Next(1000, 9999);
            var so = a.ToString();
            return ma + so;
        }
        private void btnAddTL_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var tg = new TheLoaiView()
                {
                    idTheLoai = Guid.NewGuid(),
                    MaTheLoai = MaTL(),
                    TenTheLoai = tbxTenTL.Text,

                };
                iTheLoai.Add(tg);
                MessageBox.Show("Thêm thành công");
                LoadDataTL();
                ClearForm();

            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnEditTL_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var x = iTheLoai.GetAll().FirstOrDefault(c => c.idTheLoai.Equals(id));
                x.MaTheLoai = tbxMaTL.Text;
                x.TenTheLoai = tbxTenTL.Text;
                iTheLoai.Update(x);
                MessageBox.Show("Sửa thành công");
                LoadDataTL();
                ClearForm();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Sửa không thành công");
            }
        }
        private void btnDeleteTL_Click(object sender, EventArgs e)
        {
            var x = iTheLoai.GetAll().FirstOrDefault(c => c.idTheLoai.Equals(id));
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                iTheLoai.Delete(x);
                MessageBox.Show("Xoa thanh cong");
                LoadDataTL();
                ClearForm();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
        private void tbxTimTL_TextChanged(object sender, EventArgs e)
        {
            dtgTL.ColumnCount = 3;
            dtgTL.Columns[0].HeaderText = "ID";
            dtgTL.Columns[1].HeaderText = "Mã thể loại";
            dtgTL.Columns[2].HeaderText = "Tên thể loại";
            dtgTL.Columns[0].Visible = false;
            dtgTL.Rows.Clear();
            foreach (var item in iTheLoai.GetAll().Where(c => c.TenTheLoai.ToLower().Contains(tbxTimTL.Text)))
            {
                dtgTL.Rows.Add(item.idTheLoai, item.MaTheLoai, item.TenTheLoai);
            }
        }

        private void dtgTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= iTheLoai.GetAll().Count) return;
            id = Guid.Parse(Convert.ToString(dtgTL.Rows[rd].Cells[0].Value));
            var tg = iTheLoai.GetAll().FirstOrDefault(c => c.idTheLoai.Equals(id));
            tbxMaTL.Text = tg.MaTheLoai;
            tbxTenTL.Text = tg.TenTheLoai;
        }
        #endregion

        #region
        public void LoadDataLB()
        {
            dtgLB.ColumnCount = 3;
            dtgLB.Columns[0].HeaderText = "ID";
            dtgLB.Columns[1].HeaderText = "Mã Bìa";
            dtgLB.Columns[2].HeaderText = "Loại bìa";
            dtgLB.Columns[0].Visible = false;
            dtgLB.Rows.Clear();
            foreach (var item in iHinhThucBia.GetAll())
            {
                dtgLB.Rows.Add(item.idBia, item.MaBia, item.LoaiBia);
            }
        }
        string MaBia()
        {
            string ma = "B";
            Random rand = new Random();
            int a = rand.Next(1000, 9999);
            var so = a.ToString();
            return ma + so;
        }
        private void btnAddLB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var tg = new HinhThucBiaView()
                {
                    idBia = Guid.NewGuid(),
                    MaBia = MaBia(),
                    LoaiBia = tbxTenBia.Text,

                };
                iHinhThucBia.Add(tg);
                MessageBox.Show("Thêm thành công");
                LoadDataLB();
                ClearForm();

            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnUpdateLB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var x = iHinhThucBia.GetAll().FirstOrDefault(c => c.idBia.Equals(id));
                x.MaBia = tbxMaLB.Text;
                x.LoaiBia = tbxTenBia.Text;
                iHinhThucBia.Update(x);
                MessageBox.Show("Sửa thành công");
                LoadDataLB();
                ClearForm();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnDeleteLB_Click(object sender, EventArgs e)
        {
            var x = iHinhThucBia.GetAll().FirstOrDefault(c => c.idBia.Equals(id));
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                iHinhThucBia.Delete(x);
                MessageBox.Show("Xoa thanh cong");
                LoadDataLB();
                ClearForm();
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
        private void dtgLB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= iHinhThucBia.GetAll().Count) return;
            id = Guid.Parse(Convert.ToString(dtgLB.Rows[rd].Cells[0].Value));
            var lb = iHinhThucBia.GetAll().FirstOrDefault(c => c.idBia.Equals(id));
            tbxMaLB.Text = lb.MaBia;
            tbxTenBia.Text = lb.LoaiBia;
        }
        private void txbTimBia_TextChanged(object sender, EventArgs e)
        {
            dtgLB.ColumnCount = 3;
            dtgLB.Columns[0].HeaderText = "ID";
            dtgLB.Columns[1].HeaderText = "Mã Bìa";
            dtgLB.Columns[2].HeaderText = "Loại bìa";
            dtgLB.Columns[0].Visible = false;
            dtgLB.Rows.Clear();
            foreach (var item in iHinhThucBia.GetAll().Where(x => x.LoaiBia.ToLower().Contains(txbTimBia.Text)))
            {
                dtgLB.Rows.Add(item.idBia, item.MaBia, item.LoaiBia);
            }
        }
        #endregion


    }
}
