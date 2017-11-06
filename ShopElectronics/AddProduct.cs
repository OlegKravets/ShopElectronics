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
        }

        private void AddNewProduct_Click(object sender,EventArgs e)
        {
            //проверка
            //--------------------------------------------------------------

            if(string.IsNullOrEmpty(NameProductNew.Text) || 
               string.IsNullOrEmpty(NameNew.Text))
            {
                MessageBox.Show("Not all fields are filled out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //--------------------------------------------------------------
 
            string nameProduct = NameProductNew.Text; //новое название продукта
            string name = NameNew.Text; //новое название фирмы
            int number = (int)numUpDownNumber.Value; //новое кол-во продукта
            int price = (int) numUpDownPrice.Value; //новая цена

            DataDBShop.AddNewProduct(nameProduct, name, number, price); 
        }
    }
}
