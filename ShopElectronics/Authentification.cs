using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Net.Mail;
using System.Net;

namespace ShopElectronics
{
    public partial class Authentification : Form
    {

        public Authentification()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnLogIn, "Log in");
            toolTip1.SetToolTip(this.btnCancel, "Exit");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Not all fields are filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!(User.CheckUser(tbLogin.Text, tbPassword.Text)))
            {
                MessageBox.Show("Login or Password is not correct!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();

            ShopElectronics se = new ShopElectronics(User.TypeUser, tbLogin.Text);
            se.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
