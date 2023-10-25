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
    internal class ClienteDAO : IDAO<Cliente>
    {

        private static Conexao conn;

        public ClienteDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Cliente t)
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Cliente t)
        {

            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Cliente (nome_cli, email_cli, cpf_cli, telefone_cli, numero_casa_cli, rua_cli, bairro_cli, municipio_cli, estado_cli) VALUES (@nome,@email,@cpf,@telefone, @numero_casa, @rua, @bairro, @municipio, @estado)";
                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@email", t.Email);
                query.Parameters.AddWithValue("@cpf", t.Cpf);
                query.Parameters.AddWithValue("@numero_casa", t.Numero);
                query.Parameters.AddWithValue("@telefone", t.Telefone);              
                query.Parameters.AddWithValue("@rua", t.Rua);
                query.Parameters.AddWithValue("@bairro", t.Bairro);
                query.Parameters.AddWithValue("@municipio", t.Municipio);
                query.Parameters.AddWithValue("@estado", t.Estado);
                

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

        public List<Cliente> List()
        {
            try
            {
                List<Cliente> list = new List<Cliente>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Cliente;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Cliente()
                    {
                        Id = reader.GetInt32("id_cli"),
                        Nome = reader.GetString("nome_cli"),
                        Email = reader.GetString("email_cli"),
                        Cpf = reader.GetString("cpf_cli"),
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

        public void Update(Cliente t)
        {
            throw new NotImplementedException();
        }



    }
}
