using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4
{
    internal class Funcionarios : Conexao
    {
        public int id;

        public int id_empresa;

        public string nome;

        public string email;

        private string senha;

        public string  nivel;

        public DateTime data_cadastro;

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public string GetSenha()
        {
            return this.senha;
        }

        public List<Funcionarios> GetListaFuncionarios()
        {
            List<Funcionarios> funcionarios = new List<Funcionarios>();

            try
            {

                OpenConnection();

                string query = "SELECT * FROM funcionarios;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Funcionarios  novoFuncionario = new Funcionarios();

                            novoFuncionario.id = Convert.ToInt32(reader.GetString("id"));
                            novoFuncionario.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoFuncionario.nome = reader.GetString("nome");
                            novoFuncionario.email = reader.GetString("email");
                            novoFuncionario.nivel = reader.GetString("nivel");

                            novoFuncionario.SetSenha(reader.GetString("senha"));

                            funcionarios.Add(novoFuncionario);
                        }
                    }
                }


                CloseConnection();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }


            return  funcionarios;
        }
    }
}
