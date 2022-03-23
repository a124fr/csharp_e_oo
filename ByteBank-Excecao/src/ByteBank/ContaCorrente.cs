﻿
using System;

namespace ByteBank
{

    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public int Agencia { get; }

        public int Numero { get; }

        private double _saldo = 100.0;

        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public static int TotalDeContasCriadas { get; private set; }

        public static double TaxaOperacao { get; private set; }

        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            if (numeroAgencia <= 0)
            {
                throw new ArgumentException("O argumento numnero da agência deve ser maior do que 0", nameof(numeroAgencia));
            }

            if (numeroConta <= 0)
            {
                throw new ArgumentException("O argumento número da conta deve ser maior do que 0", nameof(numeroConta));
            }

            Agencia = numeroAgencia;
            Numero = numeroConta;

            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if (_saldo <= 0)
            {
                throw new ArgumentException("O paremetro valor deve ser positivo", nameof(valor));
            }

            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para o saque no valor de R$" + valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public void Trasnferir(double valor, ContaCorrente contaDestino)
        {
            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}