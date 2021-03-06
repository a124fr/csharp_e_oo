using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }

        private string _cpf;

        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Minha validação de CPF
                if (String.IsNullOrEmpty(_cpf))
                {
                    return;
                }

                _cpf = value;
            }
        }

        public string Profissao { get; set; }
    }
}
