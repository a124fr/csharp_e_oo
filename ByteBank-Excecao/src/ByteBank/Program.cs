using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(83930, 788545);
                conta.Depositar(50);
                //Console.WriteLine(conta.Saldo);
                //conta.Sacar(-500);
                //Console.WriteLine(conta.Saldo);

                ContaCorrente conta2 = new ContaCorrente(83930, 494949);
                conta2.Depositar(50);
                //conta2.Trasnferir(-500, conta);
                conta2.Trasnferir(100500, conta);
            }
            catch(SaldoInsuficienteException e)
            {
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Argumento com problema: " + e.ParamName + ". ");                 
                Console.WriteLine(e);
            }
            catch (Exception e)
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
