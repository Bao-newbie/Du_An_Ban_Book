using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.View
{
    public partial class Main : Form
    {
        Button currenButon;
        Random random;
        int tempIndex;
        Form activeForm;
        public Main()
        {
            random = new Random();
            InitializeComponent();
        }
        private Color SelectThemColor()
        {
            int index = random.Next(ColorMenu.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ColorMenu.ColorList.Count);
            }
            tempIndex = index;
            string color = ColorMenu.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currenButon != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemColor();
                    currenButon = (Button)btnSender;
                    currenButon.BackColor = color;
                    currenButon.ForeColor = Color.White;
                    currenButon.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(40, 42, 52);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void OpenchildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenchildForm(new View.BookStore(), sender);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            OpenchildForm(new View.Customer(), sender);

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenchildForm(new View.Menu(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
