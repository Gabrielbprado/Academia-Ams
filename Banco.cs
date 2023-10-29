using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;

namespace Academia_AMS
{
    internal class Banco
    {
        private static SQLiteConnection connection;
        
        private static SQLiteConnection OpenConnection()
        {
                connection = new SQLiteConnection("Data Source = D:\\BancoTreino\\Banco\\Banco.db");   
            connection.Open();


            return connection;

        }


            

    }
}
