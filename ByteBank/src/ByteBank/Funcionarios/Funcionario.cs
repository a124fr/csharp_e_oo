using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string CPF { get; private set; }
        public string Nome { get; set; }                
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        //Um construtor pode chamar outro construtor da própria classe com o uso da palavra reservada "this"
        //public Funcionario(string cpf)
        //    : this(0.0, cpf)
        //{}

        //public virtual void AumentarSalario()
        //{
        //    Salario *= 1.1;
        //}
        public abstract void AumentarSalario();

        //public virtual double GetBonificacao()
        //{
        //    return Salario * 0.10;
        //} 
        public abstract double GetBonificacao();
    }
}
