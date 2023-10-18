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
                query.CommandText = "INSERT INTO ClienteJuridico (nomeFantasia_cli, email_cli, cnpj_cli, telefone_cli, numero_casa_cli, rua_cli, bairro_cli, municipio_cli, estado_cli)" +
                    "VALUES (@nomeFantasia,@email,@cnpj,@telefone, @numero_casa, @rua, @bairro, @municipio, @estado)";
                query.Parameters.AddWithValue("@nomeFantasia", t.NomeFantasia);
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
                query.CommandText = "SELECT * FROM ClienteJuridico;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new ClienteJuridico()
                    {
                        Id = reader.GetInt32("id_cli"),
                        NomeFantasia = reader.GetString("nomeFantasia_cli"),
                        Email = reader.GetString("email_cli"),
                        Cnpj = reader.GetString("cnpj_cli"),
                        Telefone = reader.GetString("telefone_cli"),
                        Numero = reader.GetInt32("numero_casa_cli"),
                        Rua = reader.GetString("rua_cli"),
                        Bairro = reader.GetString("bairro_cli"),
                        Municipio = reader.GetString("municipio_cli"),
                        Estado = reader.GetString("estado_cli")
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
