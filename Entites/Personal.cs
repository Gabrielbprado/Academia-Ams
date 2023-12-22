using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_AMS
{
    internal class Personal:Pessoa
    {

        private long _salario;
        private string _contrato;
        private string _servico;
        private string _senha;

        public long salario { get => _salario; set => _salario = value; }
        public string contrato { get => _contrato; set => _contrato = value; }
        public string servico { get => _servico; set => _servico = value; }
        public string senha { get => _senha; set => _senha = value; }

    }
}
