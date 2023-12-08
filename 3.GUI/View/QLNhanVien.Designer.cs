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
            txtSDT = new TextBox();
            lbTenKH = new Label();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbxTenNV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dtgNhanVien
            // 
            dtgNhanVien.BackgroundColor = Color.White;
            dtgNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgNhanVien.Dock = DockStyle.Bottom;
            dtgNhanVien.Location = new Point(0, 311);
            dtgNhanVien.Name = "dtgNhanVien";
            dtgNhanVien.RowHeadersWidth = 51;
            dtgNhanVien.RowTemplate.Height = 29;
            dtgNhanVien.Size = new Size(1238, 340);
            dtgNhanVien.TabIndex = 63;
            // 
            // txtSDT
            // 
            txtSDT.Cursor = Cursors.IBeam;
            txtSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.ForeColor = Color.Black;
            txtSDT.Location = new Point(12, 116);
            txtSDT.Margin = new Padding(5);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(319, 36);
            txtSDT.TabIndex = 96;
            // 
            // lbTenKH
            // 
            lbTenKH.AutoSize = true;
            lbTenKH.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTenKH.ForeColor = Color.White;
            lbTenKH.Location = new Point(179, 157);
            lbTenKH.Name = "lbTenKH";
            lbTenKH.Size = new Size(27, 28);
            lbTenKH.TabIndex = 95;
            lbTenKH.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(9, 157);
            label8.Name = "label8";
            label8.Size = new Size(167, 28);
            label8.TabIndex = 94;
            label8.Text = "Tên khách hàng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 82);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 93;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 92;
            label1.Text = "Tên nhân viên";
            // 
            // tbxTenNV
            // 
            tbxTenNV.Cursor = Cursors.IBeam;
            tbxTenNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTenNV.ForeColor = Color.Black;
            tbxTenNV.Location = new Point(12, 41);
            tbxTenNV.Margin = new Padding(5);
            tbxTenNV.Multiline = true;
            tbxTenNV.Name = "tbxTenNV";
            tbxTenNV.Size = new Size(319, 36);
            tbxTenNV.TabIndex = 91;
            // 
            // QLNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(1238, 651);
            Controls.Add(txtSDT);
            Controls.Add(lbTenKH);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxTenNV);
            Controls.Add(dtgNhanVien);
            Name = "QLNhanVien";
            Text = "QLNhanVien";
            ((System.ComponentModel.ISupportInitialize)dtgNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgNhanVien;
        private TextBox txtSDT;
        private Label lbTenKH;
        private Label label8;
        private Label label2;
        private Label label1;
        private TextBox tbxTenNV;
    }
}