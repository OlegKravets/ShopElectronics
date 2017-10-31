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

    class User
    {
        static private string passwordAdmin = "111";

        static public string PasswordAdmin
        {
            get
            {
                return passwordAdmin;
            }
        }

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
                            if(reader["Login"].ToString() == login)
                            {
                                if(reader["Password"].ToString() == pass)
                                {
                                    typeUser = reader["Admin"].ToString() == "true"? TypeUser.admin: TypeUser.simpleUser;
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

        static public bool SearchUser(string log)
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
                            if(reader["Login"].ToString() == log)
                                return true;
                        }
                        reader.Close();
                    }

                }
                connection.Close();
            }
            return false;
        }

        static public bool AddUser(string log, string pass, string typeUser)
        {
            using(SQLiteConnection connection = new SQLiteConnection("data source=ElectronicsProduct.db"))
            {
                using(SQLiteCommand command = new SQLiteCommand(connection))
                {
                    connection.Open();

                    //подготовка запроса на добавление нового пользователя
                    try
                    {
                        command.CommandText = string.Format("INSERT INTO Users(Login, Password, Admin) Values('{0}', '{1}', '{2}')", log, pass, typeUser);
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        return false;

                    }
                    connection.Close();
                }
                return true;
            }
        }

        //-------------------------------------------------------------------------
    }
}
