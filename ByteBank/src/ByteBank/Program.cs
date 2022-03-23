using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculaBonificacao();            
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("159.753.398-04")
            {
                Nome = "Roberta",
                Senha = "123"
            };

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89")
            {
                Nome = "Camila",
                Senha = "abc"
            };

            ParceiroComercial parceiroComercial = new ParceiroComercial()
            {
                Senha = "123456"
            };

            sistemaInterno.Logar(roberta, "123");            
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiroComercial, "123456");
        }

        public static void CalculaBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-21")
            {
                Nome = "Guilherme da Silva"
            };
                       
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificação do mês " +
                    gerenciadorBonificacao.GetTotalBonficacao()
            );
        }

    }
}
