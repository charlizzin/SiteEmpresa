using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string connectionString =
                                        "User=SYSDBA;" +
                                        "Password=masterkey;" +
                                        "Database=D:\\Reswincs\\NOVA SANTANA\\BANCO\\RESULTH.GDB;" +
                                        "DataSource=localhost;" +
                                        "Port=3050;" +
                                        "Dialect=3;" +
                                        "Charset=NONE;" +
                                        "Role=;" +
                                        "Connection lifetime=15;" +
                                        "Pooling=true;" +
                                        "MinPoolSize=0;" +
                                        "MaxPoolSize=50;" +
                                        "Packet Size=8192;" +
                                        "ServerType=0";

            FbConnection fbConnection = new FbConnection(connectionString);

            try
            {
                FbCommand fbCommand = new FbCommand();
                FbDataReader fbDataReader;

                fbCommand.CommandText = "select codcliente, nome from cliente order by codcliente";
                fbCommand.Connection = fbConnection;

                fbConnection.Open();

                fbDataReader = fbCommand.ExecuteReader();

                while (fbDataReader.Read())
                {
                    for (int i = 0; i < fbDataReader.FieldCount; i++)
                    {
                        Console.WriteLine(fbDataReader[i].ToString());
                    }
                }
                Console.ReadLine();
                fbConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
