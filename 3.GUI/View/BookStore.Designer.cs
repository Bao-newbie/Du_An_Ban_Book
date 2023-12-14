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
            cbbTacGia = new ComboBox();
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
            dtgProduct.Location = new Point(0, 281);
            dtgProduct.Margin = new Padding(3, 2, 3, 2);
            dtgProduct.Name = "dtgProduct";
            dtgProduct.RowHeadersWidth = 51;
            dtgProduct.RowTemplate.Height = 29;
            dtgProduct.Size = new Size(1083, 207);
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
            tbxGiaNhap.Location = new Point(18, 107);
            tbxGiaNhap.Margin = new Padding(4);
            tbxGiaNhap.Name = "tbxGiaNhap";
            tbxGiaNhap.Size = new Size(135, 29);
            tbxGiaNhap.TabIndex = 67;
            // 
            // tbxSoLuong
            // 
            tbxSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxSoLuong.ForeColor = Color.Black;
            tbxSoLuong.Location = new Point(332, 38);
            tbxSoLuong.Margin = new Padding(4);
            tbxSoLuong.Name = "tbxSoLuong";
            tbxSoLuong.Size = new Size(121, 29);
            tbxSoLuong.TabIndex = 65;
            // 
            // tbxTenSach
            // 
            tbxTenSach.Cursor = Cursors.IBeam;
            tbxTenSach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTenSach.ForeColor = Color.Black;
            tbxTenSach.Location = new Point(18, 38);
            tbxTenSach.Margin = new Padding(4);
            tbxTenSach.Name = "tbxTenSach";
            tbxTenSach.Size = new Size(294, 29);
            tbxTenSach.TabIndex = 62;
            // 
            // tbxDiaChi
            // 
            tbxDiaChi.AutoSize = true;
            tbxDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxDiaChi.ForeColor = Color.White;
            tbxDiaChi.Location = new Point(18, 82);
            tbxDiaChi.Name = "tbxDiaChi";
            tbxDiaChi.Size = new Size(78, 21);
            tbxDiaChi.TabIndex = 69;
            tbxDiaChi.Text = "Giá nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 14);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 68;
            label3.Text = "Tên Sách";
            // 
            // tbxSdtKH
            // 
            tbxSdtKH.AutoSize = true;
            tbxSdtKH.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxSdtKH.ForeColor = Color.White;
            tbxSdtKH.Location = new Point(332, 14);
            tbxSdtKH.Name = "tbxSdtKH";
            tbxSdtKH.Size = new Size(79, 21);
            tbxSdtKH.TabIndex = 66;
            tbxSdtKH.Text = "Số lượng";
            // 
            // tbxGiaBan
            // 
            tbxGiaBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxGiaBan.ForeColor = Color.Black;
            tbxGiaBan.Location = new Point(177, 107);
            tbxGiaBan.Margin = new Padding(4);
            tbxGiaBan.Name = "tbxGiaBan";
            tbxGiaBan.Size = new Size(135, 29);
            tbxGiaBan.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(177, 82);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 71;
            label2.Text = "Giá bán";
            // 
            // pcb_IMG
            // 
            pcb_IMG.BackColor = Color.White;
            pcb_IMG.BorderStyle = BorderStyle.FixedSingle;
            pcb_IMG.Location = new Point(724, 20);
            pcb_IMG.Margin = new Padding(3, 2, 3, 2);
            pcb_IMG.Name = "pcb_IMG";
            pcb_IMG.Size = new Size(158, 126);
            pcb_IMG.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb_IMG.TabIndex = 72;
            pcb_IMG.TabStop = false;
            // 
            // btnUpImg
            // 
            btnUpImg.Location = new Point(760, 165);
            btnUpImg.Margin = new Padding(3, 2, 3, 2);
            btnUpImg.Name = "btnUpImg";
            btnUpImg.Size = new Size(94, 33);
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
            label4.Location = new Point(494, 14);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 75;
            label4.Text = "Tác giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(259, 160);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 77;
            label5.Text = "Thể Loại";
            // 
            // cbbTL
            // 
            cbbTL.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTL.FormattingEnabled = true;
            cbbTL.Location = new Point(259, 183);
            cbbTL.Margin = new Padding(3, 2, 3, 2);
            cbbTL.Name = "cbbTL";
            cbbTL.Size = new Size(201, 23);
            cbbTL.TabIndex = 78;
            // 
            // cbbNCC
            // 
            cbbNCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNCC.FormattingEnabled = true;
            cbbNCC.Location = new Point(494, 112);
            cbbNCC.Margin = new Padding(3, 2, 3, 2);
            cbbNCC.Name = "cbbNCC";
            cbbNCC.Size = new Size(201, 23);
            cbbNCC.TabIndex = 82;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(494, 89);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 81;
            label6.Text = "Nhà cung cấp";
            // 
            // cbbNXB
            // 
            cbbNXB.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNXB.FormattingEnabled = true;
            cbbNXB.Location = new Point(18, 183);
            cbbNXB.Margin = new Padding(3, 2, 3, 2);
            cbbNXB.Name = "cbbNXB";
            cbbNXB.Size = new Size(201, 23);
            cbbNXB.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(18, 157);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 79;
            label7.Text = "Nhà xuất bản";
            // 
            // cbbBia
            // 
            cbbBia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbBia.FormattingEnabled = true;
            cbbBia.Location = new Point(332, 112);
            cbbBia.Margin = new Padding(3, 2, 3, 2);
            cbbBia.Name = "cbbBia";
            cbbBia.Size = new Size(121, 23);
            cbbBia.TabIndex = 84;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(332, 86);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 83;
            label8.Text = "Loại bìa";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaptionText;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(914, 92);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(158, 41);
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
            btnAdd.Location = new Point(914, 31);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 41);
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
            btnDelete.Location = new Point(914, 155);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 41);
            btnDelete.TabIndex = 87;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txbTimSach
            // 
            txbTimSach.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbTimSach.ForeColor = Color.Black;
            txbTimSach.Location = new Point(635, 242);
            txbTimSach.Margin = new Padding(4);
            txbTimSach.Name = "txbTimSach";
            txbTimSach.PlaceholderText = "Nhập tên sách để tìm kiếm";
            txbTimSach.Size = new Size(380, 29);
            txbTimSach.TabIndex = 88;
            txbTimSach.TextChanged += txbTimSach_TextChanged;
            // 
            // tbxMoTa
            // 
            tbxMoTa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMoTa.ForeColor = Color.Black;
            tbxMoTa.Location = new Point(18, 242);
            tbxMoTa.Margin = new Padding(4);
            tbxMoTa.Name = "tbxMoTa";
            tbxMoTa.Size = new Size(408, 29);
            tbxMoTa.TabIndex = 89;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(18, 218);
            label9.Name = "label9";
            label9.Size = new Size(54, 21);
            label9.TabIndex = 90;
            label9.Text = "Mô tả";
            // 
            // rBtnConHang
            // 
            rBtnConHang.BackColor = Color.FromArgb(60, 63, 81);
            rBtnConHang.Checked = true;
            rBtnConHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnConHang.ForeColor = Color.White;
            rBtnConHang.Location = new Point(480, 180);
            rBtnConHang.Margin = new Padding(4, 3, 4, 3);
            rBtnConHang.Name = "rBtnConHang";
            rBtnConHang.Size = new Size(110, 24);
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
            rBtnHetHang.Location = new Point(615, 180);
            rBtnHetHang.Margin = new Padding(4, 3, 4, 3);
            rBtnHetHang.Name = "rBtnHetHang";
            rBtnHetHang.Size = new Size(102, 24);
            rBtnHetHang.TabIndex = 94;
            rBtnHetHang.Text = "Hết Hàng";
            rBtnHetHang.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 95;
            // 
            // cbbTacGia
            // 
            cbbTacGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTacGia.FormattingEnabled = true;
            cbbTacGia.Location = new Point(494, 40);
            cbbTacGia.Margin = new Padding(3, 2, 3, 2);
            cbbTacGia.MaxDropDownItems = 20;
            cbbTacGia.Name = "cbbTacGia";
            cbbTacGia.Size = new Size(201, 23);
            cbbTacGia.TabIndex = 76;
            // 
            // BookStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(1083, 488);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookStore";
            Text = "BookStore";
            Click += BookStore_Click;
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
        private ComboBox cbbTacGia;
    }
}