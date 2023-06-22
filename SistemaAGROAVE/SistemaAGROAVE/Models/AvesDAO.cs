using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAGROAVE.DataBase;
using SistemaAGROAVE.Interface;

namespace SistemaAGROAVE.Models
{
    internal class AvesDAO : IDAO<Aves>
    {
        private static Conexao conn;

        public AvesDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Aves t)
        {
            throw new NotImplementedException();
        }

        public Aves GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Aves> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Aves t)
        {
            throw new NotImplementedException();
        }

        public void Insert(Aves t)
        {

            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Cliente (observacoes_ave, cor_identificacao_ave, quant_obito_ave, raca_ave, data_entrada_ave, lote_ave, numero_galpao_ave)" +
                    "VALUES (@observacoes,@cor_identificacao,@quant_obito,@raca, @data_entrada, @lote, @numero_galpao)";
                query.Parameters.AddWithValue("@observacoes", t.Observacoes);
                query.Parameters.AddWithValue("@cor_identificacao", t.CorIdentificacao);
                query.Parameters.AddWithValue("@quant_obito", t.QuantObito);
                query.Parameters.AddWithValue("@raca", t.Raca);
                query.Parameters.AddWithValue("@data_entrada", t.DataEntrada);
                query.Parameters.AddWithValue("@lote", t.Lote);
                query.Parameters.AddWithValue("@numero_galpao", t.NumeroGalpao);
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

        internal static void Insert(Views.Aves aves)
        {
            throw new NotImplementedException();
        }
    }
}
