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

        // Modifique o construtor para receber um objeto Usuario
        public F_Excluir()
        {
            InitializeComponent();
            
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int cpf))
            {
                DialogResult res = MessageBox.Show("Confirma a Exclusão ", "Excluir", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Banco.DeletarUsuario(cpf);
                    
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um CPF válido.");
            }
        }

    }
}




