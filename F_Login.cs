
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
    public partial class F_Login : Form
    {
        BancoADM bancoADM = new BancoADM();
        DataTable dt = new DataTable();
        public F_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Pessoa.bancoUsuario = "Data Source = D:\\Academia_AMS\\Academia AMS\\Banco_Fitness\\BacoADM.db";

            try
            {
                int cpf = int.Parse(txt_cpf.Text);
                string senha = txt_Senha.Text;

                if (cpf == 0 || senha == "")
                {
                    MessageBox.Show("Usuário ou Senha inválidos");
                    txt_cpf.Focus();
                    return;
                }

                string slq = "SELECT * FROM t_instrutor WHERE N_CPF_t_instrutor='" + cpf + "' AND N_SENHA_t_instrutor='"+senha+"'";

                dt = bancoADM.Consulta(slq);

                if (dt.Rows.Count == 1)
                {
                    F_Cadastro f_Cadastro = new F_Cadastro();
                    f_Cadastro.Show();
                }else
                {

                    MessageBox.Show("Usuário ou Senha Inválidos");
                    txt_cpf.Focus();
                }
               
            }
            catch 
            {
                MessageBox.Show("Usuário ou Senha Inválidos");
                txt_cpf.Focus();
               
            }


        }

        private void lbl_CadastrarPersonal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_Instrutor f_Instrutor = new F_Instrutor();
            f_Instrutor.Show();
            
        }
    }
}
