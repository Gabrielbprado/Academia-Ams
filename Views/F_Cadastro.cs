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
    public partial class F_Cadastro : Form
    {
       private Banco banco = new Banco();
        private Pessoa usuario = new Pessoa();
        public F_Cadastro()
        {
            InitializeComponent();
            Pessoa.bancoUsuario = "Data Source = D:\\Academia_AMS\\Academia AMS\\Banco_Fitness\\Bd_Fit.db";


        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
               
                DateTime diaHoje = DateTime.Today;
            usuario.T_NAME = txt_Nome.Text;
            
            usuario.T_HORARIO = txt_Horario.Text;
            usuario.N_DATA = txt_Data.Text;
            usuario.N_CPF = long.Parse(txt_Cpf.Text);
            usuario.T_OBS = txt_Obs.Text;
            usuario.N_TELEFONE = long.Parse(txt_Telefone.Text);

            banco.NovoUsuario(usuario);
            Banco.OpenConnection(Pessoa.bancoUsuario).Close();


        }

        private void btn_PESQUISAR_Click(object sender, EventArgs e)
        {
            F_Pesquisar f_Pesquisar = new F_Pesquisar();
            f_Pesquisar.ShowDialog();

        }

    

        private void btn_Excluir_Click(object sender, EventArgs e)
        {             
                    F_Excluir f_Excluir = new F_Excluir();
                    f_Excluir.ShowDialog();
            }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

