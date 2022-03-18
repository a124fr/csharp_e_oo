using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;
            Console.WriteLine("Salário: {0}", salario);

            int salarioEmInteiro = (int)salario; // type cast
            Console.WriteLine("Salário em inteiro: {0}", salarioEmInteiro);

            // Outros tipos númericos
            // 32 bits
            int idade = 26;
            Console.WriteLine(idade);

            // 64 bits
            long valorDoUniverso = 13000000000;
            Console.WriteLine(valorDoUniverso);

            // 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
