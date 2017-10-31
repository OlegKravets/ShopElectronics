using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ShopElectronics
{
    class DataDBShop
    {
        static public void CreateTable(SQLiteCommand command, string nameProduct)
        {
            command.CommandText = string.Format("INSERT INTO Product(Name) Values('{0}')", nameProduct);
            command.ExecuteNonQuery();

            command.CommandText = string.Format("CREATE TABLE {0} (Name char(32), Number int, Price int)", nameProduct);
            command.ExecuteNonQuery();
        }

        static public void UpdateTable(SQLiteCommand command, string query)
        {
            command.CommandText = query;
            command.ExecuteNonQuery();
        }

        static public void AddNewProduct(string nameProduct, string name,
                                         int number, int price)
        {
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //поиск добавляемого товара в уже существующих
                    command.CommandText = string.Format("SELECT Name FROM Product WHERE Name = '{0}'", nameProduct);

                    //проверка на наличие добавляемого товара
                    SQLiteDataReader reader = command.ExecuteReader();

                    //если такого товара нет, тогда добавить его и создать отдельную таблицу дял него
                    if(reader.HasRows == false)
                    {
                        reader.Close();
                        CreateTable(command, nameProduct);
                    }

                    reader.Close();

                    //добавить новый товар
                    command.CommandText = string.Format("SELECT Name,Price FROM {0}", nameProduct);
                    reader = command.ExecuteReader();

                    if(reader.HasRows == true)
                    {
                        while(reader.Read())
                        {
                            if(reader["Name"].ToString() == name &&
                               int.Parse(reader["Price"].ToString()) == price)
                            {
                                reader.Close();

                                string query = string.Format("UPDATE {0} SET Number = Number+{2} WHERE Name = '{1}'", nameProduct, name, number);

                                UpdateTable(command, query);

                                MessageBox.Show("Product already exists.The record was successfully updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                connection.Close();

                                return;
                            }
                        }
                    }
                    reader.Close();

                    command.CommandText = string.Format("INSERT INTO {0} (Name,Number,Price) Values('{1}', {2} ,{3})", nameProduct, name, number, price);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("The record was successfully added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
        }

        static public void ViewData(DataGridView dataGridView)
        {
            int i = 0;
            List<string> products = new List<string>();

            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на выборку из главной таблицы
                    command.CommandText = "SELECT * FROM Product";

                    //чтение данных с главной таблицы
                    using(SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            products.Add(reader["Name"].ToString());
                        }
                        reader.Close();
                    }

                    int sizeMainTable = products.Count(); //размер главной таблицы
                    int lineInMaintable = 0; //счётчик строк в главной таблице

                    List<string> name = new List<string>(); //все названия в дочерней таблице
                    List<string> number = new List<string>(); //всё кол-вотовара  в дочерней таблице
                    List<string> price = new List<string>(); //все цены в дочерней таблице

                    for(int j = 0; j < sizeMainTable; j++)
                    {
                        //подготовка запроса на выборку из дочерней таблицы
                        command.CommandText = string.Format("SELECT * FROM {0}", products[i++]);

                        //чтение данных с таблицы
                        using(SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                name.Add(reader["Name"].ToString());
                                number.Add(reader["Number"].ToString());
                                price.Add(reader["Price"].ToString());
                            }
                            reader.Close();
                        }

                        //вывод в грид данных после результата выборки
                        for(int k = 0; k < name.Count(); k++)
                            dataGridView.Rows.Add(products[lineInMaintable], name[k], number[k], price[k]);

                        lineInMaintable++; //переход на следующую строку главной таблицы

                        name.Clear(); //очистка списка имен
                        number.Clear(); //очистка списка кол-во
                        price.Clear(); //очистка списка цены
                    }
                }
                connection.Close();//закрыть соединение с БД
            }
        }

        static public void DeleteProduct(object productNameDelete, object firmDelete,
                                         object numberDelete, object priceDelete,
                                         DataGridView dataGridViewDelete)
        {
            //создание соединения с БД
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на удаления записи из таблицы
                    command.CommandText = string.Format("DELETE FROM {0} WHERE Name = '{1}' AND Number = '{2}' AND Price = '{3}'",
                                                        productNameDelete.ToString(),
                                                        firmDelete.ToString(),
                                                        numberDelete.ToString(),
                                                        priceDelete.ToString());

                    //выполнение запроса
                    command.ExecuteNonQuery();

                    //подготовка запроса на выборку из таблицы, где удаляли запись
                    command.CommandText = string.Format("SELECT * FROM {0}", productNameDelete.ToString());

                    SQLiteDataReader reader = command.ExecuteReader();

                    //если таблица пустая, то её нужно удалить
                    if(reader.HasRows == false)
                    {
                        reader.Close();

                        //подготовка запроса на удаление таблицы с БД
                        command.CommandText = string.Format("DROP TABLE {0}", productNameDelete.ToString());
                        command.ExecuteNonQuery();

                        //подготовка запроса на удаление товара (строки) в главной таблице
                        command.CommandText = string.Format("DELETE FROM Product WHERE Name = '{0}'", productNameDelete.ToString());
                        command.ExecuteNonQuery();
                    }
                    reader.Close();
                }

                MessageBox.Show("Item successfully deleted", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridViewDelete.Rows.Clear(); //очистка грида
                ViewData(dataGridViewDelete);//вывод данных в грид после его модификации 

                connection.Close();//закрыть соединение с БД
            }
        }

        static public void EnterValues(SQLiteCommand command, ListBox lbFirm,
                                       ListBox lbNumber, ListBox lbPrice)
        {
            using(SQLiteDataReader reader = command.ExecuteReader()) //чтение данных с таблицы
            {
                //заполнение listBox-а данными с БД
                while(reader.Read())
                {
                    lbFirm.Items.Add(reader["Name"]);
                    lbNumber.Items.Add(reader["Number"].ToString());
                    lbPrice.Items.Add("$" + reader["Price"].ToString());
                }
                reader.Close();
            }
        }

        static public void InputDateWithTable(ListBox lbProduct, ListBox lbFirm,
                                            ListBox lbNumber, ListBox lbPrice,
                                            string nameProduct)
        {
            //сюда вставляем пункты
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    command.CommandText = string.Format("SELECT * FROM {0}", nameProduct);

                    if(nameProduct == "Product")
                    {
                        using(SQLiteDataReader reader = command.ExecuteReader()) //чтение данных с таблиц(ы)
                        {
                            while(reader.Read())
                            {
                                lbProduct.Items.Add((reader["Name"]).ToString());
                            }
                            reader.Close();
                        }
                    }
                    else
                        EnterValues(command, lbFirm, lbNumber, lbPrice);
                }
                connection.Close();//закрыть БД
            }
        }

        static public void CheckNumberProduct(string firmProduct, string nameProduct, int numberBuyProducts)
        {
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на выборку из дочерней таблицы
                    command.CommandText = string.Format("SELECT Number,Name FROM {0}", nameProduct);

                    using(SQLiteDataReader reader = command.ExecuteReader()) //чтение данных с таблицы
                    {
                        while(reader.Read())
                        {
                            if(reader["Name"].ToString() == firmProduct && int.Parse(reader["Number"].ToString()) < numberBuyProducts)
                            {
                                MessageBox.Show("Excuse me. The product is out of stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        reader.Close();
                    }
                }
                connection.Close();//закрыть соединение с БД
            }
        }

        static public int BuyProduct(string nameProduct, int numberBuyProducts, 
                                      string firmProduct, int numberProduct, 
                                      int priceProduct, ListBox lbFirm, 
                                      ListBox lbNumber, ListBox lbPrice)
        {
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на обновление товара
                    string query = string.Format("UPDATE {0} SET Number = Number-{1} WHERE Name='{2}'",
                                          nameProduct, numberBuyProducts, firmProduct);

                    UpdateTable(command, query);

                    //подготовка запроса на выборку из дочерней таблицы
                    command.CommandText = string.Format("SELECT * FROM {0}", nameProduct);

                    using(SQLiteDataReader reader = command.ExecuteReader()) //чтение данных с таблицы
                    {
                        while(reader.Read())
                        {
                            if(reader["Name"].ToString() == firmProduct)
                            {
                                numberProduct = int.Parse(reader["Number"].ToString());
                                priceProduct = int.Parse(reader["Price"].ToString());
                            }
                        }
                        reader.Close();
                    }

                    //очистка табличек
                    lbFirm.Items.Clear();
                    lbNumber.Items.Clear();
                    lbPrice.Items.Clear();

                    EnterValues(command, lbFirm, lbNumber, lbPrice);
                }
                connection.Close();//закрыть БД

                return priceProduct * numberBuyProducts;
            }
        }
    }
}