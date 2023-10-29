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

                using (var cmd = OpenConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM fit_info";
                    adapter = new SQLiteDataAdapter(cmd.CommandText, OpenConnection());
                    adapter.Fill(dataTable);
                    
                    return dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
                
            }finally
            {

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
                   
                    return dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
                
            }finally
            {

                OpenConnection().Close();
            }


        }

        ///informaçoes do usuario (Cadastro)

        public static void NovoUsuario(Usuario u)
        {
            if (VerificarNumber(u))
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
                

            }

            catch
            {
                MessageBox.Show("Não Foi Possivel Adicionar O Usuario Tente Novamnte");
               
            }finally
            {
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
                cmd.CommandText = "SELECT N_TELEFONE FROM fit_info WHERE N_TELEFONE ='" + u.N_TELEFONE + "'";
                adapter = new SQLiteDataAdapter(cmd.CommandText, OpenConnection());
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    resultado = true;

                }
                else
                {
                    resultado = false;

                }
                OpenConnection().Close();

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
                OpenConnection().Close();
                return null; // Retorna null se o usuário não for encontrado
            }
        }

        public static void ExcluirUsuario(int cpf)
        {


          
                try
                {
                    using (var connection = OpenConnection())
                    {
                        // Adiciona um pequeno atraso antes de abrir uma nova conexão
                        System.Threading.Thread.Sleep(100);

                        // Obtém o usuário antes de excluir para obter o nome
                        Usuario usuario = ObterUsuarioPorCPF(cpf);

                        DialogResult resultado = MessageBox.Show($"Deseja excluir o usuário: {usuario.T_NAME}?", "Confirmação", MessageBoxButtons.OKCancel);

                        if (resultado == DialogResult.OK)
                        {
                            using (var cmd = connection.CreateCommand())
                            {
                                cmd.CommandText = "DELETE FROM fit_info WHERE N_CPF = @cpf";
                                cmd.Parameters.AddWithValue("@cpf", cpf);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Usuário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Operação Cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          
        
        }
                
       }




    }











        
    
