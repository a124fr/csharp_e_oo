﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : ApplicationException
    {
        public SaldoInsuficienteException() {}           

        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {}
    }
}
