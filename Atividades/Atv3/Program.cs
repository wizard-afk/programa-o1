using System;

internal class Program
{
    private static void Main(string[] args)
    {
        char operador = ' ';

        // Solicitar ao usuário o operador aritmético
        Console.WriteLine("Digite um operador aritmético (+, -, *, /):");
        while (operador != '+' && operador != '-' && operador != '*' && operador != '/')
        {
            operador = Convert.ToChar(Console.ReadLine());
            if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
                Console.WriteLine("Operador aritmético inválido. Por favor, digite novamente:");
        }

        // Imprimir a tabuada com base no operador aritmético
        Console.WriteLine($"Tabuada de {operador}:");
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                switch (operador)
                {
                    case '+':
                        Console.Write($"{i} + {j} = {i + j}\t");
                        break;
                    case '-':
                        Console.Write($"{i} - {j} = {i - j}\t");
                        break;
                    case '*':
                        Console.Write($"{i} * {j} = {i * j}\t");
                        break;
                    case '/':
                            Console.Write($"{i} / {j} = {(double)i / j}\t");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
