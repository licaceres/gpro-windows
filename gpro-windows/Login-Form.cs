using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpro_windows
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //StartPosition was set to FormStartPosition.CenterScreen in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);

            this.panelRecupCont.Visible = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panelRecupCont.Visible = true;
        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panelRecupCont.Visible = false;
        }

    }
}
