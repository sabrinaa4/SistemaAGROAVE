using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAGROAVE.Models
{
    internal class Venda
    {
        public int Id { get; set; }
        public double Valor{ get; set; }
        public string TipoDePag { get; set; }
        public string Descricao { get; set; }
        public int Unidades { get; set; }
        public string Email { get; set; }
        public string Funcao { get; set; }
        public string Setor { get; set; }
       

    }
}