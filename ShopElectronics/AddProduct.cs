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

            //--------------------------------------------------------------

            label1.Anchor = AnchorStyles.Top;
            label2.Anchor = AnchorStyles.Top;
            label3.Anchor = AnchorStyles.Top;
            label4.Anchor = AnchorStyles.Top;

            NameNew.Anchor = AnchorStyles.Top;
            NameProductNew.Anchor = AnchorStyles.Top;
            NumberNew.Anchor = AnchorStyles.Top;
            PriceNew.Anchor = AnchorStyles.Top;

            AddNewProduct.Anchor = AnchorStyles.Top;

            //--------------------------------------------------------------
        }

        private void AddNewProduct_Click(object sender,EventArgs e)
        {
            //проверка
            //--------------------------------------------------------------

            if(string.IsNullOrEmpty(NameProductNew.Text) || 
               string.IsNullOrEmpty(NameNew.Text) ||
               string.IsNullOrEmpty(NumberNew.Text) ||
               string.IsNullOrEmpty(PriceNew.Text))
            {
                MessageBox.Show("Not all fields are filled out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //--------------------------------------------------------------
 
            string nameProduct = NameProductNew.Text; //новое название продукта
            string name = NameNew.Text; //новое название фирмы
            int number = 0; //новое кол-во продукта
            int price = 0; //новая цена

            if(!int.TryParse(NumberNew.Text, out number) || number <= 0 ||
               !int.TryParse(PriceNew.Text, out price) || price <= 0)
            {
                MessageBox.Show("Incorrect input in field 'Number' of 'Price'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataDBShop.AddNewProduct(nameProduct, name, number, price); 
        }
    }
}
