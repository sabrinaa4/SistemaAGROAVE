using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAGROAVE.DataBase;
using SistemaAGROAVE.Interface;
using SistemaAGROAVE.Models;
using MySql.Data.MySqlClient;

namespace SistemaAGROAVE.Models
{
    internal class VendaDAO : IDAO<Venda>
    {
        private static Conexao conn;

        public VendaDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Venda t)
        {
            throw new NotImplementedException();
        }

        public Venda GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Venda> List()
        {

            try
            {
                List<Venda> list = new List<Venda>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Vendas;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Venda()
                    {
                        Id = reader.GetInt32("id_ven"),
                        Valor = reader.GetDouble("valor_ven"),
                        TipoDePag = reader.GetString("tipo_pagamento_ven"),
                        Descricao = reader.GetString("descricao_ven"),
                        Unidades = reader.GetInt32("unidades_ven"),
                        Email = reader.GetString("email_ven"),
                        Funcao = reader.GetString("funcao_ven"),
                        Setor = reader.GetString("setor_ven")
                    });
                }

                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
        }
        public void Update(Venda t)
        {
            throw new NotImplementedException();
        }
        public void Insert(Venda t)
        {

            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Aves (valor_ven, tipo_pagamento_ven, descricao_ven, unidades_ven, email_ven, funcao_ven, setor_ven)" +
                    "VALUES (@valor,@tipo_pagamento,@descricao, @unidades, @email, @funcao, @setor)";
                query.Parameters.AddWithValue("@valor", t.Valor);
                query.Parameters.AddWithValue("@tipo_pagamento", t.TipoDePag);
                query.Parameters.AddWithValue("@descricao", t.Descricao);
                query.Parameters.AddWithValue("@unidades", t.Unidades);
                query.Parameters.AddWithValue("@email", t.Email);
                query.Parameters.AddWithValue("@funcao", t.Funcao);
                query.Parameters.AddWithValue("@setor", t.Setor);
                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("O registo não foi inserido. Verifique e tente novamente");


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }


        }

        internal static void Insert(Views.ConsultarVenda Venda)
        {
            throw new NotImplementedException();
        }
    }
}
