using System;
using System.Windows.Forms;

namespace ShopElectronics
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnApply, "Add new user");
            toolTip1.SetToolTip(this.btnCancel, "Return to main page");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(!char.IsLetterOrDigit(tbLogin.Text[0]))
            {
                MessageBox.Show("Login must begin with a symbol!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPassword.Text) || 
               string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbConfirmPassword.Text) ||
               string.IsNullOrEmpty(cbAdmin.Text))
            {
                MessageBox.Show("Not all fields are filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if(tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Confirmation password does not match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(User.SearchUser(tbLogin.Text, tbEmail.Text))
            {
                MessageBox.Show("Such user already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(User.AddUser(tbLogin.Text, tbPassword.Text, cbAdmin.Text, tbEmail.Text) == false)
            {
                MessageBox.Show("Such user already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}