using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper;

namespace NugetDapper
{
    class Program 
    {
        static void Main(string[] args)
        {
            Passwort p = new Passwort("my$fbxf65");


            
            Console.WriteLine("Hashed Password: {0}", p.GibhashedPassword());
            Console.WriteLine("Salt:            {0}", p.GibSalt());
            Console.WriteLine("Valid:           {0}", p.Gibvalidation());
            Console.WriteLine();

            p.GenerateSaltBenchmarks();

            Console.ReadLine();





            //bool conn = DBconnect.OpenConnection();
            //Console.WriteLine(conn);
            //Console.WriteLine(ConnectStr("myDBconn"));

            //using(IDbConnection connection = new MySqlConnection(ConnectStr("myDBconn")))
            //{
            //    string command = "getEmployees_by_Name('Müller','Ralf');";
            //    var result = connection.Query(command).ToList();
            //    Console.WriteLine("result: " + result);
            //}



        }
        public static string ConnectStr( string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }	
}
