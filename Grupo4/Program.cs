using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            Funcionarios funcionarios = new Funcionarios();

            foreach(Funcionarios funcionario in funcionarios.GetListaFuncionarios())
            {
                Console.WriteLine("ID: " + funcionario.id);
                Console.WriteLine("ID_EMPRESA: " + funcionario.id_empresa);
                Console.WriteLine("NOME: " + funcionario.nome);
                Console.WriteLine("EMAIL: " + funcionario.email);
                Console.WriteLine("SENHA:  " + funcionario.GetSenha());
                Console.WriteLine("NIVEL: " + funcionario.nivel);

            }

            Console.ReadLine();
        }
    }
}
