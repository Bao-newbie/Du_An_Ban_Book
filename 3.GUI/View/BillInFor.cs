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
        string productName;
        private DateTime dateTime = new DateTime();

        public BillInFor()
        {
            InitializeComponent();
            hoaDonChiTietService = new HoaDonChiTietService();
            khachHangService = new KhachHangService();
            sanPhamService = new SanPhamService();
            hoaDonService = new HoaDonService();
            LoadData();
            LoadCBB();

        }
        public void LoadData()
        {
            int stt = 1;
            dtgProduct.ColumnCount = 6;
            dtgProduct.Columns[0].HeaderText = "ID";
            dtgProduct.Columns[1].HeaderText = "STT";
            dtgProduct.Columns[2].HeaderText = "Mã sách";
            dtgProduct.Columns[3].HeaderText = "Tên sách";
            dtgProduct.Columns[4].HeaderText = "Số lượng";
            dtgProduct.Columns[5].HeaderText = "Tổng tiền";
            dtgProduct.Columns[0].Visible = false;
            dtgProduct.Rows.Clear();
            foreach (var x in hoaDonChiTietService.GetAll())
            {
                dtgProduct.Rows.Add(x.idHoaDonCT, stt++, x.sanPham.MaSach, x.sanPham.TenSach, x.soLuong, x.tongTien);
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
        string Ma()
        {
            string ma = "HD";
            Random rand = new Random();
            int a = rand.Next(1000, 9999);
            var so = a.ToString();
            return ma + so;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm hóa đơn không ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                double tong = 0;
                foreach (var x in hoaDonChiTietService.GetAll())
                {
                    tong += x.giaBan * x.soLuong;
                }
                var sp = sanPhamService.GetAll().FirstOrDefault(c => c.TenSach == cbbSP.Text);
                var kh = khachHangService.GetAll().FirstOrDefault(c => c.sdt == txtSDT.Text);
                HoaDonChiTietvIEW hdct = new HoaDonChiTietvIEW();
                hdct.soLuong = Convert.ToInt32(tbxSoLuong.Text);
                hdct.MaHDCt = Ma();
                hdct.tongTien = tong;
                hdct.idSanPham = sanPhamService.GetAll().Where(c => c.TenSach == cbbSP.Text).Select(c => c.IDsanPham).FirstOrDefault();
                foreach (var x in hoaDonChiTietService.GetAll())
                {
                    HoaDonChiTietvIEW hdctv = new HoaDonChiTietvIEW();
                    hdctv.idHoaDonCT = hdctv.idHoaDonCT;
                    hdctv.MaHDCt = Ma();
                    hdctv.soLuong = hdctv.soLuong;
                    hdctv.tongTien = hdctv.tongTien;
                    hdctv.maSach = hdctv.maSach;
                    hdctv.tenSach = hdctv.tenSach;
                    hdctv.giaBan = hdctv.giaBan;
                    hdctv.soLuongTon = hdctv.soLuongTon;
                }
                hoaDonChiTietService.Add(hdct);
                MessageBox.Show("Them thanh cong");
            }
            //DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    double tong = 0;
            //    foreach (var x in hoaDonChiTietService.GetAll())
            //    {
            //        tong += x.giaBan * x.soLuong;
            //    }
            //    var sp = sanPhamService.GetAll().FirstOrDefault(c => c.TenSach == cbbSP.Text);
            //    var kh = khachHangService.GetAll().FirstOrDefault(c => c.sdt == txtSDT.Text);


            //    HoaDonChiTietvIEW hdct = new HoaDonChiTietvIEW();

            //    hdct.soLuong = Convert.ToInt32(tbxSoLuong.Text);
            //    hdct.tongTien = tong;
            //    hdct.MaHDCt = Ma();
            //    hdct.idSanPham = sanPhamService.GetAll().Where(c => c.TenSach == cbbSP.Text).Select(c => c.IDsanPham).FirstOrDefault();
            //    //hdct.idSanPham = sanPhamService.GetAll().Where(c => c.GiaBan == Convert.ToDouble(tbxGia.Text)).Select(c => c.IDsanPham).FirstOrDefault();
            //    hdct.IdHoaDon = hoaDonService.GetAll().Where(c => c.ngayThanhToan == Convert.ToDateTime(tbxTime.Text)).Select(c => c.iDhoaDon).FirstOrDefault();

            //    foreach (var x in hoaDonService.GetAll())
            //    {
            //        HoaDonView hd = new HoaDonView();
            //        hd.iDhoaDon = hdct.IdHoaDon;
            //        hd.MaHD = Ma();
            //        hd.iDkhachHang = kh.IdKhachHang;
            //        hd.ngayThanhToan = DateTime.Now;
            //        hd.trangThai = 0;

            //    }
            //    hoaDonChiTietService.Add(hdct);
            //    MessageBox.Show("Them thanh cong");
            //}
            //else
            //{
            //    MessageBox.Show("Them that bai cmnr");
            //}
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
        // error
        private void cbbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbbSP.SelectedIndex >= 0)
            //{
            //    double giaSp = GetPrice1(cbbSP.SelectedItem.ToString());
            //    tbxGia.Text = giaSp.ToString() + "VND";
            //}
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
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

            string phoneNumber = txtSDT.Text;

            string name = GetSDT(phoneNumber);
            if (name != null)
            {
                lbTenKH.Text = name;
            }

        }
    }
}
