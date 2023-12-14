namespace _3.GUI.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtEmailLogin = new TextBox();
            txtPassLogin = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.BackColor = Color.FromArgb(60, 63, 81);
            txtEmailLogin.Cursor = Cursors.IBeam;
            txtEmailLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailLogin.ForeColor = Color.White;
            txtEmailLogin.Location = new Point(545, 182);
            txtEmailLogin.Margin = new Padding(4, 4, 4, 4);
            txtEmailLogin.Multiline = true;
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.PlaceholderText = "Email";
            txtEmailLogin.Size = new Size(314, 31);
            txtEmailLogin.TabIndex = 91;
            txtEmailLogin.TextChanged += txtEmailLogin_TextChanged;
            // 
            // txtPassLogin
            // 
            txtPassLogin.BackColor = Color.FromArgb(60, 63, 81);
            txtPassLogin.Cursor = Cursors.IBeam;
            txtPassLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassLogin.ForeColor = Color.White;
            txtPassLogin.Location = new Point(545, 244);
            txtPassLogin.Margin = new Padding(4, 4, 4, 4);
            txtPassLogin.Multiline = true;
            txtPassLogin.Name = "txtPassLogin";
            txtPassLogin.PlaceholderText = "Mật khẩu";
            txtPassLogin.Size = new Size(314, 31);
            txtPassLogin.TabIndex = 92;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(545, 324);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(313, 40);
            button1.TabIndex = 93;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources._04987c26aed84a227e522be830b4c16e;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(608, 48);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 95;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 418);
            panel1.TabIndex = 96;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(493, 632);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(927, 418);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtPassLogin);
            Controls.Add(txtEmailLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmailLogin;
        private TextBox txtPassLogin;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
    }
}