using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAGROAVE.Models
{
    internal class Aves
    {
        public int Id { get; set; }
        public string Observacoes { get; set; }
        public string CorIdentificacao { get; set; }
        public int QuantObito { get; set; }
        public string Raca { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Lote { get; set; }
        public int NumeroGalpao { get; set; }

    }
}
