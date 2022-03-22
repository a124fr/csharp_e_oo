using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        // 4000,00
        public GerenteDeConta(string cpf) 
            : base(4000.0, cpf)
        {}

        public override void AumentarSalario()
        {
            Salario *= 1.05; 
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
