internal class Program
{
    private static void Main(string[] args)
    {
        double numero1 = 0;
        double numero2 = 0;

        Console.WriteLine("Digite o primeiro número");
        while (!double.TryParse(Console.ReadLine(), out numero1)) //out retorna valor
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro:");
        }

        Console.WriteLine("Digite o segundo número");
        while (!double.TryParse(Console.ReadLine(), out numero2))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro:");
        }

        Console.WriteLine("Escolha uma opção da seguinte lista:");
        Console.WriteLine("\tadd - Adicionar");
        Console.WriteLine("\tsub - Subtrair");
        Console.WriteLine("\tmul - Multiplicar");
        Console.WriteLine("\tdiv - Dividir");
        Console.WriteLine("\tClique em qualquer tecla para sair");

        switch (Console.ReadLine())
        {
            case "add":
                Console.WriteLine($"Seu resultado: {numero1} + {numero2} = " + (numero1 + numero2));
                break;
            case "sub":
                Console.WriteLine($"Seu resultado: {numero1} - {numero2} = " + (numero1 - numero2));
                break;
            case "mul":
                Console.WriteLine($"Seu resultado: {numero1} * {numero2} = " + numero1 * numero2);
                break;
            case "div":
                Console.WriteLine($"Seu resultado: {numero1} / {numero2} = " + numero1 / numero2);
                break;
            default:
                break;

        };
    }
}