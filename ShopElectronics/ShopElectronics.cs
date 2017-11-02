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
    public partial class ShopElectronics : Form
    {
        private TypeUser typeUser;
        private string login;

        public ShopElectronics(TypeUser tu, string log)
        {
            InitializeComponent();

            //присваивание данных о пользователе
            typeUser = tu;
            login = log;

            Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);

            label1.Anchor = Anchor = (AnchorStyles.Top);
            label2.Anchor = Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            label3.Anchor = Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);

            AddProduct.Anchor = (AnchorStyles.Top);
            DeleteProduct.Anchor = (AnchorStyles.Top);
            ViewProducts.Anchor = (AnchorStyles.Top);
            BuyProduct.Anchor = (AnchorStyles.Top);

            llLogOut.Text += ", " + log;
        }

        private void AddProduct_Click(object sender,EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
        }

        private void BuyProduct_Click(object sender,EventArgs e)
        {
            Buy buyProduct = new Buy();
            buyProduct.ShowDialog();
        }

        private void ViewProducts_Click(object sender,EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts();
            viewProducts.ShowDialog();
        }

        private void DeleteProduct_Click(object sender,EventArgs e)
        {
            DeleteProduct delete = new DeleteProduct();
            delete.ShowDialog();
        }

        private void ShopElectronics_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShopElectronics_Load(object sender, EventArgs e)
        {
            if(typeUser == TypeUser.simpleUser)
            {
                AddProduct.Visible = false;
                DeleteProduct.Visible = false;

                ViewProducts.Location = new Point(AddProduct.Location.X, AddProduct.Location.Y);
                BuyProduct.Location = new Point(DeleteProduct.Location.X, DeleteProduct.Location.Y);
            }
        }

        private void llLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            Authentification a = new Authentification();
            a.ShowDialog();
        }

        private void llCheckOut_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser(typeUser);
            if(au.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("The user was successfully added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
