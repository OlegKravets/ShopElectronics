using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopElectronics
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();

            tbPassword.PasswordChar = '*';
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
