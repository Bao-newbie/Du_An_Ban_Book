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
            button1 = new Button();
            dtgBill = new DataGridView();
            tbxTenNV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgBill).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(938, 32);
            button1.Name = "button1";
            button1.Size = new Size(190, 40);
            button1.TabIndex = 0;
            button1.Text = "Tạo hóa đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtgBill
            // 
            dtgBill.BackgroundColor = Color.White;
            dtgBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBill.Dock = DockStyle.Bottom;
            dtgBill.Location = new Point(0, 140);
            dtgBill.Name = "dtgBill";
            dtgBill.RowHeadersWidth = 51;
            dtgBill.RowTemplate.Height = 29;
            dtgBill.Size = new Size(1238, 511);
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
            tbxTenNV.Size = new Size(467, 36);
            tbxTenNV.TabIndex = 68;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(1238, 651);
            Controls.Add(tbxTenNV);
            Controls.Add(dtgBill);
            Controls.Add(button1);
            Name = "Bill";
            Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)dtgBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dtgBill;
        private TextBox tbxTenNV;
    }
}