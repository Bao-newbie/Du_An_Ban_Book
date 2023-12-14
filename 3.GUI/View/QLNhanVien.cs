using _1.DAL.Models;
using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _3.GUI.View
{
    public partial class QLNhanVien : Form
    {
        INhanVienServices iNhanVien;
        List<NhanVien> lstNhanVien;
        Guid id;
        public QLNhanVien()
        {
            InitializeComponent();
            iNhanVien = new NhanVienServices();
            lstNhanVien = new List<NhanVien>();
            LoadData();
        }

        private void LoadData()
        {
            dtgNhanVien.ColumnCount = 9;
            dtgNhanVien.Columns[0].HeaderText = "ID";
            dtgNhanVien.Columns[1].HeaderText = "Mã NV";
            dtgNhanVien.Columns[2].HeaderText = "Họ tên";
            dtgNhanVien.Columns[3].HeaderText = "SDT";
            dtgNhanVien.Columns[4].HeaderText = "Email";
            dtgNhanVien.Columns[5].HeaderText = "Địa chỉ";
            dtgNhanVien.Columns[6].HeaderText = "Chức vụ";
            dtgNhanVien.Columns[7].HeaderText = "Trạng thái";
            dtgNhanVien.Columns[8].HeaderText = "Mật khẩu";
            dtgNhanVien.Columns[0].Visible = false;
            dtgNhanVien.Rows.Clear();

            foreach (var x in iNhanVien.GetAll())
            {
                dtgNhanVien.Rows.Add(x.idNV, x.maNv, x.HoTen, x.SDT, x.Email, x.DiaChi, x.ChucVu, x.TrangThai == 0 ? "Hoạt động" : "Ngưng hoạt động", x.Password);
            }
        }

        string Ma()
        {
            string ma = "NV";
            Random rand = new Random();
            int a = rand.Next(1000, 9999);
            var so = a.ToString();
            return ma + so;
        }

        public bool checkChu(string text)
        {
            return Regex.IsMatch(text, "[a-zA-Z]+");
        }
        public bool checkSo(string text)
        {
            return Regex.IsMatch(text, "[\\d]+");
        }
        public bool checkPhoneNumber(string text)
        {
            return Regex.IsMatch(text, "^[0-9]{2}[0-9]{8}$");
        }
        public bool IsPhoneNumberExists(string phoneNumber)
        {
            return iNhanVien.GetAll().Any(kh => kh.SDT == phoneNumber);
        }
        public bool IsValidEmail(string username, int minLength, int maxLength)
        {
            int length = username.Length;

            if (length > minLength && length < maxLength)
            {
                return true;
            }

            return false;
        }
        public bool IsValidGmailEmail1(string email)
        {
            // Biểu thức chính quy kiểm tra địa chỉ email với tên miền là "gmail.com"
            string pattern = @"^[a-zA-Z0-9_.+-]+@gmail\.com$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        string Password()
        {
            Random rand = new Random();
            int a = rand.Next(100000, 999999);
            var so = a.ToString();
            return so;
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= iNhanVien.GetAll().Count) return;
            id = Guid.Parse(dtgNhanVien.CurrentRow.Cells[0].Value.ToString());
            var kh = iNhanVien.GetAll().FirstOrDefault(c => c.idNV.Equals(id));
            txtTenNV.Text = kh.HoTen;
            txtSdtNv.Text = kh.SDT;
            txtEmailNV.Text = kh.Email;
            txtDiaChiNv.Text = kh.DiaChi;
            cbbChucVu.Text = kh.ChucVu;
            rBtnHoatDong.Checked = kh.TrangThai == 0;
            rbtnNgungHD.Checked = kh.TrangThai == 1;
        }

        private void txtTimNv_TextChanged(object sender, EventArgs e)
        {
            dtgNhanVien.ColumnCount = 9;
            dtgNhanVien.Columns[0].HeaderText = "ID";
            dtgNhanVien.Columns[1].HeaderText = "Mã NV";
            dtgNhanVien.Columns[2].HeaderText = "Họ tên";
            dtgNhanVien.Columns[3].HeaderText = "SDT";
            dtgNhanVien.Columns[4].HeaderText = "Email";
            dtgNhanVien.Columns[5].HeaderText = "Địa chỉ";
            dtgNhanVien.Columns[6].HeaderText = "Chức vụ";
            dtgNhanVien.Columns[7].HeaderText = "Trạng thái";
            dtgNhanVien.Columns[8].HeaderText = "Mật khẩu";
            dtgNhanVien.Columns[0].Visible = false;
            dtgNhanVien.Rows.Clear();

            foreach (var x in iNhanVien.GetAll().Where(c => c.HoTen.StartsWith(txtTimNv.Text) || c.maNv.StartsWith(txtTimNv.Text)))
            {
                dtgNhanVien.Rows.Add(x.idNV, x.maNv, x.HoTen, x.SDT, x.Email, x.DiaChi, x.ChucVu, x.TrangThai == 0 ? "Hoạt động" : "Ngưng hoạt động", x.Password);
            }
        }

        private void btnThemNv_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResul = MessageBox.Show("Bạn có muốn sửa?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResul == DialogResult.Yes)
            {
                if (txtTenNV.Text == "" || txtSdtNv.Text == "" || cbbChucVu.Text == "" || txtEmailNV.Text == "" || txtDiaChiNv.Text == "" || rBtnHoatDong.Checked == false || rbtnNgungHD.Checked == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                }
                else if (checkSo(txtTenNV.Text) || checkChu(txtSdtNv.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng", "Thông báo");
                }
                else if (!checkPhoneNumber(txtSdtNv.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng số điện thoại", "Thông báo");
                }
                else if (IsPhoneNumberExists(txtSdtNv.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo");
                }
                else if (!IsValidGmailEmail1(txtEmailNV.Text))
                {
                    MessageBox.Show("Email sai định dạng ", "Thông báo");

                }
                else if (!IsValidEmail(txtEmailNV.Text, 4, 16))
                {
                    MessageBox.Show("Email chỉ được từ 5-15 ký tự", "Thông báo");
                }
                else
                {
                    var nv = new NhanVienView();

                    nv.idNV = Guid.NewGuid();
                    nv.maNv = Ma();
                    nv.HoTen = txtTenNV.Text;
                    nv.SDT = txtSdtNv.Text;
                    nv.Email = txtEmailNV.Text;
                    nv.DiaChi = txtDiaChiNv.Text;
                    nv.ChucVu = cbbChucVu.Text;
                    if (rBtnHoatDong.Checked)
                    {
                        nv.TrangThai = 0;
                    }
                    if (rbtnNgungHD.Checked)
                    {
                        nv.TrangThai = 1;
                    }
                    nv.Password = Password();
                    iNhanVien.Add(nv);
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                    Clear();
                }
            }
            if (dialogResul == DialogResult.No)
            {
                MessageBox.Show("Thêm không thành công");
                LoadData();
            }
        }

        private void btnSuaNv_Click(object sender, EventArgs e)
        {
            DialogResult dialogResul = MessageBox.Show("Bạn có muốn thêm?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResul == DialogResult.Yes)
            {
                if (txtTenNV.Text == "" || txtSdtNv.Text == "" || cbbChucVu.Text == "" || txtEmailNV.Text == "" || txtDiaChiNv.Text == "" || rBtnHoatDong.Checked == false || rbtnNgungHD.Checked == false)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                }
                else if (checkSo(txtTenNV.Text) || checkChu(txtSdtNv.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng", "Thông báo");
                }
                else if (!checkPhoneNumber(txtSdtNv.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng số điện thoại", "Thông báo");
                }
                else if (!IsValidGmailEmail1(txtEmailNV.Text))
                {
                    MessageBox.Show("Email sai định dạng ", "Thông báo");

                }
                else if (IsValidEmail(txtEmailNV.Text, 4, 16))
                {
                    MessageBox.Show("Email chỉ được từ 5-15 ký tự", "Thông báo");
                }
                else
                {
                    var nv = iNhanVien.GetAll().FirstOrDefault(x => x.idNV.Equals(id));
                    nv.maNv = Ma();
                    nv.HoTen = txtTenNV.Text;
                    nv.SDT = txtSdtNv.Text;
                    nv.Email = txtEmailNV.Text;
                    nv.DiaChi = txtDiaChiNv.Text;
                    nv.ChucVu = cbbChucVu.Text;
                    if (rBtnHoatDong.Checked)
                    {
                        nv.TrangThai = 0;
                    }
                    if (rbtnNgungHD.Checked)
                    {
                        nv.TrangThai = 1;
                    }
                    iNhanVien.Update(nv);
                    MessageBox.Show("Sửa thành công");
                    LoadData();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
                LoadData();
            }
        }

        public void Clear()
        {
            txtTenNV.Text = "";
            txtSdtNv.Text = "";
            txtDiaChiNv.Text = "";
            txtEmailNV.Text = "";
            cbbChucVu.Text = "";
            rbtnNgungHD.Checked = false;
            rBtnHoatDong.Checked = false;
        }

        private void QLNhanVien_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}


