using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public static class Utils
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
