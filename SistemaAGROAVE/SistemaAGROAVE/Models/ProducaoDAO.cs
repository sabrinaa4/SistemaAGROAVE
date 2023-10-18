using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAGROAVE.DataBase;
using SistemaAGROAVE.Interface;
using MySql.Data.MySqlClient;

namespace SistemaAGROAVE.Models
{
    internal class ProducaoDAO : IDAO<Producao>
    {
        private static Conexao conn;

        public ProducaoDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Producao t)
        {
            throw new NotImplementedException();
        }

        public Producao GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Producao t)
        {

            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Producao (nome_pro, quantidade_pro, data_pro, descricao_pro, producao_diaria_pro, producao_semanal_pro, producao_mensal_pro, producao_esperada_pro, producao_real_pro)" +
                    "VALUES (@nome,@quantidade,@data,@descricao, @ProducaoDiaria, @ProducaoSemanal, @producaoMensal, @producaoEsperada, @producaoReal)";
                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@quantidade", t.Quantidade);
                query.Parameters.AddWithValue("@data", t.Data);
                query.Parameters.AddWithValue("@descricao", t.Descricao);
                query.Parameters.AddWithValue("@producaoDiaria", t.ProducaoDiaria);
                query.Parameters.AddWithValue("@producaoSemanal", t.ProducaoSemanal);
                query.Parameters.AddWithValue("@producaoMensal", t.ProducaoMensal);
                query.Parameters.AddWithValue("@producaoEsperada", t.ProducaoEsperada);
                query.Parameters.AddWithValue("@producaoReal", t.ProducaoReal);


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

        public List<Producao> List()
        {
            try
            {
                List<Producao> list = new List<Producao>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Producao;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Producao()
                    {
                        Id = reader.GetInt32("id_pro"),
                        Nome = reader.GetString("nome_pro"),
                        Quantidade = reader.GetString("quantidade_pro"),
                        Data = reader.GetString("data_pro"),
                        Descricao = reader.GetString("descricao_pro"),
                        ProducaoDiaria = reader.GetString("producao_diaria_pro"),
                        ProducaoSemanal = reader.GetString("producao_semanal_pro"),
                        ProducaoMensal = reader.GetString("producao_mensal_pro"),
                        ProducaoEsperada = reader.GetString("producao_esperada_pro"),
                        ProducaoReal = reader.GetString("producao_real_pro")
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

        public void Update(Producao t)
        {
            throw new NotImplementedException();
        }
    }
}
