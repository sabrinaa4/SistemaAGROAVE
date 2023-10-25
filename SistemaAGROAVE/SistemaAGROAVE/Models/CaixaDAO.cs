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
    internal class CaixaDAO : IDAO<Caixa>
    {
        private static Conexao conn;
        public CaixaDAO()
        {
            conn = new Conexao();
        }
       
        public void Delete(Caixa t)
        {
            throw new NotImplementedException();
        }

        public Caixa GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Caixa t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Caixa (numero_cai, data_cai, horario_abertura_cai, horario_fechamento_cai, valor_inicial_cai, valor_final_cai) VALUES (@numero, @data, @horario_abertura, @ horario_fechamento, @valor_inicial, @valor_final)";

                query.Parameters.AddWithValue("@numero", t.Numero);
                query.Parameters.AddWithValue("@data", t.Data);
                query.Parameters.AddWithValue("@horario_abertura", t.HoraAbertura);
                query.Parameters.AddWithValue("@horario_fechamento", t.HoraFechamento);
                query.Parameters.AddWithValue("@valor_inicial", t.ValorInicial);
                query.Parameters.AddWithValue("@valor_final", t.ValorFinal);
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

        public List<Caixa> List()
        {
            try
            {
                List<Caixa> list = new List<Caixa>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Caixa;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Caixa()
                    {
                        Id = reader.GetInt32("id_cai"),
                        Numero = reader.GetInt32("numero_cai"),
                        Data = reader.GetString("data_cai"),
                        HoraAbertura = reader.GetString("horario_abertura_cai"),
                        HoraFechamento = reader.GetString("horario_fechamento_cai"),
                        ValorInicial = reader.GetDouble("valor_inicial_cai"),
                        ValorFinal = reader.GetDouble("valor_final_cai")
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

        public void Update(Caixa t)
        {
            throw new NotImplementedException();
        }
      
    }
}
