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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI
{
    public partial class BillInFor : Form
    {
        IHoaDonChiTietService hoaDonChiTietService;
        IKhachHangService khachHangService;
        ISanPhamService sanPhamService;
        IHoaDonService hoaDonService;
        private string productName;
        private DateTime dateTime = new DateTime();

        public BillInFor()
        {
            hoaDonChiTietService = new HoaDonChiTietService();
            khachHangService = new KhachHangService();
            sanPhamService = new SanPhamService();
            hoaDonService = new HoaDonService();
            InitializeComponent();
            LoadData();
            LoadCBB();

        }

        public void LoadData()
        {
            int stt = 1;
            dtgProduct.ColumnCount = 5;
            dtgProduct.Columns[0].HeaderText = "ID";
            dtgProduct.Columns[1].HeaderText = "STT";
            dtgProduct.Columns[2].HeaderText = "Tên SP";
            dtgProduct.Columns[3].HeaderText = "Số lượng";
            dtgProduct.Columns[4].HeaderText = "Tổng tiền";
            dtgProduct.Columns[0].Visible = false;
            dtgProduct.Rows.Clear();
            foreach (var x in hoaDonChiTietService.GetAll())
            {
                dtgProduct.Rows.Add(x.idHoaDonCT, stt++, x.MaHDCt, x.sanPham.TenSach, x.soLuong, x.tongTien);
            }
            dateTime = DateTime.Now;
            tbxTime.Text = dateTime.ToString("dd/MM/yyyy") + " " + dateTime.ToString("HH:mm");
        }

        public void LoadCBB()
        {
            foreach (var item in sanPhamService.GetAll())
            {
                string tenSachVaSoLuong = $" {item.SoLuongTon} | {item.TenSach.Trim()}";
                cbbSP.Items.Add(tenSachVaSoLuong);

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var hd = new HoaDonChiTietvIEW()
                {

                };
            }
        }

        public double GetPrice1(string tenSp)
        {

            var lst = sanPhamService.GetAll().FirstOrDefault(c => c.TenSach.Equals(tenSp));
            if (lst != null)
            {
                return lst.GiaBan;

            }
            return 0;
        }


        private void cbbSP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbSP.SelectedIndex >= 0)
            {
                double giaSp = GetPrice1(cbbSP.SelectedItem.ToString());
                tbxGia.Text = giaSp.ToString();
            }
        }


        public string GetSDT(string Sdt)
        {
            var lsdt = khachHangService.GetAll().FirstOrDefault(c => c.sdt.Equals(Sdt));
            if (lsdt != null)
            {
                return lsdt?.Ten;
            }
            return "Không có khách hàng nào";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = txtSDT.Text;
            string name = GetSDT(phoneNumber);
            if (name != null)
            {
                lbTenKH.Text = name;
            }
            else
            {
                lbTenKH = null;
            }
        }
    }
}
