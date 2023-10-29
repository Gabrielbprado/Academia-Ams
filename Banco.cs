using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;
using System.Data;
using System.Windows.Forms;

namespace Academia_AMS
{
    internal class Banco
    {
        private static SQLiteConnection connection;
        
        public static SQLiteConnection OpenConnection()
        {
                connection = new SQLiteConnection("Data Source = D:\\Academia_AMS\\Academia AMS\\Banco_Fitness\\Bd_Fit.db");   
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
                    cmd.CommandText = sql;                    
                    adapter = new SQLiteDataAdapter(cmd.CommandText, OpenConnection());
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

            ///informaçoes do usuario (Cadastro)
        
                      public static void NovoUsuario(Usuario u)
        {
                        if(VerificarNumber(u))
            {
                MessageBox.Show("Numero De Telefone Já Cadastrado");
                return;

            }
                        try
            {
                    var cmd = OpenConnection().CreateCommand();
                cmd.CommandText = "INSERT INTO fit_info (T_NAME, N_DATA, T_SERVICO, T_HORARIO, N_TELEFONE, T_OBS, N_CPF) VALUES (@nome, @data, @servico, @horario, @telefone, @obs, @cpf)";

                cmd.Parameters.AddWithValue("@nome", u.T_NAME);
                cmd.Parameters.AddWithValue("@data", u.N_DATA);
                cmd.Parameters.AddWithValue("@servico", u.T_SERVICO);
                cmd.Parameters.AddWithValue("@horario", u.T_HORARIO);
                cmd.Parameters.AddWithValue("@telefone", u.N_TELEFONE);  // Remova o '@' antes de "telefone"
                cmd.Parameters.AddWithValue("@obs", u.T_OBS);
                cmd.Parameters.AddWithValue("@cpf", u.N_CPF);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Cadastrado");
                OpenConnection().Close();

            }       

            catch
            {
                MessageBox.Show("Não Foi Possivel Adicionar O Usuario Tente Novamnte");
                OpenConnection().Close();
            }
                
        }

            //Rotinas Gerais

        public static bool VerificarNumber(Usuario u)
        {
           
                bool resultado;
            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();

                using (var cmd = OpenConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT N_TELEFONE FROM fit_info WHERE N_TELEFONE ='"+u.N_TELEFONE+"'";
                adapter = new SQLiteDataAdapter(cmd.CommandText, OpenConnection());
                    adapter.Fill(dataTable);
                if(dataTable.Rows.Count>0)
                {
                        resultado = true;
                }else
                {
                        resultado=false;

                }

                    
                }

                return resultado;
            }

        public static Usuario ObterUsuarioPorCPF(int cpf)
        {
            using (var cmd = OpenConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM fit_info WHERE N_CPF = @cpf";
                cmd.Parameters.AddWithValue("@cpf", cpf);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Cria um objeto Usuario e preenche com os dados do banco
                    Usuario usuario = new Usuario
                    {
                        T_NAME = reader["T_NAME"].ToString(),
                        N_DATA = int.Parse(reader["N_DATA"].ToString()),
                        T_SERVICO = reader["T_SERVICO"].ToString(),
                        T_HORARIO = reader["T_HORARIO"].ToString(),
                        N_TELEFONE = int.Parse(reader["N_TELEFONE"].ToString()),
                        T_OBS = reader["T_OBS"].ToString(),
                        N_CPF = int.Parse(reader["N_CPF"].ToString())
                    };

                    return usuario;
                }

                return null; // Retorna null se o usuário não for encontrado
            }
        }







    }
}
