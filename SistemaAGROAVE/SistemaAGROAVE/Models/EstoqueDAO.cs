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
                query.CommandText = "INSERT INTO Fornecedor (codigo_for, nome_produto_for, quantiadade_for, descricao_for, data_fabricaçao_for, data_vencimento_for)" +
                    "VALUES (@codigo,@nome_produto,@fornecedor,@quantidade, @descricao, @data_fabricaçao, @data_vencimento)";
                query.Parameters.AddWithValue("@codigo", t.Codigo);
                query.Parameters.AddWithValue("@nome_produto", t.NomeProduto);
                query.Parameters.AddWithValue("@quantidade", t.Quantidade);
                query.Parameters.AddWithValue("@descricao", t.Descricao);
                query.Parameters.AddWithValue("@data_fabricacao", t.DataFabricacao);
                query.Parameters.AddWithValue("@data_vencimento", t.DataVencimento);



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
                query.CommandText = "SELECT * FROM Fornecedor;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Estoque()
                    {
                        Id = reader.GetInt32("id_for"),
                        Codigo = reader.GetString("codigo_for"),
                        NomeProduto = reader.GetString("nome_produro_for"),
                        Quantidade = reader.GetString("quantidade_for"),
                        Descricao = reader.GetString("Descricao_for"),
                        DataFabricacao = reader.GetString("_for"),
                        DataVencimento = reader.GetString("data_Vencimento_for"),

                    }); ;
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