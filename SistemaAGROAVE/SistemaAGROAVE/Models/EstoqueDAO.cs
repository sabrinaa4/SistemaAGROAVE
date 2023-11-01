using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAGROAVE.Interface;
using SistemaAGROAVE.DataBase;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace SistemaAGROAVE.Models
{
    internal class EstoqueDAO : IDAO<Estoque>
    {
        private static Conexao conn;

        public EstoqueDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Estoque t)
        {
            throw new NotImplementedException();
        }

        public Estoque GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Estoque t)
        {


            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Estoque (nome_produto_est, codigo_est, descricao_est, quantidade_est, data_fabricaçao_est, data_validade_est)" +
                    "VALUES (@nome_produto, @codigo, @descricao, @quantidade, @data_fabricaçao, @data_validade)";
                query.Parameters.AddWithValue("@nome_produto", t.NomeProduto);
                query.Parameters.AddWithValue("@codigo", t.Codigo);
                query.Parameters.AddWithValue("@descricao", t.Descricao);
                query.Parameters.AddWithValue("@quantidade", t.Quantidade);
                query.Parameters.AddWithValue("@data_fabricacao", t.DataFabricacao);
                query.Parameters.AddWithValue("@data_vencimento", t.DataValidade);



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

        public List<Estoque> List()
        {
            try
            {
                List<Estoque> list = new List<Estoque>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Estoque;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Estoque()
                    {
                        Id = reader.GetInt32("id_est"),
                        NomeProduto = reader.GetString("nome_produto_est"),
                        Codigo = reader.GetString("codigo_est"),
                        Descricao = reader.GetString("Descricao_est"),
                        Quantidade = reader.GetString("quantidade_est"),
                        DataFabricacao = reader.GetString("data_fabricacao_est"),
                        DataValidade = reader.GetString("data_validade_est"),

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

        public void Update(Estoque t)
        {
            throw new NotImplementedException();
        }
    }
}