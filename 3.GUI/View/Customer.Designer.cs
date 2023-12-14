namespace _3.GUI.View
{
    partial class Customer
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
            label1 = new Label();
            lable2 = new Label();
            label3 = new Label();
            tbxDiaChi = new Label();
            tbxMaKH = new TextBox();
            tbxTenKH = new TextBox();
            tbxSDT = new TextBox();
            tbxDC = new TextBox();
            btnAdd = new Button();
            dtgCustomer = new DataGridView();
            btnEdit = new Button();
            btnExl = new Button();
            txbTimKH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 38);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã Khách hàng";
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lable2.ForeColor = Color.White;
            lable2.Location = new Point(631, 35);
            lable2.Name = "lable2";
            lable2.Size = new Size(49, 28);
            lable2.TabIndex = 1;
            lable2.Text = "SDT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(129, 112);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 2;
            label3.Text = "Họ Tên";
            // 
            // tbxDiaChi
            // 
            tbxDiaChi.AutoSize = true;
            tbxDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxDiaChi.ForeColor = Color.White;
            tbxDiaChi.Location = new Point(631, 112);
            tbxDiaChi.Name = "tbxDiaChi";
            tbxDiaChi.Size = new Size(78, 28);
            tbxDiaChi.TabIndex = 3;
            tbxDiaChi.Text = "Địa chỉ";
            // 
            // tbxMaKH
            // 
            tbxMaKH.Cursor = Cursors.IBeam;
            tbxMaKH.Enabled = false;
            tbxMaKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMaKH.ForeColor = Color.Black;
            tbxMaKH.Location = new Point(223, 32);
            tbxMaKH.Margin = new Padding(5);
            tbxMaKH.Name = "tbxMaKH";
            tbxMaKH.Size = new Size(336, 34);
            tbxMaKH.TabIndex = 0;
            // 
            // tbxTenKH
            // 
            tbxTenKH.Cursor = Cursors.IBeam;
            tbxTenKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTenKH.ForeColor = Color.Black;
            tbxTenKH.Location = new Point(223, 106);
            tbxTenKH.Margin = new Padding(5);
            tbxTenKH.Name = "tbxTenKH";
            tbxTenKH.Size = new Size(336, 34);
            tbxTenKH.TabIndex = 0;
            // 
            // tbxSDT
            // 
            tbxSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxSDT.ForeColor = Color.Black;
            tbxSDT.Location = new Point(741, 32);
            tbxSDT.Margin = new Padding(5);
            tbxSDT.Name = "tbxSDT";
            tbxSDT.Size = new Size(336, 34);
            tbxSDT.TabIndex = 1;
            tbxSDT.KeyPress += tbxSDT_KeyPress;
            // 
            // tbxDC
            // 
            tbxDC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxDC.ForeColor = Color.Black;
            tbxDC.Location = new Point(741, 106);
            tbxDC.Margin = new Padding(5);
            tbxDC.Name = "tbxDC";
            tbxDC.Size = new Size(336, 34);
            tbxDC.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaptionText;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(81, 228);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 55);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtgCustomer
            // 
            dtgCustomer.BackgroundColor = Color.White;
            dtgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCustomer.Dock = DockStyle.Bottom;
            dtgCustomer.Location = new Point(0, 290);
            dtgCustomer.Name = "dtgCustomer";
            dtgCustomer.RowHeadersWidth = 51;
            dtgCustomer.RowTemplate.Height = 29;
            dtgCustomer.Size = new Size(1238, 361);
            dtgCustomer.TabIndex = 12;
            dtgCustomer.CellClick += dtgCustomer_CellClick;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaptionText;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(319, 228);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 55);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnExl
            // 
            btnExl.BackColor = SystemColors.ActiveCaptionText;
            btnExl.Cursor = Cursors.Hand;
            btnExl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExl.ForeColor = Color.White;
            btnExl.Location = new Point(584, 228);
            btnExl.Margin = new Padding(4);
            btnExl.Name = "btnExl";
            btnExl.Size = new Size(180, 55);
            btnExl.TabIndex = 14;
            btnExl.Text = "Xuất Excel";
            btnExl.UseVisualStyleBackColor = false;
            btnExl.Click += btnExl_Click;
            // 
            // txbTimKH
            // 
            txbTimKH.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txbTimKH.ForeColor = Color.Black;
            txbTimKH.Location = new Point(810, 239);
            txbTimKH.Margin = new Padding(5);
            txbTimKH.Name = "txbTimKH";
            txbTimKH.PlaceholderText = " Nhập tên KH để tìm kiếm";
            txbTimKH.Size = new Size(336, 34);
            txbTimKH.TabIndex = 15;
            txbTimKH.TextChanged += txbTimKH_TextChanged;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(1238, 651);
            Controls.Add(txbTimKH);
            Controls.Add(btnExl);
            Controls.Add(btnEdit);
            Controls.Add(dtgCustomer);
            Controls.Add(btnAdd);
            Controls.Add(tbxDC);
            Controls.Add(tbxSDT);
            Controls.Add(tbxTenKH);
            Controls.Add(tbxMaKH);
            Controls.Add(tbxDiaChi);
            Controls.Add(label3);
            Controls.Add(lable2);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            Click += Customer_Click;
            ((System.ComponentModel.ISupportInitialize)dtgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lable2;
        private Label label3;
        private Label tbxDiaChi;
        private TextBox tbxMaKH;
        private TextBox tbxTenKH;
        private TextBox tbxSDT;
        private TextBox tbxDC;
        private Button btnAdd;
        private DataGridView dtgCustomer;
        private Button btnEdit;
        private Button btnExl;
        private TextBox txbTimKH;
    }
}