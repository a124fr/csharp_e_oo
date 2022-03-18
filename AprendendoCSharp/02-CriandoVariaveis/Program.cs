using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 02 - Criando Variávies");

            int idade;
            idade = 32;
            Console.WriteLine("Idade: {0}", idade);

            idade = 10;
            Console.WriteLine("Idade: {0}", idade);
            idade = 10 + 5;
            Console.WriteLine("Idade: {0}", idade);

            idade = 10 + 5 * 2;
            Console.WriteLine("Idade: {0}", idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua Idade é: " + idade + "!");

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
