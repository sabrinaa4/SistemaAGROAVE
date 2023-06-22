using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAGROAVE.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DataFabricacao { get; set; }
        public string DataVencimento { get; set; }
        public string Codigo { get; set; }
        public string Origem { get; set; }
        public double Valor { get; set; }

    }
}
