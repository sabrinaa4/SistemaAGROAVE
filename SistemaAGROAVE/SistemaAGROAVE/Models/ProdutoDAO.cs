using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAGROAVE.Interface;
using SistemaAGROAVE.DataBase;
using MySql.Data.MySqlClient;

namespace SistemaAGROAVE.Models
{
    internal class ProdutoDAO : IDAO<Produto>
    {

        private static Conexao conn;

        public ProdutoDAO()
        {
            conn = new Conexao();
        }
        public void Delete(Produto t)
        {
            throw new NotImplementedException();
        }

        public Produto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Produto t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Produto (nome_prod, descricao_prod, data_fabricacao_prod, data_vencimento_prod, codigo_barras_prod, origem_prod , valor_prod)" +
                    " VALUES (@nome, @descricao, @data_fabricacao, @data_vencimento, @codigo_barras, @origem, @valor)";
                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue(" @descricao", t.Descricao);
                query.Parameters.AddWithValue(" @data_fabricacao", t.DataFabricacao);
                query.Parameters.AddWithValue(" @data_vencimento", t.DataVencimento);
                query.Parameters.AddWithValue("@codigo_barras", t.Codigo);
                query.Parameters.AddWithValue(" @origem", t.Origem);
                query.Parameters.AddWithValue(" @valor", t.Valor);
                

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
    

        public List<Produto> List()
        {
            try
            {
                List<Produto> list = new List<Produto>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Produto;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Produto()
                    {
                        Id = reader.GetInt32("id_prod"),
                        Nome = reader.GetString("nome_prod"),
                        Descricao = reader.GetString("descricao_prod"),
                        DataFabricacao = reader.GetString("data_fabricacao_prod"),
                        DataVencimento = reader.GetString("data_vencimento_prod"),
                        Codigo = reader.GetString("codigo_barras_prod"),
                        Origem = reader.GetString("origem_prod"),
                        Valor = reader.GetDouble("valor_prod")
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

        public void Update(Produto t)
        {
            throw new NotImplementedException();
        }
    }
}
