using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaAGROAVE.DataBase;
using SistemaAGROAVE.Interface;

namespace SistemaAGROAVE.Models
{
    internal class ClienteJuridicoDAO : IDAO<ClienteJuridico>
    {
        private static Conexao conn;

        public ClienteJuridicoDAO()
        {
            conn = new Conexao();
        }

        public void Delete(ClienteJuridico t)
        {
            throw new NotImplementedException();
        }

        public ClienteJuridico GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ClienteJuridico t)
        {

            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Cliente_Juridico (nome_fantasia_clij, email_clij, cnpj_clij, telefone_clij, numero_casa_clij, rua_clij, bairro_clij, municipio_clij, estado_clij)" +
                    "VALUES (@nome_fantasia,@email,@cnpj,@telefone, @numero_casa, @rua, @bairro, @municipio, @estado)";
                query.Parameters.AddWithValue("@nome_fantasia", t.NomeFantasia);
                query.Parameters.AddWithValue("@email", t.Email);
                query.Parameters.AddWithValue("@cnpj", t.Cnpj);
                query.Parameters.AddWithValue("@numero_casa", t.Numero);
                query.Parameters.AddWithValue("@telefone", t.Telefone);
                query.Parameters.AddWithValue("@rua", t.Rua);
                query.Parameters.AddWithValue("@bairro", t.Bairro);
                query.Parameters.AddWithValue("@municipio", t.Municipio);
                query.Parameters.AddWithValue("@estado", t.Estado);


                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("O registo não foi inserido. Verifique e tente novamente.");


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

        public List<ClienteJuridico> List()
        {
            try
            {
                List<ClienteJuridico> list = new List<ClienteJuridico>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Cliente_Juridico;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new ClienteJuridico()
                    {
                        Id = reader.GetInt32("id_clij"),
                        NomeFantasia = reader.GetString("nome_fantasia_clij"),
                        Email = reader.GetString("email_clij"),
                        Cnpj = reader.GetString("cnpj_clij"),
                        Telefone = reader.GetString("telefone_clij"),
                        Numero = reader.GetInt32("numero_casa_clij"),
                        Rua = reader.GetString("rua_clij"),
                        Bairro = reader.GetString("bairro_clij"),
                        Municipio = reader.GetString("municipio_clij"),
                        Estado = reader.GetString("estado_clij")
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

        public void Update(ClienteJuridico t)
        {
            throw new NotImplementedException();
        }
    }
}
