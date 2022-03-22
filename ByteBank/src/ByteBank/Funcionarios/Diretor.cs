﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public Diretor(string cpf) 
            : base(5000.0, cpf)
        {}

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
