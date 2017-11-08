using System;
using System.Windows.Forms;

namespace ShopElectronics
{
    public partial class AddUser : Form
    {
        public AddUser(TypeUser type)
        {
            InitializeComponent();

            rbSimpleUser.Checked = true;

            if(type == TypeUser.simpleUser)
                rbAdmin.Visible = false;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPassword.Text) || 
               string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbConfirmPassword.Text))
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

            string typeUser = rbAdmin.Checked == true ? "true" : "false";

            if(User.AddUser(tbLogin.Text, tbPassword.Text, typeUser, tbEmail.Text) == false)
            {
                MessageBox.Show("Such user already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}