namespace _3.GUI.View
{
    partial class Bill
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
            btnBill = new Button();
            dtgBill = new DataGridView();
            tbxTenNV = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            lblDoanhThu = new Label();
            lblHoaDon = new Label();
            lblHoaDonChuaDon = new Label();
            lblSPDaBan = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgBill).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnBill
            // 
            btnBill.Location = new Point(938, 32);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(190, 40);
            btnBill.TabIndex = 0;
            btnBill.Text = "Tạo hóa đơn";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // dtgBill
            // 
            dtgBill.BackgroundColor = Color.White;
            dtgBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBill.Dock = DockStyle.Bottom;
            dtgBill.Location = new Point(0, 317);
            dtgBill.Name = "dtgBill";
            dtgBill.RowHeadersWidth = 51;
            dtgBill.RowTemplate.Height = 29;
            dtgBill.Size = new Size(1238, 334);
            dtgBill.TabIndex = 1;
            // 
            // tbxTenNV
            // 
            tbxTenNV.Cursor = Cursors.IBeam;
            tbxTenNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTenNV.ForeColor = Color.Black;
            tbxTenNV.Location = new Point(212, 36);
            tbxTenNV.Margin = new Padding(5);
            tbxTenNV.Multiline = true;
            tbxTenNV.Name = "tbxTenNV";
            tbxTenNV.Size = new Size(633, 36);
            tbxTenNV.TabIndex = 68;
            tbxTenNV.Text = "Nhập Mã Hóa Đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDoanhThu);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(32, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 69;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doanh Thu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblHoaDon);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(337, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 70;
            groupBox2.TabStop = false;
            groupBox2.Text = "Số Hóa Đơn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblHoaDonChuaDon);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(646, 147);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 70;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa Đơn Chưa Thanh Toán";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblSPDaBan);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.Control;
            groupBox4.Location = new Point(956, 147);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 125);
            groupBox4.TabIndex = 70;
            groupBox4.TabStop = false;
            groupBox4.Text = "Số Sản Phẩm Đã Bán";
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoanhThu.Location = new Point(105, 52);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(35, 38);
            lblDoanhThu.TabIndex = 0;
            lblDoanhThu.Text = "A";
            // 
            // lblHoaDon
            // 
            lblHoaDon.AutoSize = true;
            lblHoaDon.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoaDon.Location = new Point(112, 52);
            lblHoaDon.Name = "lblHoaDon";
            lblHoaDon.Size = new Size(33, 38);
            lblHoaDon.TabIndex = 1;
            lblHoaDon.Text = "B";
            // 
            // lblHoaDonChuaDon
            // 
            lblHoaDonChuaDon.AutoSize = true;
            lblHoaDonChuaDon.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoaDonChuaDon.Location = new Point(104, 52);
            lblHoaDonChuaDon.Name = "lblHoaDonChuaDon";
            lblHoaDonChuaDon.Size = new Size(34, 38);
            lblHoaDonChuaDon.TabIndex = 2;
            lblHoaDonChuaDon.Text = "C";
            lblHoaDonChuaDon.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSPDaBan
            // 
            lblSPDaBan.AutoSize = true;
            lblSPDaBan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSPDaBan.Location = new Point(113, 52);
            lblSPDaBan.Name = "lblSPDaBan";
            lblSPDaBan.Size = new Size(37, 38);
            lblSPDaBan.TabIndex = 3;
            lblSPDaBan.Text = "D";
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(1238, 651);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tbxTenNV);
            Controls.Add(dtgBill);
            Controls.Add(btnBill);
            Name = "Bill";
            Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)dtgBill).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBill;
        private DataGridView dtgBill;
        private TextBox tbxTenNV;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lblDoanhThu;
        private Label lblHoaDon;
        private Label lblHoaDonChuaDon;
        private Label lblSPDaBan;
    }
}