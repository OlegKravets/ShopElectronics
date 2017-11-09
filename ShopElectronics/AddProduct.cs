using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ShopElectronics
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.AddNewProduct, "Add new product");
            toolTip1.SetToolTip(this.Exit, "Return to main page");
        }

        private void AddNewProduct_Click(object sender, EventArgs e)
        {
            //проверка
            //--------------------------------------------------------------

            if(string.IsNullOrEmpty(tbNameProduct.Text) ||
               string.IsNullOrEmpty(tbNameFirm.Text))
            {
                MessageBox.Show("Not all fields are filled out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //--------------------------------------------------------------

            string nameProduct = tbNameProduct.Text; //новое название продукта
            string nameFirm = tbNameFirm.Text; //новое название фирмы
            int number = (int) numUpDownNumber.Value; //новое кол-во продукта
            int price = (int) numUpDownPrice.Value; //новая цена

            DataDBShop.AddNewProduct(nameProduct, nameFirm, number, price);

            this.DialogResult = DialogResult.OK;
        }

        private void tbNameProduct_Validating(object sender, CancelEventArgs e)
        {
            if(tbNameProduct.Text == string.Empty)
                return;            

                if(char.IsDigit(tbNameProduct.Text[0]))
            {
                MessageBox.Show("NameProduct can not begin with a digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNameProduct.Clear();
                return;
            }
        }
    }
}
