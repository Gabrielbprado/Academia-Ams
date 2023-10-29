using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;
using System.Data;

namespace Academia_AMS
{
    internal class Banco
    {
        private static SQLiteConnection connection;
        
        public static SQLiteConnection OpenConnection()
        {
                connection = new SQLiteConnection("Data Source = D:\\BancoTreino\\Banco\\Banco.db");   
                connection.Open();
                 return connection;

        }

        public static DataTable ObterUsuarios()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

            try
            {

                    using(var cmd = OpenConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM fit_info";
                    adapter = new SQLiteDataAdapter(cmd.CommandText,OpenConnection());
                    adapter.Fill(dataTable);
                    OpenConnection().Close();
                    return dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
                OpenConnection().Close();
            }

        }

        public static DataTable Consulta(string sql)
        {

            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();
            try
            {

                using (var cmd = OpenConnection().CreateCommand())
                {
                    cmd.CommandText = sql;                    adapter = new SQLiteDataAdapter(cmd.CommandText, OpenConnection());
                    adapter.Fill(dataTable);
                    OpenConnection().Close();
                    return dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
                OpenConnection().Close();
            }


        }

            

    }
}
