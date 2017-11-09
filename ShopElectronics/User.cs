using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopElectronics
{
    public enum Window
    {
        addProuct,
        deleteProduct
    }

    public enum TypeUser
    {
        admin,
        simpleUser
    }

    static class User
    {
        //поля
        //-------------------------------------------------------------------------

        static private TypeUser typeUser;

        //-------------------------------------------------------------------------

        //свойства
        //-------------------------------------------------------------------------

        static public TypeUser TypeUser
        {
            get
            {
                return typeUser;
            }
        }

        //-------------------------------------------------------------------------

        //методы
        //-------------------------------------------------------------------------

        static public bool CheckUser(string login, string pass)
        {
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db;"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на выборку из главной таблицы
                    command.CommandText = "SELECT * FROM Users";

                    //чтение данных с главной таблицы
                    using(SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            if(reader["Login"].ToString() == login)
                            {
                                if(reader["Password"].ToString() == pass)
                                {
                                    typeUser = reader["Admin"].ToString() == "true" ? TypeUser.admin : TypeUser.simpleUser;
                                    return true;
                                }
                            }
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }
            return false;
        }

        static public bool SearchUser(string log, string email)
        {
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на выборку из главной таблицы
                    command.CommandText = "SELECT * FROM Users";

                    //чтение данных с главной таблицы
                    using(SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            if(reader["Login"].ToString() == log && reader["Email"].ToString() == email)
                                return true;
                        }
                        reader.Close();
                    }

                }
                connection.Close();
            }
            return false;
        }

        static public bool AddUser(string log, string pass, string typeUser, string email)
        {
            if(SearchUser(log, email) == true)
                return false;

            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на добавление нового пользователя
                    command.CommandText = string.Format("INSERT INTO Users(Login, Password, Admin, Email) Values('{0}', '{1}', '{2}', '{3}')", log, pass, typeUser, email);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

            return true;
        }

        static public void ViewUsers(DataGridView grid)
        {
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на выборку из главной таблицы
                    command.CommandText = "SELECT * FROM Users";

                    //чтение данных с главной таблицы
                    using(SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            grid.Rows.Add(reader["Login"], reader["Password"], reader["Admin"], reader["Email"]);
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }
        }

        static public void DeleteUser(string log)
        {
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на добавление нового пользователя
                    command.CommandText = string.Format("DELETE FROM Users WHERE Login = '{0}'", log);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        static public void UpdateUser(string login, string newlogin, string password, string email, string admin)
        {
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на добавление нового пользователя
                    command.CommandText = string.Format("UPDATE Users SET Login='{1}', Password='{2}', Admin='{3}', Email='{4}' WHERE Login = '{0}'", login, newlogin, password, admin, email);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}

