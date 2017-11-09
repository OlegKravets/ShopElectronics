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
        private int priceProd;

        public Buy(string prod, string firm, int price)
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnBuy, "Buy product");
            toolTip1.SetToolTip(this.btnExit, "Return to main page");

            nameProduct = prod;
            firmProduct = firm;
            priceProd = price;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            int numberBuyProduct = (int) numUpDownNumber.Value;

            //проверка на достаточное наличие товара для клиента
            //-----------------------------------------------------------------------------

            if(!DataDBShop.CheckNumberProduct(firmProduct, nameProduct, numberBuyProduct))
            {
                MessageBox.Show("Excuse me. The product is out of stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //-----------------------------------------------------------------------------

            //покупка и итоговая цена
            DataDBShop.BuyProduct(nameProduct, firmProduct, numberBuyProduct, priceProd);

            int finishPrice = priceProd * numberBuyProduct;

            MessageBox.Show(string.Format("The product was successfully purchased. Amount to be paid ${0} ", finishPrice), "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }
    }
}
