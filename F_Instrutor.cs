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
    public partial class F_Instrutor : Form
    {
        BancoADM BancoADM = new BancoADM();
        public F_Instrutor()
        {
            InitializeComponent();
            
        }

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            F_Cadastro f_Cadastro = new F_Cadastro();   
            f_Cadastro.Show();
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Personal persona = new Personal(); // Criando uma instância de Personal
            persona.T_NAME = txt_Nome.Text;
            persona.T_SERVICO = comboBox1.Text;
            persona.salario = double.Parse(txt_Salario.Text); // Alterando para double, pois parece ser um valor decimal
            persona.contrato = txt_Contrato.Text;
            persona.N_CPF = int.Parse(txt_Cpf.Text);
            persona.T_OBS = txt_Obs.Text;
            persona.N_TELEFONE = int.Parse(txt_Id.Text);
            persona.senha = txt_Senha.Text;

            BancoADM.NovoUsuario(persona); // Enviando a instância de Personal para o método NovoUsuario

            
        }

    }
}
