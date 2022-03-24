using ByteBank.Modelos.Funcionarios;

namespace ByteBank.Modelos
{
    public class GerenciadorBonificacao
    {
        private double _totalBonficacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonficacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonficacao()
        {
            return _totalBonficacao;
        }
    }
}
