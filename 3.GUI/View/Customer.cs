using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using ClosedXML.Excel;
using Du_An_Ban_Sach._1.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Forms;

namespace _3.GUI.View
{
    public partial class Customer : Form
    {
        IKhachHangService iKhachHang;
        List<KhachHangView> lstKH;
        Guid id;

        public Customer()
        {
            InitializeComponent();
            iKhachHang = new KhachHangService();
            lstKH = new List<KhachHangView>();
            LoadData();
            LoadSize();
        }

        private void LoadData()
        {
            dtgCustomer.ColumnCount = 5;
            dtgCustomer.Columns[0].HeaderText = "ID";
            dtgCustomer.Columns[1].HeaderText = "Mã KH";
            dtgCustomer.Columns[2].HeaderText = "Họ Tên";
            dtgCustomer.Columns[3].HeaderText = "SDT";
            dtgCustomer.Columns[4].HeaderText = "Địa chỉ";
            dtgCustomer.Columns[0].Visible = false;
            dtgCustomer.Rows.Clear();

            foreach (var item in iKhachHang.GetAll())
            {
                dtgCustomer.Rows.Add(item.IdKhachHang, item.MaKh, item.Ten, item.sdt, item.DiaChi);
            }
        }
        public void LoadSize()
        {


            dtgCustomer.Columns[1].Width = 301;
            dtgCustomer.Columns[2].Width = 308;
            dtgCustomer.Columns[3].Width = 308;
            dtgCustomer.Columns[4].Width = 308;
        }
        string Ma()
        {
            string ma = "KH";
            Random rand = new Random();
            int a = rand.Next(1000, 9999);
            var so = a.ToString();
            return ma + so;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResul = MessageBox.Show("Bạn có muốn thêm?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResul == DialogResult.Yes)
            {
                var kh = new KhachHangView()
                {
                    IdKhachHang = Guid.NewGuid(),
                    MaKh = Ma(),
                    Ten = tbxTenKH.Text,
                    sdt = tbxSDT.Text,
                    DiaChi = tbxDC.Text,

                };
                iKhachHang.Add(kh);
                MessageBox.Show("Thêm thành công");
                LoadData();
                Clear();

            }
            if (dialogResul == DialogResult.No)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResul = MessageBox.Show("Bạn có muốn sửa?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResul == DialogResult.Yes)
            {
                var x = iKhachHang.GetAll().FirstOrDefault(p => p.IdKhachHang.Equals(id));
                x.MaKh = tbxMaKH.Text;
                x.Ten = tbxTenKH.Text;
                x.sdt = tbxSDT.Text;
                x.DiaChi = tbxDC.Text;
                iKhachHang.Update(x);
                MessageBox.Show("Sửa thành công");
                LoadData();
                Clear();
            }
            if (dialogResul == DialogResult.No)
            {
                MessageBox.Show("Sửa không thành công");
            }
        }



        private void txbTimKH_TextChanged(object sender, EventArgs e)
        {
            dtgCustomer.ColumnCount = 5;
            dtgCustomer.Columns[0].HeaderText = "ID";
            dtgCustomer.Columns[1].HeaderText = "Mã KH";
            dtgCustomer.Columns[2].HeaderText = "Họ Tên";
            dtgCustomer.Columns[3].HeaderText = "SDT";
            dtgCustomer.Columns[4].HeaderText = "Địa chỉ";
            dtgCustomer.Columns[0].Visible = false;
            dtgCustomer.Rows.Clear();
            foreach (var x in iKhachHang.GetAll().Where(c => c.Ten.ToLower().Contains(txbTimKH.Text)))
            {
                dtgCustomer.Rows.Add(x.IdKhachHang, x.MaKh, x.Ten, x.sdt, x.DiaChi);
            }

        }

        public void Clear()
        {
            tbxMaKH.Text = "";
            tbxTenKH.Text = "";
            tbxSDT.Text = "";
            tbxDC.Text = "";
        }

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd >= iKhachHang.GetAll().Count) return;
            id = Guid.Parse(dtgCustomer.CurrentRow.Cells[0].Value.ToString());
            var kh = iKhachHang.GetAll().FirstOrDefault(c => c.IdKhachHang.Equals(id));
            tbxMaKH.Text = kh.MaKh;
            tbxTenKH.Text = kh.Ten;
            tbxSDT.Text = kh.sdt;
            tbxDC.Text = kh.DiaChi;

        }
        private void ExportToExcelFromDataGridView(DataGridView dgv, string filePath)
        {
            var workbook = new XLWorkbook(filePath);
            var worksheet = workbook.Worksheets.Add("Khách Hàng");

            // Ghi tiêu đề cột
            int col = 1;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                worksheet.Cell(1, col).Value = column.HeaderText;
                col++;
            }

            // Ghi dữ liệu từ DataGridView
            int row = 2;
            foreach (DataGridViewRow dgvRow in dgv.Rows)
            {
                col = 1;
                foreach (DataGridViewCell cell in dgvRow.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (cell.Value is Guid guidValue)
                        {
                            // Chuyển đổi giá trị Guid thành chuỗi trước khi ghi vào Excel
                            worksheet.Cell(row, col).Value = guidValue.ToString();
                        }
                        else
                        {
                            // Ghi các kiểu dữ liệu khác
                            worksheet.Cell(row, col).Value = (XLCellValue)cell.Value;
                        }
                    }
                    col++;
                }
                row++;
            }

            workbook.Save();
        }

        private void btnExl_Click(object sender, EventArgs e)
        {
            //var workbook = new XLWorkbook();
            //var worksheet = workbook.Worksheets.Add("Sheet1");
            //for (int i = 0; i < dtgCustomer.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dtgCustomer.Columns.Count; j++)
            //    {
            //        worksheet.Cell(i + 2, j + 1).Value = dtgCustomer[i, j].Value.ToString();
            //    }
            //}
            //var savedialog=new SaveFileDialog();
            //savedialog.Filter = "Danh Sách Khách Hàng|*.xlsx";
            //if (savedialog.ShowDialog()==DialogResult.OK)
            //{
            //    workbook.SaveAs(savedialog.FileName);
            //}
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToExcelFromDataGridView(dtgCustomer, filePath);
                MessageBox.Show("Dữ liệu đã được xuất ra Excel.");
            }
        }
    }
}
