namespace _3.GUI.View
{
    partial class BookStore
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
            anhsp = new DataGridViewImageColumn();
            tbxGiaNhap = new TextBox();
            tbxSoLuong = new TextBox();
            tbxTenSach = new TextBox();
            tbxDiaChi = new Label();
            label3 = new Label();
            tbxSdtKH = new Label();
            tbxGiaBan = new TextBox();
            label2 = new Label();
            pcb_IMG = new PictureBox();
            btnUpImg = new Button();
            label4 = new Label();
            cbbTacGia = new ComboBox();
            label5 = new Label();
            cbbTL = new ComboBox();
            cbbNCC = new ComboBox();
            label6 = new Label();
            cbbNXB = new ComboBox();
            label7 = new Label();
            cbbBia = new ComboBox();
            label8 = new Label();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            txbTimSach = new TextBox();
            tbxMoTa = new TextBox();
            label9 = new Label();
            rBtnConHang = new RadioButton();
            rBtnHetHang = new RadioButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcb_IMG).BeginInit();
            SuspendLayout();
            // 
            // dtgProduct
            // 
            dtgProduct.BackgroundColor = Color.White;
            dtgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProduct.Columns.AddRange(new DataGridViewColumn[] { anhsp });
            dtgProduct.Dock = DockStyle.Bottom;
            dtgProduct.Location = new Point(0, 375);
            dtgProduct.Name = "dtgProduct";
            dtgProduct.RowHeadersWidth = 51;
            dtgProduct.RowTemplate.Height = 29;
            dtgProduct.Size = new Size(1238, 276);
            dtgProduct.TabIndex = 61;
            dtgProduct.CellClick += dtgProduct_CellClick;
            // 
            // anhsp
            // 
            anhsp.HeaderText = "Ảnh";
            anhsp.MinimumWidth = 6;
            anhsp.Name = "anhsp";
            anhsp.Width = 125;
            // 
            // tbxGiaNhap
            // 
            tbxGiaNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxGiaNhap.ForeColor = Color.Black;
            tbxGiaNhap.Location = new Point(20, 143);
            tbxGiaNhap.Margin = new Padding(5);
            tbxGiaNhap.Name = "tbxGiaNhap";
            tbxGiaNhap.Size = new Size(154, 34);
            tbxGiaNhap.TabIndex = 67;
            // 
            // tbxSoLuong
            // 
            tbxSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxSoLuong.ForeColor = Color.Black;
            tbxSoLuong.Location = new Point(380, 51);
            tbxSoLuong.Margin = new Padding(5);
            tbxSoLuong.Name = "tbxSoLuong";
            tbxSoLuong.Size = new Size(138, 34);
            tbxSoLuong.TabIndex = 65;
            // 
            // tbxTenSach
            // 
            tbxTenSach.Cursor = Cursors.IBeam;
            tbxTenSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTenSach.ForeColor = Color.Black;
            tbxTenSach.Location = new Point(20, 51);
            tbxTenSach.Margin = new Padding(5);
            tbxTenSach.Name = "tbxTenSach";
            tbxTenSach.Size = new Size(336, 34);
            tbxTenSach.TabIndex = 62;
            // 
            // tbxDiaChi
            // 
            tbxDiaChi.AutoSize = true;
            tbxDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxDiaChi.ForeColor = Color.White;
            tbxDiaChi.Location = new Point(20, 110);
            tbxDiaChi.Name = "tbxDiaChi";
            tbxDiaChi.Size = new Size(96, 28);
            tbxDiaChi.TabIndex = 69;
            tbxDiaChi.Text = "Giá nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 18);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 68;
            label3.Text = "Tên Sách";
            // 
            // tbxSdtKH
            // 
            tbxSdtKH.AutoSize = true;
            tbxSdtKH.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxSdtKH.ForeColor = Color.White;
            tbxSdtKH.Location = new Point(380, 18);
            tbxSdtKH.Name = "tbxSdtKH";
            tbxSdtKH.Size = new Size(97, 28);
            tbxSdtKH.TabIndex = 66;
            tbxSdtKH.Text = "Số lượng";
            // 
            // tbxGiaBan
            // 
            tbxGiaBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxGiaBan.ForeColor = Color.Black;
            tbxGiaBan.Location = new Point(202, 143);
            tbxGiaBan.Margin = new Padding(5);
            tbxGiaBan.Name = "tbxGiaBan";
            tbxGiaBan.Size = new Size(154, 34);
            tbxGiaBan.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(202, 110);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 71;
            label2.Text = "Giá bán";
            // 
            // pcb_IMG
            // 
            pcb_IMG.BackColor = Color.White;
            pcb_IMG.BorderStyle = BorderStyle.FixedSingle;
            pcb_IMG.Location = new Point(827, 27);
            pcb_IMG.Name = "pcb_IMG";
            pcb_IMG.Size = new Size(180, 167);
            pcb_IMG.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb_IMG.TabIndex = 72;
            pcb_IMG.TabStop = false;
            // 
            // btnUpImg
            // 
            btnUpImg.Location = new Point(868, 220);
            btnUpImg.Name = "btnUpImg";
            btnUpImg.Size = new Size(108, 44);
            btnUpImg.TabIndex = 73;
            btnUpImg.Text = "Chọn ảnh";
            btnUpImg.UseVisualStyleBackColor = true;
            btnUpImg.Click += btnUpImg_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(564, 18);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 75;
            label4.Text = "Tác giả";
            // 
            // cbbTacGia
            // 
            cbbTacGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTacGia.FormattingEnabled = true;
            cbbTacGia.Location = new Point(564, 53);
            cbbTacGia.MaxDropDownItems = 20;
            cbbTacGia.Name = "cbbTacGia";
            cbbTacGia.Size = new Size(229, 28);
            cbbTacGia.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(296, 213);
            label5.Name = "label5";
            label5.Size = new Size(92, 28);
            label5.TabIndex = 77;
            label5.Text = "Thể Loại";
            // 
            // cbbTL
            // 
            cbbTL.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTL.FormattingEnabled = true;
            cbbTL.Location = new Point(296, 244);
            cbbTL.Name = "cbbTL";
            cbbTL.Size = new Size(229, 28);
            cbbTL.TabIndex = 78;
            // 
            // cbbNCC
            // 
            cbbNCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNCC.FormattingEnabled = true;
            cbbNCC.Location = new Point(564, 150);
            cbbNCC.Name = "cbbNCC";
            cbbNCC.Size = new Size(229, 28);
            cbbNCC.TabIndex = 82;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(564, 119);
            label6.Name = "label6";
            label6.Size = new Size(142, 28);
            label6.TabIndex = 81;
            label6.Text = "Nhà cung cấp";
            // 
            // cbbNXB
            // 
            cbbNXB.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNXB.FormattingEnabled = true;
            cbbNXB.Location = new Point(20, 244);
            cbbNXB.Name = "cbbNXB";
            cbbNXB.Size = new Size(229, 28);
            cbbNXB.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 209);
            label7.Name = "label7";
            label7.Size = new Size(140, 28);
            label7.TabIndex = 79;
            label7.Text = "Nhà xuất bản";
            // 
            // cbbBia
            // 
            cbbBia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbBia.FormattingEnabled = true;
            cbbBia.Location = new Point(380, 150);
            cbbBia.Name = "cbbBia";
            cbbBia.Size = new Size(138, 28);
            cbbBia.TabIndex = 84;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(380, 115);
            label8.Name = "label8";
            label8.Size = new Size(86, 28);
            label8.TabIndex = 83;
            label8.Text = "Loại bìa";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaptionText;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1045, 122);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 55);
            btnEdit.TabIndex = 86;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaptionText;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1045, 41);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 55);
            btnAdd.TabIndex = 85;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaptionText;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1045, 207);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 55);
            btnDelete.TabIndex = 87;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txbTimSach
            // 
            txbTimSach.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbTimSach.ForeColor = Color.Black;
            txbTimSach.Location = new Point(726, 323);
            txbTimSach.Margin = new Padding(5);
            txbTimSach.Name = "txbTimSach";
            txbTimSach.PlaceholderText = "Nhập tên sách để tìm kiếm";
            txbTimSach.Size = new Size(434, 34);
            txbTimSach.TabIndex = 88;
            // 
            // tbxMoTa
            // 
            tbxMoTa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMoTa.ForeColor = Color.Black;
            tbxMoTa.Location = new Point(20, 323);
            tbxMoTa.Margin = new Padding(5);
            tbxMoTa.Name = "tbxMoTa";
            tbxMoTa.Size = new Size(466, 34);
            tbxMoTa.TabIndex = 89;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(20, 290);
            label9.Name = "label9";
            label9.Size = new Size(68, 28);
            label9.TabIndex = 90;
            label9.Text = "Mô tả";
            // 
            // rBtnConHang
            // 
            rBtnConHang.BackColor = Color.FromArgb(60, 63, 81);
            rBtnConHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnConHang.ForeColor = Color.White;
            rBtnConHang.Location = new Point(549, 240);
            rBtnConHang.Margin = new Padding(4);
            rBtnConHang.Name = "rBtnConHang";
            rBtnConHang.Size = new Size(126, 32);
            rBtnConHang.TabIndex = 93;
            rBtnConHang.TabStop = true;
            rBtnConHang.Text = "Còn Hàng";
            rBtnConHang.UseVisualStyleBackColor = false;
            // 
            // rBtnHetHang
            // 
            rBtnHetHang.BackColor = Color.FromArgb(60, 63, 81);
            rBtnHetHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnHetHang.ForeColor = Color.White;
            rBtnHetHang.Location = new Point(703, 240);
            rBtnHetHang.Margin = new Padding(4);
            rBtnHetHang.Name = "rBtnHetHang";
            rBtnHetHang.Size = new Size(116, 32);
            rBtnHetHang.TabIndex = 94;
            rBtnHetHang.TabStop = true;
            rBtnHetHang.Text = "Hết Hàng";
            rBtnHetHang.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 16);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 95;
            // 
            // BookStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(1238, 651);
            Controls.Add(label1);
            Controls.Add(rBtnHetHang);
            Controls.Add(rBtnConHang);
            Controls.Add(tbxMoTa);
            Controls.Add(label9);
            Controls.Add(txbTimSach);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cbbBia);
            Controls.Add(label8);
            Controls.Add(cbbNCC);
            Controls.Add(label6);
            Controls.Add(cbbNXB);
            Controls.Add(label7);
            Controls.Add(cbbTL);
            Controls.Add(label5);
            Controls.Add(cbbTacGia);
            Controls.Add(label4);
            Controls.Add(btnUpImg);
            Controls.Add(pcb_IMG);
            Controls.Add(tbxGiaBan);
            Controls.Add(label2);
            Controls.Add(tbxGiaNhap);
            Controls.Add(tbxSoLuong);
            Controls.Add(tbxTenSach);
            Controls.Add(tbxDiaChi);
            Controls.Add(label3);
            Controls.Add(tbxSdtKH);
            Controls.Add(dtgProduct);
            Name = "BookStore";
            Text = "BookStore";
            ((System.ComponentModel.ISupportInitialize)dtgProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcb_IMG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgProduct;
        private TextBox tbxGiaNhap;
        private TextBox tbxSoLuong;
        private TextBox tbxTenSach;
        private Label tbxDiaChi;
        private Label label3;
        private Label tbxSdtKH;
        private TextBox tbxGiaBan;
        private Label label2;
        private PictureBox pcb_IMG;
        private Button btnUpImg;
        private Label label4;
        private ComboBox cbbTacGia;
        private Label label5;
        private ComboBox cbbTL;
        private ComboBox cbbNCC;
        private Label label6;
        private ComboBox cbbNXB;
        private Label label7;
        private ComboBox cbbBia;
        private Label label8;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txbTimSach;
        private TextBox tbxMoTa;
        private Label label9;
        private RadioButton rBtnConHang;
        private RadioButton rBtnHetHang;
        private DataGridViewImageColumn anh;
        private DataGridViewImageColumn anhsp;
        private Label label1;
    }
}