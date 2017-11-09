using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShopElectronics
{
    public partial class UserManager : Form
    {
        private string nameUser;

        public UserManager(string log)
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnAddUser, "Add new user");
            toolTip1.SetToolTip(this.btnDeleteUser, "Delete user");
            toolTip1.SetToolTip(this.btnEditUser, "Edit user");
            toolTip1.SetToolTip(this.btnCancel, "Return to main page");

            nameUser = log;

            User.ViewUsers(grid);
        }

        private void ViewUsers_SizeChanged(object sender, EventArgs e)
        {
            this.Login.Width = (grid.Size.Width / 4) - 10;
            this.Password.Width = (grid.Size.Width / 4) - 12;
            this.Admin.Width = (grid.Size.Width / 4) - 60;
            this.Email.Width = (grid.Size.Width / 4) + 40;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            if(au.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User was successfully added!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grid.Rows.Clear();
                User.ViewUsers(grid);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //выбранная ячейка грида
            DataGridViewCell viewCell = grid.CurrentCell;
            int indexRow = viewCell.RowIndex; //индекст строки в гриде

            //занесение данных о выбранном товаре
            object userDelete = grid.Rows[indexRow].Cells[0].Value;

            User.DeleteUser(userDelete.ToString());

            if(userDelete.ToString() == nameUser)
            {
                MessageBox.Show("You removed yourself! You now do not have access to the program. The program closes!", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }

            MessageBox.Show(string.Format("User {0} was successfully deleted!", userDelete), "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grid.Rows.Clear();
            User.ViewUsers(grid);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //выбранная ячейка грида
            DataGridViewCell viewCell = grid.CurrentCell;
            int indexRow = viewCell.RowIndex; //индекст строки в гриде

            //занесение данных о выбранном товаре
            string login = grid.Rows[indexRow].Cells[0].Value.ToString();
            string password = grid.Rows[indexRow].Cells[1].Value.ToString();
            string admin = grid.Rows[indexRow].Cells[2].Value.ToString();
            string email = grid.Rows[indexRow].Cells[3].Value.ToString();

            EditUser eu = new EditUser(login, password, admin, email);
            if(eu.ShowDialog() == DialogResult.OK)
            {             
                if(nameUser == login)
                {
                    MessageBox.Show(string.Format("User '{0}' was successfully edit! \nYou will need to re-authenticate!", login.ToString()), "Edit", MessageBoxButtons.OK);
                    Application.Restart();
                }

                MessageBox.Show(string.Format("User '{0}' was successfully edit!", login.ToString()), "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grid.Rows.Clear();
                User.ViewUsers(grid);
            }
        }
    }
}
