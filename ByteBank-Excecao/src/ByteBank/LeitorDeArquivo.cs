using System;
using System.IO;

namespace ByteBank
{
    public class LeitorDeArquivo
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            throw new FileNotFoundException("Arquivo não encontrado!");

            //Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            //throw new IOException("Erro ao ler o arquivo!");
            return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
