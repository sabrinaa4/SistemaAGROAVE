using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAGROAVE.Models
{
    internal class Compra
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public string TipoPag { get; set; }
        public string Descricao { get; set; }
        public int Unidade { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
    }
}
