using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NugetDapper
{
    class DBconnect
    {

        public static MySqlConnection connection;

        public DBconnect()
        {
            Initialize();
        }
        string connectionString;
        private static void Initialize()
        {
            string server = "127.0.0.1";
            string database = "uebungsdatenbank";
            string uid = "root";
            string password = "";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public static bool OpenConnection()
        {

            try
            {
                if (connection == null)
                    Initialize();
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Insert()
        {
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }

        public Dictionary<int, string> Select(string query)
        {

            Dictionary<int, string> itemsData = new Dictionary<int, string>();


            if (OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    itemsData.Add(Convert.ToInt32(dataReader["Preis"]), dataReader["Bezeichnung"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return itemsData;
            }
            else
            {
                return null;
            }
        }

        public void execute(string sql)
        {
            using (var cn = new MySqlConnection(connection.ToString()))
            using (var cmd = new MySqlCommand(sql, cn))
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        public string readField(string sql)
        {
            string output = "";
            using (var cn = new MySqlConnection(connection.ToString()))
            using (var cmd = new MySqlCommand(sql, cn))
            {
                cn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    rd.Read();
                    output = rd.GetString(0);

                    rd.Close();
                }
                cn.Close();
            }
            return output;
        }
    }

}

