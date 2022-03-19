using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Depositar(-10);

            Cliente cliente = new Cliente();
            cliente.CPF = "434.564.879-20";
            cliente.Nome = "Gulherme";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = -10;
            conta.Titular = cliente;
                        
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
            
            Console.ReadLine();
        }
    }
}
