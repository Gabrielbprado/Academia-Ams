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
        public F_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
                
        }

        private void lbl_CadastrarPersonal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_Instrutor f_Instrutor = new F_Instrutor();
            f_Instrutor.Show();
            
        }
    }
}
