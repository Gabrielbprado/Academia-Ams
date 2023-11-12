using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia_AMS
{
    internal class BancoADM : Banco
    {


        public BancoADM()
        {
            Pessoa.bancoUsuario = "Data Source = D:\\Academia_AMS\\Academia AMS\\Banco_Fitness\\BacoADM.db";


        }

        private void AbrirConexao()
        {
            OpenConnection(Pessoa.bancoUsuario);


        }

        public override void NovoUsuario(Pessoa u)
        {
            if (VerificarNumber(u))
            {
                MessageBox.Show("Número de Telefone Já Cadastrado");
                return;
            }

            Personal p = (Personal)u; // Convertendo o objeto para a classe Personal

            try
            {
                var cmd = OpenConnection(Pessoa.bancoUsuario).CreateCommand();
                cmd.CommandText = "INSERT INTO t_instrutor (T_NOME_t_instrutor, T_SERVICO_t_instrutor, N_TELEFONE_t_instrutor, T_OBS_t_instrutor, N_CPF_t_instrutor, N_SALARIO_t_instrutor, T_CONTRATO_t_instrutor, N_SENHA_t_instrutor) VALUES (@nome, @servico, @telefone, @obs, @cpf, @salario, @contrato, @senha)";

                cmd.Parameters.AddWithValue("@nome", p.T_NAME);
                cmd.Parameters.AddWithValue("@servico", p.T_SERVICO);
                cmd.Parameters.AddWithValue("@telefone", p.N_TELEFONE);
                cmd.Parameters.AddWithValue("@obs", p.T_OBS);
                cmd.Parameters.AddWithValue("@cpf", p.N_CPF);
                cmd.Parameters.AddWithValue("@salario", p.salario);
                cmd.Parameters.AddWithValue("@contrato", p.contrato);
                cmd.Parameters.AddWithValue("@senha", p.senha);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário Cadastrado");

                OpenConnection(Pessoa.bancoUsuario).Close();
            }
            catch
            {
                MessageBox.Show("Não Foi Possível Adicionar O Usuário. Tente Novamente");
            }
        }


        public DataTable Consulta(string sql)
        {

            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();
            try
            {

                using (var cmd = OpenConnection(Pessoa.bancoUsuario).CreateCommand())
                {
                    cmd.CommandText = sql;
                    adapter = new SQLiteDataAdapter(cmd.CommandText, OpenConnection(Pessoa.bancoUsuario));
                    adapter.Fill(dataTable);

                    OpenConnection(Pessoa.bancoUsuario).Close();
                    return dataTable;
                }

            }
            catch (Exception ex)
            {

                throw ex;

            }


        }

        
        }

     
            }

        
