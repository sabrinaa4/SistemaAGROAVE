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
    internal class PerfilFuncionarioDAO : IDAO<PerfilFuncionario>
    {
        private static Conexao conn;

        public PerfilFuncionarioDAO()
        {
            conn = new Conexao();
        }

        public void Delete(PerfilFuncionario t)
        {
            throw new NotImplementedException();
        }

        public PerfilFuncionario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(PerfilFuncionario t)
        {

            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO Perfil_Funcionario (nome_perf, cpf_cli, telefone_cli, rg_perf, email_perf, funcao_perf, setor_perf  ) VALUES (@nome, @cpf, @telefone, @rg, @email, @funcao, @setor)";
                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@cpf", t.Cpf);
                query.Parameters.AddWithValue("@telefone", t.Telefone);
                query.Parameters.AddWithValue("@rg", t.Rg);
                query.Parameters.AddWithValue("@email", t.Email);
                query.Parameters.AddWithValue("@funcao", t.Funcao);
                query.Parameters.AddWithValue("@setor", t.Setor);


                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("O registo não foi inserido. Verifique e tente novamente!");


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

        public List<PerfilFuncionario> List()
        {
            try
            {
                List<PerfilFuncionario> list = new List<PerfilFuncionario>();

                var query = conn.Query();
                query.CommandText = "SELECT * FROM Perfil_Funcionario;";

                MySqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new PerfilFuncionario()
                    {
                        Id = reader.GetInt32("id_perf"),
                        Nome = reader.GetString("nome_perf"),
                        Cpf = reader.GetString("cpf_perf"),
                        Telefone = reader.GetString("telefone_perf"),
                        Rg = reader.GetString("rg_perf"),
                        Email = reader.GetString("email_perf"),
                        Funcao = reader.GetString("funcao_perf"),
                        Setor = reader.GetString("setor_perf"),
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

        public void Update(PerfilFuncionario t)
        {
            throw new NotImplementedException();
        }
    }
}
