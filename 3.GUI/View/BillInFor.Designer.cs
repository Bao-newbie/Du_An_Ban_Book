namespace _3.GUI
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
            label2 = new Label();
            label3 = new Label();
            cbbSP = new ComboBox();
            label4 = new Label();
            tbxGia = new TextBox();
            label5 = new Label();
            tbxSoLuong = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tbxTien = new TextBox();
            btnThanhToan = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoadForm = new Button();
            label8 = new Label();
            lbTenKH = new Label();
            txtSDT = new TextBox();
            tbxTime = new TextBox();
            label9 = new Label();
            btn_TaoHoanDon = new Button();
            label10 = new Label();
            label1 = new Label();
            label11 = new Label();
            lbltonkho = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgProduct).BeginInit();
            SuspendLayout();
            // 
            // dtgProduct
            // 
            dtgProduct.BackgroundColor = Color.White;
            dtgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProduct.Dock = DockStyle.Bottom;
            dtgProduct.Location = new Point(0, 238);
            dtgProduct.Margin = new Padding(3, 2, 3, 2);
            dtgProduct.Name = "dtgProduct";
            dtgProduct.RowHeadersWidth = 51;
            dtgProduct.RowTemplate.Height = 29;
            dtgProduct.Size = new Size(1083, 250);
            dtgProduct.TabIndex = 62;
            dtgProduct.CellClick += dtgProduct_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 34);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 69;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(382, 7);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 71;
            label3.Text = "Tên Sách";
            // 
            // cbbSP
            // 
            cbbSP.FormattingEnabled = true;
            cbbSP.Location = new Point(382, 31);
            cbbSP.Margin = new Padding(3, 2, 3, 2);
            cbbSP.Name = "cbbSP";
            cbbSP.RightToLeft = RightToLeft.No;
            cbbSP.Size = new Size(368, 23);
            cbbSP.TabIndex = 70;
            cbbSP.SelectedIndexChanged += cbbSP_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(382, 70);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 73;
            label4.Text = "Đơn giá";
            // 
            // tbxGia
            // 
            tbxGia.Cursor = Cursors.IBeam;
            tbxGia.Enabled = false;
            tbxGia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxGia.ForeColor = Color.Black;
            tbxGia.Location = new Point(382, 94);
            tbxGia.Margin = new Padding(4);
            tbxGia.Multiline = true;
            tbxGia.Name = "tbxGia";
            tbxGia.Size = new Size(166, 28);
            tbxGia.TabIndex = 72;
            tbxGia.TextChanged += tbxGia_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(583, 70);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 75;
            label5.Text = "Số lượng";
            // 
            // tbxSoLuong
            // 
            tbxSoLuong.Cursor = Cursors.IBeam;
            tbxSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxSoLuong.ForeColor = Color.Black;
            tbxSoLuong.Location = new Point(583, 94);
            tbxSoLuong.Margin = new Padding(4);
            tbxSoLuong.Multiline = true;
            tbxSoLuong.Name = "tbxSoLuong";
            tbxSoLuong.Size = new Size(168, 28);
            tbxSoLuong.TabIndex = 74;
            tbxSoLuong.TextChanged += tbxSoLuong_TextChanged;
            tbxSoLuong.KeyPress += tbxSoLuong_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 118);
            label6.Name = "label6";
            label6.Size = new Size(151, 21);
            label6.TabIndex = 77;
            label6.Text = "Ngày : Tháng : Năm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(382, 144);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 80;
            label7.Text = "Thành tiền";
            // 
            // tbxTien
            // 
            tbxTien.Cursor = Cursors.IBeam;
            tbxTien.Enabled = false;
            tbxTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTien.ForeColor = Color.Black;
            tbxTien.Location = new Point(382, 168);
            tbxTien.Margin = new Padding(4);
            tbxTien.Multiline = true;
            tbxTien.Name = "tbxTien";
            tbxTien.Size = new Size(166, 28);
            tbxTien.TabIndex = 79;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.Location = new Point(583, 164);
            btnThanhToan.Margin = new Padding(3, 2, 3, 2);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(167, 34);
            btnThanhToan.TabIndex = 81;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(880, 9);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 30);
            btnAdd.TabIndex = 82;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(880, 66);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 30);
            btnUpdate.TabIndex = 83;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(880, 122);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 30);
            btnDelete.TabIndex = 84;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadForm
            // 
            btnLoadForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadForm.Location = new Point(880, 179);
            btnLoadForm.Margin = new Padding(3, 2, 3, 2);
            btnLoadForm.Name = "btnLoadForm";
            btnLoadForm.Size = new Size(132, 30);
            btnLoadForm.TabIndex = 85;
            btnLoadForm.Text = "Làm Mới";
            btnLoadForm.UseVisualStyleBackColor = true;
            btnLoadForm.Click += btnLoadForm_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(11, 90);
            label8.Name = "label8";
            label8.Size = new Size(129, 21);
            label8.TabIndex = 87;
            label8.Text = "Tên khách hàng :";
            // 
            // lbTenKH
            // 
            lbTenKH.AutoSize = true;
            lbTenKH.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTenKH.ForeColor = Color.White;
            lbTenKH.Location = new Point(159, 90);
            lbTenKH.Name = "lbTenKH";
            lbTenKH.Size = new Size(22, 21);
            lbTenKH.TabIndex = 89;
            lbTenKH.Text = "...";
            // 
            // txtSDT
            // 
            txtSDT.Cursor = Cursors.IBeam;
            txtSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.ForeColor = Color.Black;
            txtSDT.Location = new Point(13, 59);
            txtSDT.Margin = new Padding(4);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(280, 28);
            txtSDT.TabIndex = 90;
            txtSDT.TextChanged += txtSDT_TextChanged_1;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // tbxTime
            // 
            tbxTime.Cursor = Cursors.IBeam;
            tbxTime.Enabled = false;
            tbxTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTime.ForeColor = Color.Black;
            tbxTime.Location = new Point(13, 143);
            tbxTime.Margin = new Padding(4);
            tbxTime.Multiline = true;
            tbxTime.Name = "tbxTime";
            tbxTime.Size = new Size(280, 28);
            tbxTime.TabIndex = 91;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(228, 7);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 92;
            // 
            // btn_TaoHoanDon
            // 
            btn_TaoHoanDon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TaoHoanDon.ImageAlign = ContentAlignment.TopLeft;
            btn_TaoHoanDon.Location = new Point(61, 189);
            btn_TaoHoanDon.Margin = new Padding(3, 2, 3, 2);
            btn_TaoHoanDon.Name = "btn_TaoHoanDon";
            btn_TaoHoanDon.Size = new Size(167, 34);
            btn_TaoHoanDon.TabIndex = 93;
            btn_TaoHoanDon.Text = "Tạo Hóa Đơn";
            btn_TaoHoanDon.UseVisualStyleBackColor = true;
            btn_TaoHoanDon.Click += btn_TaoHoanDon_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(13, 8);
            label10.Name = "label10";
            label10.Size = new Size(68, 21);
            label10.TabIndex = 95;
            label10.Text = "Mã HD :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 8);
            label1.Name = "label1";
            label1.Size = new Size(22, 21);
            label1.TabIndex = 96;
            label1.Text = "...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(458, 7);
            label11.Name = "label11";
            label11.Size = new Size(87, 21);
            label11.TabIndex = 97;
            label11.Text = "| Tồn Kho :";
            // 
            // lbltonkho
            // 
            lbltonkho.AutoSize = true;
            lbltonkho.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltonkho.ForeColor = Color.White;
            lbltonkho.Location = new Point(562, 9);
            lbltonkho.Name = "lbltonkho";
            lbltonkho.Size = new Size(22, 21);
            lbltonkho.TabIndex = 98;
            lbltonkho.Text = "...";
            // 
            // BillInFor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(1083, 488);
            Controls.Add(lbltonkho);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(btn_TaoHoanDon);
            Controls.Add(label9);
            Controls.Add(tbxTime);
            Controls.Add(txtSDT);
            Controls.Add(lbTenKH);
            Controls.Add(label8);
            Controls.Add(btnLoadForm);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnThanhToan);
            Controls.Add(label7);
            Controls.Add(tbxTien);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbxSoLuong);
            Controls.Add(label4);
            Controls.Add(tbxGia);
            Controls.Add(label3);
            Controls.Add(cbbSP);
            Controls.Add(label2);
            Controls.Add(dtgProduct);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BillInFor";
            Text = "BillInFor";
            ((System.ComponentModel.ISupportInitialize)dtgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgProduct;
        private Label label2;
        private Label label3;
        private ComboBox cbbSP;
        private Label label4;
        private TextBox tbxGia;
        private Label label5;
        private TextBox tbxSoLuong;
        private Label label6;
        private Label label7;
        private TextBox tbxTien;
        private Button btnThanhToan;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoadForm;
        private Label label8;
        private Label lbTenKH;
        private TextBox txtSDT;
        private TextBox tbxTime;
        private Label label9;
        private Button btn_TaoHoanDon;
        private Label label10;
        private Label label1;
        private Label label11;
        private Label lbltonkho;
    }
}