﻿
namespace _05_ByteBank
{

    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100.0;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor || this.saldo <= 0)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
            }
        }

        public bool Trasnferir(double valor, ContaCorrente contaDestino)
        {
            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true;
            }

            return false;
        }
    }
}