using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAGROAVE.Models
{
    internal class Estoque
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string NomeProduto { get; set; }
        public string Quantidade { get; set; }
        public string Descricao { get; set; }
        public string DataFabricacao { get; set; }
        public string DataValidade { get; set; }


    }
}
