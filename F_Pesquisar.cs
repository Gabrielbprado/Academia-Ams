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
    {
        public F_Pesquisar()
        {
            InitializeComponent();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            int cpf =  int.Parse(txt_Cpf.Text);
            string name = txt_Nome.Text;
            int data = int.Parse(txt_Data.Text);
            string servico = txt_Servico.Text;
            string horario = txt_Horario.Text;
            int id = int.Parse(txt_Id.Text);
            string obs = txt_Obs.Text;

        }
    }
}
