using _2.BUS.IService;
using _2.BUS.Service;
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
        public BillInFor()
        {
            hoaDonChiTietService = new HoaDonChiTietService();
            khachHangService = new KhachHangService();
            sanPhamService = new SanPhamService();
            InitializeComponent();
            LoadData();
            LoadCBB();  
        }

        public void LoadData()
        {
            int stt =1;
            dtgProduct.ColumnCount = 6;
            dtgProduct.Columns[0].HeaderText = "ID";
            dtgProduct.Columns[1].HeaderText = "STT";
            dtgProduct.Columns[2].HeaderText = "Mã HD";
            dtgProduct.Columns[3].HeaderText = "Tên SP";
            dtgProduct.Columns[4].HeaderText = "Số lượng";
            dtgProduct.Columns[5].HeaderText = "Tổng tiền";
            dtgProduct.Columns[0].Visible = false;
            dtgProduct.Rows.Clear();
            foreach (var x in hoaDonChiTietService.GetAll())
            {
                dtgProduct.Rows.Add(x.idHoaDonCT, stt++, x.MaHDCt, x.sanPham.TenSach, x.soLuong, x.tongTien);
            }
        }

        public void LoadCBB()
        {
            foreach (var item in sanPhamService.GetAll())
            {
                cbbSP.Items.Add(item.TenSach);
                
            }
            foreach (var item in khachHangService.GetAll())
            {
                tbxTenKH.Items.Add(item.Ten);
            }
        }
    }
}
