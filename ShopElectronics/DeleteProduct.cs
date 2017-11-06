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
    public partial class DeleteProduct : Form
    {       
        DataGridViewCell viewCell; //грид со всеми данными о товарах в магазине
        object productNameDelete, firmDelete, numberDelete, priceDelete; //объекты грида
        int indexRow; //индекст строки в гриде

        private void DeleteProduct_SizeChanged(object sender, EventArgs e)
        {
            this.ProductName.Width = (dataGridViewDelete.Size.Width / 4) -10;
            this.NameFirm.Width = (dataGridViewDelete.Size.Width / 4) -10;
            this.NumberProduct.Width = (dataGridViewDelete.Size.Width / 4) -10;
            this.ProductPrice.Width = (dataGridViewDelete.Size.Width / 4) -10;
        }

        public DeleteProduct()
        {
            InitializeComponent();

            dataGridViewDelete.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

            DataDBShop.ViewData(dataGridViewDelete); //вывод данных на экран
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataDBShop.DeleteProduct(productNameDelete, firmDelete, numberDelete, 
                                     priceDelete, dataGridViewDelete);
        }

        private void SelectProductForDelete(object sender, MouseEventArgs e)
        {
            viewCell = dataGridViewDelete.CurrentCell;//вытянуть строку которую выделили
            indexRow = viewCell.RowIndex; //вытянуть индекс строки

            //вытягивание выбранного имени твоара с грида
            productNameDelete = dataGridViewDelete.Rows[indexRow].Cells[0].Value;

            //вытягивание выбранной фирмы с грида
            firmDelete = dataGridViewDelete.Rows[indexRow].Cells[1].Value;

            //вытягивание выбранного кол-ва товара с грида
            numberDelete = dataGridViewDelete.Rows[indexRow].Cells[2].Value;

            //вытягивание выбранной цены товара с грида
            priceDelete = dataGridViewDelete.Rows[indexRow].Cells[3].Value;
        }
    }
}
