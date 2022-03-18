using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;
            Console.WriteLine("Salário: {0}", salario);

            double valor;
            valor = 15.0 / 2;
            Console.WriteLine("Valor: {0}", valor);

            valor = 5 / 3;
            Console.WriteLine("5 / 3 = {0}", valor);

            valor = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = {0}", valor);

            

            Console.WriteLine("A execução acabou. Tecle enter para sair....");
            Console.ReadLine();
        }
    }
}
