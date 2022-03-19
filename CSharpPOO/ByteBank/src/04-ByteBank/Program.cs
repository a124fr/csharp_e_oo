using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Saldo: " + contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(500.0);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine("Saldo: " + contaDoBruno.saldo);

            contaDoBruno.Depositar(500.0);
            Console.WriteLine("Saldo: " + contaDoBruno.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);

            bool resultadoTransferencia = contaDoBruno.Trasnferir(200, contaDaGabriela);

            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);

            Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
