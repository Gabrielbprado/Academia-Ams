using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Academia_AMS
{
    internal class Pessoa
    {
        private long _n_CPF { get; set; }
        private string _t_NAME;
        private string _n_DATA;
        private string _t_HORARIO;
        private long _n_TELEFONE;
        private string _t_OBS;
        private string _t_Servico;
        public static string bancoUsuario = "Data Source = D:\\Academia_AMS\\Academia AMS\\Banco_Fitness\\Bd_Fit.db";

        public long N_CPF { get => _n_CPF; set => _n_CPF = value; }
        public string T_SERVICO { get => _t_Servico; set => _t_Servico = value; }
        public string T_NAME { get => _t_NAME; set => _t_NAME = value; }
        public string N_DATA { get => _n_DATA; set => _n_DATA = value; }
        public string T_HORARIO { get => _t_HORARIO; set => _t_HORARIO = value; }
        public long N_TELEFONE { get => _n_TELEFONE; set => _n_TELEFONE = value; }
        public string T_OBS { get => _t_OBS; set => _t_OBS = value; }

    }
}
