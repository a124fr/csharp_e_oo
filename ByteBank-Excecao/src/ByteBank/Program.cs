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
            try
            {
                ContaCorrente conta = new ContaCorrente(83930, 788545);
                ContaCorrente conta2 = new ContaCorrente(0, 0);
            }
             catch(Exception e)
            {
                Console.WriteLine(e);
            }                       

            Console.ReadLine();
        }

        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
            //TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {                
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {                
                Console.WriteLine("Exceção com numero igual a " + numero + " e divosor igual a " + divisor);
                // A instrução throw;, dentro de um bloco catch, relança uma exceção.
                throw; // Passa a exceção para frente. 
            }
        }
    }
}
