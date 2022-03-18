using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*");

                    if (coluna >= linha)
                    {
                        break;
                    }
                }

                Console.WriteLine();
            }

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
