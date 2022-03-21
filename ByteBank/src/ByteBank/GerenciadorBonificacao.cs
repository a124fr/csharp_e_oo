using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
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
