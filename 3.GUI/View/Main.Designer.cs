namespace _3.GUI.View
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panelMenu = new Panel();
            button1 = new Button();
            btnEmployee = new Button();
            btnCustom = new Button();
            btnBill = new Button();
            btnProduct = new Button();
            panelLogo = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            pnlDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(40, 42, 52);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnEmployee);
            panelMenu.Controls.Add(btnCustom);
            panelMenu.Controls.Add(btnBill);
            panelMenu.Controls.Add(btnProduct);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.White;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(255, 747);
            panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gainsboro;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, 657);
            button1.Name = "button1";
            button1.Padding = new Padding(18, 0, 0, 0);
            button1.Size = new Size(255, 63);
            button1.TabIndex = 7;
            button1.Text = "    Đăng Xuất";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployee.ForeColor = Color.Gainsboro;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(0, 342);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(18, 0, 0, 0);
            btnEmployee.Size = new Size(255, 63);
            btnEmployee.TabIndex = 6;
            btnEmployee.Text = "    Khác";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnCustom
            // 
            btnCustom.Dock = DockStyle.Top;
            btnCustom.FlatAppearance.BorderSize = 0;
            btnCustom.FlatStyle = FlatStyle.Flat;
            btnCustom.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustom.ForeColor = Color.Gainsboro;
            btnCustom.Image = (Image)resources.GetObject("btnCustom.Image");
            btnCustom.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustom.Location = new Point(0, 279);
            btnCustom.Name = "btnCustom";
            btnCustom.Padding = new Padding(18, 0, 0, 0);
            btnCustom.Size = new Size(255, 63);
            btnCustom.TabIndex = 3;
            btnCustom.Text = "    Khách Hàng";
            btnCustom.TextAlign = ContentAlignment.MiddleLeft;
            btnCustom.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustom.UseVisualStyleBackColor = true;
            btnCustom.Click += btnCustom_Click;
            // 
            // btnBill
            // 
            btnBill.Dock = DockStyle.Top;
            btnBill.FlatAppearance.BorderSize = 0;
            btnBill.FlatStyle = FlatStyle.Flat;
            btnBill.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBill.ForeColor = Color.Gainsboro;
            btnBill.Image = (Image)resources.GetObject("btnBill.Image");
            btnBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnBill.Location = new Point(0, 216);
            btnBill.Name = "btnBill";
            btnBill.Padding = new Padding(18, 0, 0, 0);
            btnBill.Size = new Size(255, 63);
            btnBill.TabIndex = 2;
            btnBill.Text = "    Hóa Đơn";
            btnBill.TextAlign = ContentAlignment.MiddleLeft;
            btnBill.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // btnProduct
            // 
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.Gainsboro;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 153);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(18, 0, 0, 0);
            btnProduct.Size = new Size(255, 63);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "    Sản Phẩm";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(255, 153);
            panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(255, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 96);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(577, 30);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 0;
            label1.Text = "Chào Mừng";
            label1.Click += label1_Click;
            // 
            // pnlDesktop
            // 
            pnlDesktop.Dock = DockStyle.Fill;
            pnlDesktop.Location = new Point(255, 96);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(1281, 651);
            pnlDesktop.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1536, 747);
            Controls.Add(pnlDesktop);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Main";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnProduct;
        private Button btnCustom;
        private Button btnBill;
        private Button btnEmployee;
        private Button button1;
        private Panel panel1;
        private Panel pnlDesktop;
        private Label label1;
    }
}