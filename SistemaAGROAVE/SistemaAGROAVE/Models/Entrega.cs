using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAGROAVE.Models
{
    internal class Entrega
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public double Taxa { get; set; }
        public double ValorTroco { get; set; }
        public string Hora { get; set; }
        public int NumCasa { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }

        public string Estado { get; set; }
        public int IdFunc { get; set; }
    }
}
