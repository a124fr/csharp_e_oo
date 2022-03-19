
namespace _06_ByteBank
{

    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular
        {
            get
            {
                return _titular;
            }

            set
            {
                _titular = value;
            }
        }

        public int agencia;
        public int numero;
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