
namespace _07_ByteBank
{

    public class ContaCorrente
    {
        public Cliente Titular { get; set; }


        private int _agencia;

        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; set; }        

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

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor || _saldo <= 0)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public bool Trasnferir(double valor, ContaCorrente contaDestino)
        {
            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);
                return true;
            }

            return false;
        }
    }
}