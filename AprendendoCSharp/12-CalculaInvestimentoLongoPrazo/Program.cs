using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000.0;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("Após " + contadorMes + " mês, você terá R$" + valorInvestido);
                }

                fatorRendimento += 0.0010;
            }

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);
            Console.ReadLine();
        }
    }
}
