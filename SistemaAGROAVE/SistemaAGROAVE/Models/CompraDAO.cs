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
    internal class CompraDAO : IDAO<Compra>
    {
        private static Conexao conn;
        public CompraDAO()
        {
            conn = new Conexao();
        }
        public void Delete(Compra t)
        {
            throw new NotImplementedException();
        }

        public Compra GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Compra t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Compra (valor_com, tipo_pagamento_com, descricao_com, unidade_com, data_com, hora_com) VALUES (@valor, @tipo_pagamento, @descricao, @unidade, @data, @hora)";

                query.Parameters.AddWithValue("@valor", t.Valor);
                query.Parameters.AddWithValue("@tipo_pagamento", t.TipoPag);
                query.Parameters.AddWithValue("@descricao", t.Descricao);
                query.Parameters.AddWithValue("@unidade", t.Unidade);
                query.Parameters.AddWithValue("@data", t.Data);
                query.Parameters.AddWithValue("@hora", t.Hora);
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

        public List<Compra> List()
        {
            try
            {
                List<Compra> list = new List<Compra>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Compra;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Compra()
                    {
                        Id = reader.GetInt16("id_com"),
                        Valor = reader.GetDouble("valor_com"),
                        Descricao = reader.GetString("descricao_com"),
                        TipoPag = reader.GetString("tipo_pagamento_com"),
                        Unidade = reader.GetInt16("unidade_com"),
                        Data = reader.GetString("data_com"),
                        Hora = reader.GetString("hora_com")
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

        public void Update(Compra t)
        {
            throw new NotImplementedException();
        }
    }
}