using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ShopElectronics
{
    public partial class ShopElectronics : Form
    {
        private TypeUser typeUser; //тип пользователя
        private string login; //логин пользователя

        public enum ItemMenu
        {
            print,
            export
        }

        public ShopElectronics(TypeUser tu, string log)
        {
            InitializeComponent();

            //присваивание данных о пользователе
            typeUser = tu;
            login = log;

            llLogOut.Text += ", " + log;
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            if(ap.ShowDialog() == DialogResult.OK)
            {
                dataGridView.Rows.Clear();
                DataDBShop.ViewData(dataGridView);

                ap.Close();
            }

        }

        private void BuyProduct_Click(object sender, EventArgs e)
        {
            Buy buyProduct = new Buy();
            buyProduct.ShowDialog();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            //грид со всеми данными о товарах в магазине
            DataGridViewCell viewCell = dataGridView.CurrentCell;
            int indexRow = viewCell.RowIndex; //индекст строки в гриде

            //занесение данных о выбранном товаре
            object productNameDelete = dataGridView.Rows[indexRow].Cells[0].Value;
            object firmDelete = dataGridView.Rows[indexRow].Cells[1].Value;
            object numberDelete = dataGridView.Rows[indexRow].Cells[2].Value;
            object priceDelete = dataGridView.Rows[indexRow].Cells[3].Value;

            //удаление товара
            DataDBShop.DeleteProduct(productNameDelete, firmDelete, numberDelete,
                                     priceDelete, dataGridView);
        }

        private void ShopElectronics_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShopElectronics_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.AddProduct, "Add new product");
            toolTip1.SetToolTip(this.DeleteProduct, "Delete product");
            toolTip1.SetToolTip(this.BuyProduct, "Buy product");

            if(typeUser == TypeUser.simpleUser)
            {
                AddProduct.Visible = false;
                DeleteProduct.Visible = false;
                btnViewUsers.Visible = false;

                BuyProduct.Location = new Point(DeleteProduct.Location.X, DeleteProduct.Location.Y);
            }

            DataDBShop.ViewData(dataGridView);
        }

        private void llLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            Authentification a = new Authentification();
            a.ShowDialog();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            UserManager vu = new UserManager(typeUser);
            vu.ShowDialog();
        }

        private void PrintProducts_Click(object sender, EventArgs e)
        {

        }

        private void ExportProducts_Click(object sender, EventArgs e)
        {
            //путь к месту сохранения
            string path = string.Empty;

            //окно для выбора места для сохранения
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "Документ Excel|*.xlsx, *.xls";
            svd.FileName = "ShopElectronicsDB.xlsx";

            if(svd.ShowDialog() != DialogResult.OK)
                return;

            path = svd.FileName;
            DataDBShop.ExportDBInExcelFile(path, ItemMenu.export);
        }

        private void ShopElectronics_SizeChanged(object sender, EventArgs e)
        {
            this.NameProduct.Width = (dataGridView.Size.Width /4) +2;
            this.Firm.Width = (dataGridView.Size.Width / 4) -2;
            this.Number.Width = (dataGridView.Size.Width / 4) -20;
            this.Price.Width = (dataGridView.Size.Width / 4) -23;
        }
    }
}
