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
    public partial class F_Excluir : Form
    {
        private int cpf; // Armazenar o CPF do usuário a ser excluído

        // Construtor que aceita o CPF como argumento
        public F_Excluir(int cpf)
        {
            InitializeComponent();
            this.cpf = cpf; // Configura o CPF ao criar o formulário
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Banco.ExcluirUsuario(cpf);
            this.Close(); // Fechar o formulário após a exclusão (se necessário)
        }

        // Restante do código...
    }


}
