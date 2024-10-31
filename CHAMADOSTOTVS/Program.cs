// Para teste 

using System;
using System.IO;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            // Perguntas
            Console.WriteLine($"*ATENÇÃO AOS CHAMADOS DA TOTVS* {DateTime.Now}");

            Console.Write("\n*- Data de Abertura do Chamado:* ");
            string dataAbertura = Console.ReadLine()!;

            Console.Write("*- Cliente:* ");
            string cliente = Console.ReadLine()!;

            Console.Write("*- Número do Chamado:* ");
            string numeroChamado = Console.ReadLine()!;

            Console.Write("*- Status:* ");
            string status = Console.ReadLine()!;

            Console.Write("*- Descrição:* ");
            string descricao = Console.ReadLine()!;

            Console.Write("*- Última Verificação:* ");
            string ultimaVerificacao = Console.ReadLine()!;

            Console.Write("*- Status de Verificação:* ");
            string statusVerificacao = Console.ReadLine()!;

            // Criação da string com as informações
            string chamadoInfo = $"*ATENÇÃO AOS CHAMADOS DA TOTVS* {DateTime.Now}" +
                                 $"\n*Data de Abertura:* {dataAbertura}\n" +
                                 $"*Cliente:* {cliente}\n" +
                                 $"*Número do Chamado:* {numeroChamado}\n" +
                                 $"*Status:* {status}\n" +
                                 $"*Descrição:* {descricao}\n" +
                                 $"*Última Verificação:* {ultimaVerificacao}\n" +
                                 $"*Status de Verificação:* {statusVerificacao}\n" +
                                 $"----------------------------------\n";

            // Salvar no arquivo
            File.AppendAllText(@"C:\Users\supor\Downloads\chamado.txt", chamadoInfo);

            // Exibe as respostas
            Console.WriteLine("\nResumo do Chamado:");
            Console.WriteLine(chamadoInfo);

            // Pergunta se deseja fazer novamente
            Console.Write("\nDeseja fazer um novo chamado? (s/n): ");
            string resposta = Console.ReadLine()!.ToLower();
            continuar = (resposta == "s");
        }
    }
}

