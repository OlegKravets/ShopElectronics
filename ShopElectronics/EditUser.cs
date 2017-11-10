using System;
using System.Windows.Forms;

namespace ShopElectronics
{
    public partial class EditUser : Form
    {
        private string login;
        private string password;
        private string admin;

        public EditUser(string log, string pass, string adm, string em)
        {
            InitializeComponent();

            tbLogin.Text = log;
            tbPassword.Text = pass;
            cbAdmin.Text = adm;
            tbEmail.Text = em;

            login = log;
            password = tbPassword.Text;
            admin = adm;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(!char.IsLetterOrDigit(tbLogin.Text[0]))
            {
                MessageBox.Show("Login must begin with a symbol!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            if(password != tbPassword.Text && tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Confirmation password does not match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            password = tbPassword.Text;

            User.UpdateUser(login, tbLogin.Text, password, tbEmail.Text, cbAdmin.Text);

            DialogResult = DialogResult.OK;
        }

        private void TbPassword_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(btnApply.Visible == false)
            {
                btnApply.Visible = true;
                Refresh();
            }           
        }

        private void CbAdmin_TextChanged(object sender, System.EventArgs e)
        {
            if(admin != null && btnApply.Visible == false)
            {
                btnApply.Visible = true;
                Refresh();
            }
        }

        private void TbEmail_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(btnApply.Visible == false)
            {
                btnApply.Visible = true;
                Refresh();
            }
        }

        private void TbLogin_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(btnApply.Visible == false)
            {
                btnApply.Visible = true;
                Refresh();
            }
        }
    }
}
