namespace _3.GUI.View
{
    partial class QLNhanVien
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
            dtgNhanVien = new DataGridView();
            txtSdtNv = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTenNV = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtEmailNV = new TextBox();
            label3 = new Label();
            label6 = new Label();
            txtDiaChiNv = new TextBox();
            rBtnHoatDong = new RadioButton();
            rbtnNgungHD = new RadioButton();
            txtTimNv = new TextBox();
            cbbChucVu = new ComboBox();
            btnSuaNv = new Button();
            btnThemNv = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dtgNhanVien
            // 
            dtgNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgNhanVien.Dock = DockStyle.Bottom;
            dtgNhanVien.Location = new Point(0, 311);
            dtgNhanVien.Name = "dtgNhanVien";
            dtgNhanVien.RowHeadersWidth = 51;
            dtgNhanVien.RowTemplate.Height = 29;
            dtgNhanVien.Size = new Size(1238, 340);
            dtgNhanVien.TabIndex = 63;
            dtgNhanVien.CellClick += dtgNhanVien_CellClick;
            // 
            // txtSdtNv
            // 
            txtSdtNv.Cursor = Cursors.IBeam;
            txtSdtNv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSdtNv.ForeColor = Color.Black;
            txtSdtNv.Location = new Point(267, 94);
            txtSdtNv.Margin = new Padding(5);
            txtSdtNv.Multiline = true;
            txtSdtNv.Name = "txtSdtNv";
            txtSdtNv.Size = new Size(319, 36);
            txtSdtNv.TabIndex = 96;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(121, 102);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 93;
            label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 41);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 92;
            label1.Text = "Tên nhân viên:";
            // 
            // txtTenNV
            // 
            txtTenNV.Cursor = Cursors.IBeam;
            txtTenNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNV.ForeColor = Color.Black;
            txtTenNV.Location = new Point(267, 33);
            txtTenNV.Margin = new Padding(5);
            txtTenNV.Multiline = true;
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(319, 36);
            txtTenNV.TabIndex = 91;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(662, 157);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 103;
            label4.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(121, 158);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 101;
            label5.Text = "Chức vụ:";
            // 
            // txtEmailNV
            // 
            txtEmailNV.Cursor = Cursors.IBeam;
            txtEmailNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailNV.ForeColor = Color.Black;
            txtEmailNV.Location = new Point(772, 33);
            txtEmailNV.Margin = new Padding(5);
            txtEmailNV.Multiline = true;
            txtEmailNV.Name = "txtEmailNV";
            txtEmailNV.Size = new Size(319, 36);
            txtEmailNV.TabIndex = 108;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(699, 41);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 107;
            label3.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(686, 102);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 110;
            label6.Text = "Địa chỉ:";
            // 
            // txtDiaChiNv
            // 
            txtDiaChiNv.Cursor = Cursors.IBeam;
            txtDiaChiNv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChiNv.ForeColor = Color.Black;
            txtDiaChiNv.Location = new Point(772, 94);
            txtDiaChiNv.Margin = new Padding(5);
            txtDiaChiNv.Multiline = true;
            txtDiaChiNv.Name = "txtDiaChiNv";
            txtDiaChiNv.Size = new Size(319, 36);
            txtDiaChiNv.TabIndex = 109;
            // 
            // rBtnHoatDong
            // 
            rBtnHoatDong.BackColor = Color.FromArgb(60, 63, 81);
            rBtnHoatDong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnHoatDong.ForeColor = Color.White;
            rBtnHoatDong.Location = new Point(772, 155);
            rBtnHoatDong.Margin = new Padding(4);
            rBtnHoatDong.Name = "rBtnHoatDong";
            rBtnHoatDong.Size = new Size(137, 32);
            rBtnHoatDong.TabIndex = 117;
            rBtnHoatDong.TabStop = true;
            rBtnHoatDong.Text = "Hoạt động";
            rBtnHoatDong.UseVisualStyleBackColor = false;
            // 
            // rbtnNgungHD
            // 
            rbtnNgungHD.BackColor = Color.FromArgb(60, 63, 81);
            rbtnNgungHD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnNgungHD.ForeColor = Color.White;
            rbtnNgungHD.Location = new Point(917, 156);
            rbtnNgungHD.Margin = new Padding(4);
            rbtnNgungHD.Name = "rbtnNgungHD";
            rbtnNgungHD.Size = new Size(195, 32);
            rbtnNgungHD.TabIndex = 118;
            rbtnNgungHD.TabStop = true;
            rbtnNgungHD.Text = "Ngưng hoạt động";
            rbtnNgungHD.UseVisualStyleBackColor = false;
            // 
            // txtTimNv
            // 
            txtTimNv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTimNv.ForeColor = Color.Black;
            txtTimNv.Location = new Point(721, 250);
            txtTimNv.Margin = new Padding(5);
            txtTimNv.Name = "txtTimNv";
            txtTimNv.PlaceholderText = "Nhập tên hoặc mã nhân viên để tìm kiếm";
            txtTimNv.Size = new Size(434, 34);
            txtTimNv.TabIndex = 121;
            txtTimNv.TextChanged += txtTimNv_TextChanged;
            // 
            // cbbChucVu
            // 
            cbbChucVu.FormattingEnabled = true;
            cbbChucVu.Items.AddRange(new object[] { "Nhân viên", "Quản lý" });
            cbbChucVu.Location = new Point(267, 158);
            cbbChucVu.Name = "cbbChucVu";
            cbbChucVu.Size = new Size(319, 28);
            cbbChucVu.TabIndex = 122;
            // 
            // btnSuaNv
            // 
            btnSuaNv.BackColor = SystemColors.ActiveCaptionText;
            btnSuaNv.Cursor = Cursors.Hand;
            btnSuaNv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuaNv.ForeColor = Color.White;
            btnSuaNv.Location = new Point(269, 240);
            btnSuaNv.Margin = new Padding(4);
            btnSuaNv.Name = "btnSuaNv";
            btnSuaNv.Size = new Size(180, 55);
            btnSuaNv.TabIndex = 124;
            btnSuaNv.Text = "Sửa";
            btnSuaNv.UseVisualStyleBackColor = false;
            btnSuaNv.Click += btnSuaNv_Click;
            // 
            // btnThemNv
            // 
            btnThemNv.BackColor = SystemColors.ActiveCaptionText;
            btnThemNv.Cursor = Cursors.Hand;
            btnThemNv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemNv.ForeColor = Color.White;
            btnThemNv.Location = new Point(31, 240);
            btnThemNv.Margin = new Padding(4);
            btnThemNv.Name = "btnThemNv";
            btnThemNv.Size = new Size(180, 55);
            btnThemNv.TabIndex = 123;
            btnThemNv.Text = "Thêm ";
            btnThemNv.UseVisualStyleBackColor = false;
            btnThemNv.Click += btnThemNv_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(491, 240);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(180, 55);
            button1.TabIndex = 125;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // QLNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(1238, 651);
            Controls.Add(button1);
            Controls.Add(btnSuaNv);
            Controls.Add(btnThemNv);
            Controls.Add(cbbChucVu);
            Controls.Add(txtTimNv);
            Controls.Add(rbtnNgungHD);
            Controls.Add(rBtnHoatDong);
            Controls.Add(label6);
            Controls.Add(txtDiaChiNv);
            Controls.Add(txtEmailNV);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtSdtNv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenNV);
            Controls.Add(dtgNhanVien);
            Name = "QLNhanVien";
            Text = "QLNhanVien";
            ((System.ComponentModel.ISupportInitialize)dtgNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgNhanVien;
        private TextBox txtSdtNv;
        private Label label2;
        private Label label1;
        private TextBox txtTenNV;
        private Label label4;
        private Label label5;
        private TextBox txtEmailNV;
        private Label label3;
        private Label label6;
        private TextBox txtDiaChiNv;
        private RadioButton rBtnHoatDong;
        private RadioButton rbtnNgungHD;
        private TextBox txtTimNv;
        private ComboBox cbbChucVu;
        private Button btnSuaNv;
        private Button btnThemNv;
        private Button button1;
    }
}