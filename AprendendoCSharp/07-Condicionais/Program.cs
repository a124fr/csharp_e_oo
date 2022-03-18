using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("É maior de idade...Pode Entrar");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não é maior de idade, mas está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("João não é maior de idade, não pde entrar");
                }
            }

            Console.ReadLine();
        }
    }
}
