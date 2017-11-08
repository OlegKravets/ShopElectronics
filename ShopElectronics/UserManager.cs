using System;
using System.Windows.Forms;

namespace ShopElectronics
{
    public partial class UserManager : Form
    {
        private TypeUser typeUser;

        public UserManager(TypeUser tu)
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnAddUser, "Add new user");
            toolTip1.SetToolTip(this.btnDeleteUser, "Delete user");
            toolTip1.SetToolTip(this.btnAdmin, "Make user admin");
            toolTip1.SetToolTip(this.btnExit, "Exit");

            typeUser = tu;

            User.ViewUsers(grid);
        }

        private void ViewUsers_SizeChanged(object sender, EventArgs e)
        {
            this.Login.Width = (grid.Size.Width / 4) - 10;
            this.Password.Width = (grid.Size.Width / 4) -12;
            this.Admin.Width = (grid.Size.Width / 4) -60;
            this.Email.Width = (grid.Size.Width / 4) + 40;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser(typeUser);
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

            MessageBox.Show(string.Format("User {0} was successfully deleted!", userDelete), "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grid.Rows.Clear();
            User.ViewUsers(grid);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //выбранная ячейка грида
            DataGridViewCell viewCell = grid.CurrentCell;
            int indexRow = viewCell.RowIndex; //индекст строки в гриде

            //занесение данных о выбранном товаре
            object userDelete = grid.Rows[indexRow].Cells[0].Value;

            User.MakeAdmin(userDelete.ToString());

            grid.Rows.Clear();
            User.ViewUsers(grid);
        }
    }
}
