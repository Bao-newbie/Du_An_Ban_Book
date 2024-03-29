﻿using _2.BUS.IService;
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

namespace _3.GUI.View
{
    public partial class Bill : Form
    {
        IKhachHangService khachHangService;
        IHoaDonChiTietService hoaDonChiTietService;
        IHoaDonService hoaDonService;

        public Bill()
        {
            khachHangService = new KhachHangService();
            hoaDonChiTietService = new HoaDonChiTietService();
            hoaDonService = new HoaDonService();
            InitializeComponent();
            //LoadDataBill();
        }

        public void LoadDataBill()
        {
            dtgBill.ColumnCount = 6;
            dtgBill.Columns[0].Name = "ID";
            dtgBill.Columns[1].Name = "Mã khách hàng";
            dtgBill.Columns[2].Name = "Tên khách hàng";
            dtgBill.Columns[3].Name = "Tổng tiền";
            dtgBill.Columns[4].Name = "Trạng thái";
            dtgBill.Columns[5].Name = "Ngày thanh toán";
            dtgBill.Columns[0].Visible = false;
            dtgBill.Rows.Clear();
            foreach (var x in hoaDonService.GetAll())
            {
                dtgBill.Rows.Add(x.iDhoaDon, x.khachHang.MaKH, x.khachHang.Ten, x.HoaDonChiTiet.TongTien, x.trangThai, x.ngayThanhToan);
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
        private void btnBill_Click(object sender, EventArgs e)
        {
            BillInFor billInFor = new BillInFor();
            billInFor.ShowDialog();
        }
    }
}
