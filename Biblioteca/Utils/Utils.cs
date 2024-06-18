using System;


namespace Biblioteca.Utils
{
    public class Utils
    {
        public static int LerInteiro(string mensagem)
        {
            int numero;
            while (true)
            {
                Console.Write(mensagem);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    break;
                }
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }
            return numero;
        }

        public static int LerInt(string mensagem)
        {
            int valor;
            Console.Write(mensagem);
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Valor inválido. " + mensagem);
            }
            return valor;
        }

        public static void ExibirMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public static void ExibirMensagemErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}