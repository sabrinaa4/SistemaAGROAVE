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
    internal class FuncionarioDAO : IDAO<Funcionario>
    {
        // Fazer o insert, update, delete

        private static Conexao conn;

        public FuncionarioDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Funcionario t)
        {
            throw new NotImplementedException();
        }

        public Funcionario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Funcionario t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Funcionario (nome_fun, rg_fun, cpf_fun, telefone_fun, carteira_trabalho_fun, funcao_fun, setor_fun, numero_fun," +
                    "rua_fun, bairro_fun, municipio_fun, estado_fun, salario_fun) VALUES (@nome, @rg, @cpf, @telefone, @carteira_trabalho, @funcao, @setor, @numero, @rua, @bairro, @municipio, @estado, @salario)";
                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@rg", t.Rg);
                query.Parameters.AddWithValue("@cpf", t.Cpf);
                query.Parameters.AddWithValue("@telefone", t.Telefone);
                query.Parameters.AddWithValue("@carteira_trabalho", t.CarteiraTrabalho);
                query.Parameters.AddWithValue("@funcao", t.Funcao);
                query.Parameters.AddWithValue("@setor", t.Setor);
                query.Parameters.AddWithValue("@numero", t.Numero);
                query.Parameters.AddWithValue("@rua", t.Rua);
                query.Parameters.AddWithValue("@bairro", t.Bairro);
                query.Parameters.AddWithValue("@municipio", t.Municipio);
                query.Parameters.AddWithValue("@estado", t.Estado);
                query.Parameters.AddWithValue("@salario", t.Salario);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("O registo não foi inserido. Verifique e tente novamente");

                
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }
           
        }

        public List<Funcionario> List()
        {
            try
            {
                List<Funcionario> list = new List<Funcionario>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Funcionario;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Funcionario()
                    {
                        Id = reader.GetInt32("id_fun"),
                        Nome = reader.GetString("nome_fun"),
                        Rg = reader.GetString("rg_fun"),
                        Cpf = reader.GetString("cpf_fun"),
                        Telefone = reader.GetString("telefone_fun"),
                        CarteiraTrabalho = reader.GetString("carteira_trabalho_fun"),
                        Funcao = reader.GetString("funcao_fun"),
                        Setor = reader.GetString("setor_fun"),
                        Numero = reader.GetString("numero_fun"),
                        Rua = reader.GetString("rua_fun"),
                        Bairro = reader.GetString("bairro_fun"),
                        Municipio = reader.GetString("municipio_fun"),
                        Estado = reader.GetString("estado_fun"),
                        Salario = reader.GetDouble("salario_fun")
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

        public void Update(Funcionario t)
        {
            throw new NotImplementedException();
        }
    }
}
