using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : ApplicationException
    {
        public  double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException() {}           

        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {
            // Faça a inicialização de algum campo ou propriedade
        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("tentativa de saque do valor de R$" + valorSaque + " em uma conta com saldo de R$" + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}
