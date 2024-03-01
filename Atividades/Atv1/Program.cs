using System;

class Program
{
    static void Main(string[] args)
    {
        string nome = string.Empty;
        Console.WriteLine("Nome:");
        nome = Console.ReadLine();

        string email = string.Empty;
        Console.WriteLine("E-mail:");
        email = Console.ReadLine();

        string nasc = string.Empty;
        Console.WriteLine("Data de nascimento:");
        nasc = Console.ReadLine();

        string genero = string.Empty;
        Console.WriteLine("Sexo ou gênero:");
        genero = Console.ReadLine();

        string cep = string.Empty;
        Console.WriteLine("CEP:");
        cep = Console.ReadLine();

        string rua = string.Empty;
        Console.WriteLine("Rua:");
        rua = Console.ReadLine();

        string numero = string.Empty;
        Console.WriteLine("Número:");
        numero = Console.ReadLine();

        string bairro = string.Empty;
        Console.WriteLine("Bairro:");
        bairro = Console.ReadLine();

        string cidade = string.Empty;
        Console.WriteLine("Cidade:");
        cidade = Console.ReadLine();

        string uf = string.Empty;
        Console.WriteLine("UF:");
        uf = Console.ReadLine();

        string pais = string.Empty;
        Console.WriteLine("País:");
        pais = Console.ReadLine();

        Console.WriteLine("\n+-------------------------------------+");
        Console.WriteLine("|           Informações Finais         |");
        Console.WriteLine("+-------------------------------------+");

        Console.WriteLine("+---------------------+----------------+");
        Console.WriteLine("|      Informação     |      Dados     |");
        Console.WriteLine("+---------------------+----------------+");
        Console.WriteLine($"| Nome                | {nome,-15} |");
        Console.WriteLine($"| E-mail              | {email,-15} |");
        Console.WriteLine($"| Data de nascimento  | {nasc,-15} |");
        Console.WriteLine($"| Sexo ou gênero      | {genero,-15} |");
        Console.WriteLine($"| CEP                 | {cep,-15} |");
        Console.WriteLine($"| Rua                 | {rua,-15} |");
        Console.WriteLine($"| Número              | {numero,-15} |");
        Console.WriteLine($"| Bairro              | {bairro,-15} |");
        Console.WriteLine($"| Cidade              | {cidade,-15} |");
        Console.WriteLine($"| UF                  | {uf,-15} |");
        Console.WriteLine($"| País                | {pais,-15} |");
        Console.WriteLine("+---------------------+----------------+");
    }
    
}
