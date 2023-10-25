using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAGROAVE.Models
{
    internal class Caixa
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Data { get; set; }
        public string Funcionario { get; set; }
        public string HoraAbertura { get; set; }
        public string HoraFechamento { get; set; }
        public double ValorInicial { get; set; }
        public double ValorFinal { get; set; }
    }
}
