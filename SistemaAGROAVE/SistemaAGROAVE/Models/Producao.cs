using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAGROAVE.Models
{
    internal class Producao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Quantidade { get; set; }
        public string Data { get; set; }
        public string Descricao { get; set; }
        public string ProducaoDiaria  { get; set; }
        public string ProducaoSemanal { get; set; }
        public string ProducaoMensal { get; set; }
        public string ProducaoEsperada { get; set; }
        public string ProducaoReal { get; set; }
    }
}
