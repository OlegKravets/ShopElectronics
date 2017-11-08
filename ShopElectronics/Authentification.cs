using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ShopElectronics
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPassword.Text))
            //{
            //    MessageBox.Show("Not all fields are filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if(!(User.CheckUser(tbLogin.Text, tbPassword.Text)))
            //{
            //    MessageBox.Show("Login or Password is not correct!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

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
