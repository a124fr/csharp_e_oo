using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("546.879.157-20");
            carlos.Nome = "Carlos";            
            carlos.Salario = 2000;

            Diretor roberta = new Diretor("454.658.148-30");
            roberta.Nome = "Roberta";            
            roberta.Salario = 5000;
                        
            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total Bonificacão: " + gerenciador.GetTotalBonficacao());

            Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);

            Console.ReadLine();
        }
    }
}
