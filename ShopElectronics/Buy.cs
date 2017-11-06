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
    public partial class Buy : Form
    {
        private string nameProduct;
        private string firmProduct;

        public Buy()
        {
            InitializeComponent();

            DataDBShop.InputDateWithTable(lbProduct, lbFirm, lbNumber, lbPrice, "Product");
        }

        private void listBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //очистка таблиц
            lbFirm.Items.Clear();
            lbNumber.Items.Clear();
            lbPrice.Items.Clear();

            nameProduct = lbProduct.Text.ToString(); //вытянуть название, которое выбрал пользователь

            DataDBShop.InputDateWithTable(lbProduct, lbFirm, lbNumber, lbPrice, nameProduct);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            int numberProduct = 0;
            int priceProduct = 0;
            int numberBuyProducts = (int)numUpDownNumber.Value;

            firmProduct = lbFirm.Text;

            if(string.IsNullOrEmpty(lbProduct.Text))
            {
                MessageBox.Show("Select product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(string.IsNullOrEmpty(firmProduct))
            {
                MessageBox.Show("Select firm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //проверка на достаточное наличие товара для клиента
            //-----------------------------------------------------------------------------

            DataDBShop.CheckNumberProduct(firmProduct, nameProduct, numberBuyProducts);

            //-----------------------------------------------------------------------------

            //покупка и итоговая цена
            int finishPrice = DataDBShop.BuyProduct(nameProduct, numberBuyProducts, 
                                                    firmProduct, numberProduct, 
                                                    priceProduct, lbFirm, 
                                                    lbNumber, lbPrice);

            MessageBox.Show(string.Format("The product was successfully purchased. Amount to be paid ${0} ", finishPrice), "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
