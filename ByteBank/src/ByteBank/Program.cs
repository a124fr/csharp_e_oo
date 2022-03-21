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

            Funcionario carlos = new Funcionario(2000.0,"546.879.157-20");
            carlos.Nome = "Carlos";                        
            carlos.AumentarSalario();
            Console.WriteLine("Novo Salário de Carlos: " + carlos.Salario);

            Diretor roberta = new Diretor(5000.0, "454.658.148-30");
            roberta.Nome = "Roberta";                        
            roberta.AumentarSalario();

            //roberta.Salario = 2000.0; Não é permitido pois é protegido, publico para classe e seus filhos, mas para fora, outras clsase é privado.
            Console.WriteLine("Novo Salário de Roberta: " + roberta.Salario);



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
