using _1.DAL.Models;
using _2.BUS.IService;
using _2.BUS.Service;
using Microsoft.EntityFrameworkCore;
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
    public partial class Login : Form
    {
        INhanVienServices iNhanVien;
        List<NhanVien> lstNhanVien;
        public Login()
        {
            InitializeComponent();
            lstNhanVien = new List<NhanVien>();
            iNhanVien = new NhanVienServices();
        }
        private bool IsValidLogin(string username, string password)
        {
            // Kiểm tra thông tin đăng nhập và phân quyền ở đây
            // Trong ví dụ này, giả sử thông tin đăng nhập là "admin" và "password"
            return username == "quan380@gmail.com" && password == "3802310";
        }
        bool CheckLogin(string userName, string passWord)
        {
            // Thực hiện truy vấn trong cơ sở dữ liệu để kiểm tra đăng nhập
            var user = iNhanVien.GetAll().FirstOrDefault(x => x.Email == userName && x.Password == passWord);

            // Nếu tìm thấy người dùng, đăng nhập thành công
            return user != null;
        }
        private void txtEmailLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emal = txtEmailLogin.Text;
            string passWord = txtPassLogin.Text;
            if (IsValidLogin(txtEmailLogin.Text, txtPassLogin.Text))
            {
                Main f = new Main();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else if(CheckLogin(emal, passWord))
            {
                Main f = new Main();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Hãy thử lại!");
            }
        }
        private void F_Logout(object? sender, EventArgs e)
        {
            (sender as Main).isExit = false;
            (sender as Main).Close();
            this.Show();
        }
    }
}
