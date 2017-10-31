using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopElectronics
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            rbSimpleUser.Checked = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Not all fields are filled out!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(User.SearchUser(tbLogin.Text))
            {
                MessageBox.Show("Such user already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string typeUser = rbAdmin.Checked == true ? "true" : "false";

            if(User.AddUser(tbLogin.Text, tbPassword.Text, typeUser))
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }
    }
}
