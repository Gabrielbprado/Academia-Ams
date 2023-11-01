using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia_AMS
{
    public partial class F_Pesquisar : Form
    {   F_Cadastro f_Cadastro = new F_Cadastro();
        public F_Pesquisar()
        {
            InitializeComponent();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_Pesquisa.Text, out int cpf))
                {
                    // Chama o método para obter os dados do usuário pelo CPF
                    Pessoa usuario = Banco.ObterUsuarioPorCPF(cpf);

                    // Verifica se o usuário foi encontrado
                    if (usuario != null)
                    {
                        // Preenche os TextBox com os dados do usuário
                        PreencherCampos(usuario);
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um CPF válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                Banco.OpenConnection(Pessoa.bancoUsuario).Close();
            }
        }

        private void PreencherCampos(Pessoa usuario)
        {
            txt_Nome.Text = usuario.T_NAME;
            txt_Data.Text = usuario.N_DATA.ToString();
            txt_Servico.Text = usuario.T_SERVICO;
            txt_Horario.Text = usuario.T_HORARIO;
            txt_Id.Text = usuario.N_TELEFONE.ToString();
            txt_Obs.Text = usuario.T_OBS;
        }


        private void F_Pesquisar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Banco.ZerarGlobais();
            Banco.OpenConnection(Pessoa.bancoUsuario).Close();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            F_Cadastro f_Cadastro = new F_Cadastro();
            f_Cadastro.Show();
            this.Close();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            F_Excluir f_Excluir = new F_Excluir();
            f_Excluir.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}





