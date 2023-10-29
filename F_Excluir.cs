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


        // Construtor que aceita o CPF como argumento
        public F_Excluir()
        {
            InitializeComponent();

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma a Exclusão ", "Excluir",MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                int cpf = int.Parse(textBox1.Text);
                Banco.DeletarUsuario(cpf);
            }
                }
    }


}
