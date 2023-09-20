﻿namespace _3.GUI
{
    partial class BillInFor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgProduct = new DataGridView();
            tbxTenNV = new TextBox();
            tbxTenKH = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbbSP = new ComboBox();
            label4 = new Label();
            tbxGia = new TextBox();
            label5 = new Label();
            tbxSoLuong = new TextBox();
            label6 = new Label();
            dtpDay = new DateTimePicker();
            label7 = new Label();
            tbxTien = new TextBox();
            btnThanhToan = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoadForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgProduct).BeginInit();
            SuspendLayout();
            // 
            // dtgProduct
            // 
            dtgProduct.BackgroundColor = Color.White;
            dtgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProduct.Dock = DockStyle.Bottom;
            dtgProduct.Location = new Point(0, 311);
            dtgProduct.Name = "dtgProduct";
            dtgProduct.RowHeadersWidth = 51;
            dtgProduct.RowTemplate.Height = 29;
            dtgProduct.Size = new Size(1238, 340);
            dtgProduct.TabIndex = 62;
            // 
            // tbxTenNV
            // 
            tbxTenNV.Cursor = Cursors.IBeam;
            tbxTenNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTenNV.ForeColor = Color.Black;
            tbxTenNV.Location = new Point(14, 41);
            tbxTenNV.Margin = new Padding(5);
            tbxTenNV.Multiline = true;
            tbxTenNV.Name = "tbxTenNV";
            tbxTenNV.Size = new Size(319, 36);
            tbxTenNV.TabIndex = 67;
            // 
            // tbxTenKH
            // 
            tbxTenKH.FormattingEnabled = true;
            tbxTenKH.Location = new Point(14, 131);
            tbxTenKH.Name = "tbxTenKH";
            tbxTenKH.RightToLeft = RightToLeft.No;
            tbxTenKH.Size = new Size(319, 28);
            tbxTenKH.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 68;
            label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 100);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 69;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(473, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 71;
            label3.Text = "Sản phẩm";
            // 
            // cbbSP
            // 
            cbbSP.FormattingEnabled = true;
            cbbSP.Location = new Point(473, 48);
            cbbSP.Name = "cbbSP";
            cbbSP.RightToLeft = RightToLeft.No;
            cbbSP.Size = new Size(420, 28);
            cbbSP.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(473, 100);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 73;
            label4.Text = "Đơn giá";
            // 
            // tbxGia
            // 
            tbxGia.Cursor = Cursors.IBeam;
            tbxGia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxGia.ForeColor = Color.Black;
            tbxGia.Location = new Point(473, 132);
            tbxGia.Margin = new Padding(5);
            tbxGia.Multiline = true;
            tbxGia.Name = "tbxGia";
            tbxGia.Size = new Size(189, 36);
            tbxGia.TabIndex = 72;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(702, 100);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 75;
            label5.Text = "Số lượng";
            // 
            // tbxSoLuong
            // 
            tbxSoLuong.Cursor = Cursors.IBeam;
            tbxSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxSoLuong.ForeColor = Color.Black;
            tbxSoLuong.Location = new Point(702, 132);
            tbxSoLuong.Margin = new Padding(5);
            tbxSoLuong.Multiline = true;
            tbxSoLuong.Name = "tbxSoLuong";
            tbxSoLuong.Size = new Size(191, 36);
            tbxSoLuong.TabIndex = 74;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 194);
            label6.Name = "label6";
            label6.Size = new Size(193, 28);
            label6.TabIndex = 77;
            label6.Text = "Ngày : Tháng : Năm";
            // 
            // dtpDay
            // 
            dtpDay.Location = new Point(14, 239);
            dtpDay.Name = "dtpDay";
            dtpDay.Size = new Size(320, 27);
            dtpDay.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(473, 198);
            label7.Name = "label7";
            label7.Size = new Size(110, 28);
            label7.TabIndex = 80;
            label7.Text = "Thành tiền";
            // 
            // tbxTien
            // 
            tbxTien.Cursor = Cursors.IBeam;
            tbxTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTien.ForeColor = Color.Black;
            tbxTien.Location = new Point(473, 230);
            tbxTien.Margin = new Padding(5);
            tbxTien.Multiline = true;
            tbxTien.Name = "tbxTien";
            tbxTien.Size = new Size(189, 36);
            tbxTien.TabIndex = 79;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.Location = new Point(702, 224);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(191, 46);
            btnThanhToan.TabIndex = 81;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(1006, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 40);
            btnAdd.TabIndex = 82;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(1006, 88);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 40);
            btnUpdate.TabIndex = 83;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(1006, 162);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 40);
            btnDelete.TabIndex = 84;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLoadForm
            // 
            btnLoadForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadForm.Location = new Point(1006, 239);
            btnLoadForm.Name = "btnLoadForm";
            btnLoadForm.Size = new Size(151, 40);
            btnLoadForm.TabIndex = 85;
            btnLoadForm.Text = "Làm Mới";
            btnLoadForm.UseVisualStyleBackColor = true;
            // 
            // BillInFor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(1238, 651);
            Controls.Add(btnLoadForm);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnThanhToan);
            Controls.Add(label7);
            Controls.Add(tbxTien);
            Controls.Add(dtpDay);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbxSoLuong);
            Controls.Add(label4);
            Controls.Add(tbxGia);
            Controls.Add(label3);
            Controls.Add(cbbSP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxTenNV);
            Controls.Add(tbxTenKH);
            Controls.Add(dtgProduct);
            Name = "BillInFor";
            Text = "BillInFor";
            ((System.ComponentModel.ISupportInitialize)dtgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgProduct;
        private TextBox tbxTenNV;
        private ComboBox tbxTenKH;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbSP;
        private Label label4;
        private TextBox tbxGia;
        private Label label5;
        private TextBox tbxSoLuong;
        private Label label6;
        private DateTimePicker dtpDay;
        private Label label7;
        private TextBox tbxTien;
        private Button btnThanhToan;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoadForm;
    }
}