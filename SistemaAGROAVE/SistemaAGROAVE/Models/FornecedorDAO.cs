using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAGROAVE.Interface;
using SistemaAGROAVE.DataBase;
using MySql.Data.MySqlClient;

namespace SistemaAGROAVE.Models
{
    internal class FornecedorDAO : IDAO<Fornecedor>
    {
        private static Conexao conn;

        public FornecedorDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Fornecedor t)
        {
            throw new NotImplementedException();
        }

        public Fornecedor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Fornecedor t)
        {


            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Fornecedor (nome_fantasia_for, razao_social_for, cnpj_for, telefone_for,email_for, numero_for, rua_for, bairro_for, municipio_for, estado_for)" +
                    "VALUES (@nome_fantasia,@razao_social,@cnpj,@telefone, @email, @numero, @rua, @bairro, @municipio, @estado)";
                query.Parameters.AddWithValue("@nome_fantasia", t.NomeFantasia);
                query.Parameters.AddWithValue("@razao_social", t.RazaoSocial);
                query.Parameters.AddWithValue("@cnpj", t.Cnpj);
                query.Parameters.AddWithValue("@telefone", t.Telefone);
                query.Parameters.AddWithValue("@email", t.Email);
                query.Parameters.AddWithValue("@numero", t.Numero);
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

        public List<Fornecedor> List()
        {
            try
            {
                List<Fornecedor> list = new List<Fornecedor>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Fornecedor;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Fornecedor()
                    {
                        Id = reader.GetInt32("id_for"),
                        NomeFantasia = reader.GetString("nome_fantasia_for"),
                        RazaoSocial = reader.GetString("razao_social_for"),
                        Cnpj = reader.GetString("cnpj_for"),
                        Telefone = reader.GetString("telefone_for"),
                        Email = reader.GetString("email_for"),
                        Numero = reader.GetString("numero_for"),
                        Rua = reader.GetString("rua_for"),
                        Bairro = reader.GetString("bairro_for"),
                        Municipio = reader.GetString("municipio_for"),
                        Estado = reader.GetString("estado_for")
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

        public void Update(Fornecedor t)
        {
            throw new NotImplementedException();
        }
    }
}
