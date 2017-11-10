using System;
using System.Drawing;
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
                UpdateDataInGrid();
                ap.Close();
            }

        }

        private void BuyProduct_Click(object sender, EventArgs e)
        {
            //грид со всеми данными о товарах в магазине
            DataGridViewCell viewCell = dataGridView.CurrentCell;
            int indexRow = viewCell.RowIndex; //индекст строки в гриде

            //занесение данных о выбранном товаре
            object productName = dataGridView.Rows[indexRow].Cells[0].Value;
            object firm = dataGridView.Rows[indexRow].Cells[1].Value;
            object priceProd = dataGridView.Rows[indexRow].Cells[3].Value;

            int price = int.Parse(priceProd.ToString());

            Buy buyProduct = new Buy(productName.ToString(), firm.ToString(), price);
            if(buyProduct.ShowDialog() == DialogResult.OK)
            {
                UpdateDataInGrid();
                buyProduct.Close();
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.No)
                return;

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

            MessageBox.Show("Item successfully deleted", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateDataInGrid();
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
            toolTip1.SetToolTip(this.btnViewUsers, "Manager users");

            if(typeUser == TypeUser.simpleUser)
            {
                AddProduct.Visible = false;
                DeleteProduct.Visible = false;
                btnViewUsers.Visible = false;

                BuyProduct.Location = new Point(AddProduct.Location.X, AddProduct.Location.Y);
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
            UserManager vu = new UserManager(login);
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

        private void ShopElectronics_SizeChanged_1(object sender, EventArgs e)
        {
            this.NameProduct.Width = (dataGridView.Size.Width / 4) + 2;
            this.Firm.Width = (dataGridView.Size.Width / 4) - 2;
            this.Number.Width = (dataGridView.Size.Width / 4) - 20;
            this.Price.Width = (dataGridView.Size.Width / 4) - 23;
        }

        private void UpdateDataInGrid()
        {
            dataGridView.Rows.Clear();
            DataDBShop.ViewData(dataGridView);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
