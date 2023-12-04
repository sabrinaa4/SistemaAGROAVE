using System;
using System.Collections.Generic;
using SistemaAGROAVE.DataBase;
using SistemaAGROAVE.Interface;
using SistemaAGROAVE.Models;
using MySql.Data.MySqlClient;

namespace SistemaAGROAVE.Models
{
    internal class EntregaDAO : IDAO<Entrega>
    {
        private static Conexao conn;
        public EntregaDAO()
        {
            conn = new Conexao();
        }
        public void Delete(Entrega t)
        {
            throw new NotImplementedException();
        }

        public Entrega GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Entrega t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Entrega (nome_ent, status_ent, taxa_ent, valor_troco_ent, hora_ent, numero_casa_ent, rua_ent, bairro_ent, municipio_ent, estado_ent, id_fun_fk) VALUES (@nome, @status, @taxa, @valor_troco, @hora, @numero_casa, @rua, @bairro, @municipio, @estado, @id_fun_fk)";

                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@status", t.Status);
                query.Parameters.AddWithValue("@taxa", t.Taxa);
                query.Parameters.AddWithValue("@valor_troco", t.ValorTroco);
                query.Parameters.AddWithValue("@hora", t.Hora);
                query.Parameters.AddWithValue("@numero_casa", t.NumCasa);
                query.Parameters.AddWithValue("@rua", t.Rua);
                query.Parameters.AddWithValue("@bairro", t.Bairro);
                query.Parameters.AddWithValue("@municipio", t.Municipio);
                query.Parameters.AddWithValue("@estado", t.Estado);
                query.Parameters.AddWithValue("@id_fun_fk", t.IdFunc);
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

        public List<Entrega> List()
        {
            try
            {
                List<Entrega> list = new List<Entrega>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Entrega;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Entrega()
                    {
                        Id = reader.GetInt16("id_ent"),
                        Nome = reader.GetInt32("nome_ent"),
                        Status = reader.GetString("status_ent"),
                        Taxa = reader.GetString("taxa_ent"),
                        ValorTroco = reader.GetString("valor_troco_ent"),
                        Hora = reader.GetDouble("hora_ent"),
                        NumCasa = reader.GetDouble("numero_casa_ent"),
                        Rua = reader.GetDouble("rua_ent"),
                        Bairro = reader.GetDouble("bairro_ent"),
                        Municipio = reader.GetDouble("municipio_ent"),
                        Estado = reader.GetDouble("estado_ent"),
                        IdFunc = reader.GetDouble("id_fun_fk"),

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

        public void Update(Entrega t)
        {
            throw new NotImplementedException();
        }

    }
}
