using System;
using System.Windows.Forms;

namespace ShopElectronics
{
    public partial class EditUser : Form
    {
        private string login;
        private string password;

        public EditUser(string log, string pass, string adm, string em)
        {
            InitializeComponent();
            
            tbLogin.Text = log;
            tbPassword.Text = pass;
            cbAdmin.Text = adm;
            tbEmail.Text = em;

            login = log;
            password = tbPassword.Text;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPassword.Text) ||
               string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Fields 'Login', 'Password, 'Email' - required fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(tbEmail.Text);
            }
            catch
            {
                MessageBox.Show("Email is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(tbNewPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Confirmation password does not match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(tbNewPassword.Text != string.Empty)
                password = tbNewPassword.Text;

            User.UpdateUser(login, tbLogin.Text, password, tbEmail.Text, cbAdmin.Text);

            DialogResult = DialogResult.OK;

        }
    }
}
