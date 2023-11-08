using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAGROAVE.Models
{
    internal class PerfilFuncionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }   
        public string Funcao { get; set; }   
        public string Setor { get; set; }   

    }
}
