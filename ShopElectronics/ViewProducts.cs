using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace ShopElectronics
{
    public partial class ViewProducts : Form
    {
        public enum Menu
        {
            print,
            export
        }

        public ViewProducts()
        {
            InitializeComponent();

            //создание меню
            //----------------------------------------------------------------------
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Menu");

            fileItem.DropDownItems.Add("Print", null, PrintProducts_Click);
            fileItem.DropDownItems.Add("Export to Excel", null, ExportProducts_Click);

            menuMain.Items.Add(fileItem);

            //----------------------------------------------------------------------

            dataGridView.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

            DataDBShop.ViewData(dataGridView);
        }
        
        private void PrintProducts_Click(object sender, EventArgs e)
        {
            //путь к файлу
            string path = @"D:\Мой документы\Олег\Универ\3 курс\СПЗ\Курсач\ShopElectronics\Resourse\Excel.xlsx";

            //Сохранение БД в Excel и печать
            try
            {
                DataDBShop.ExportDBInExcelFile(path, Menu.print);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //удаление Excel файла
            File.Delete(path);
        }

        private void ExportProducts_Click(object sender, EventArgs e)
        {
            string path = string.Empty;

            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "Excel|*.xlsx";

            if(svd.ShowDialog() == DialogResult.OK)
                path = svd.FileName;

            DataDBShop.ExportDBInExcelFile(path, Menu.export);
        }
    }
}
