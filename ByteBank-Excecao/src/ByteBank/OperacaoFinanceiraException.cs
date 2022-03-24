using System;

namespace ByteBank
{
    public class OperacaoFinanceiraException : ApplicationException
    {
        public OperacaoFinanceiraException()
        { }

        public OperacaoFinanceiraException(string mensagem)
            : base(mensagem)
        { }

        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        { }
    }
}
