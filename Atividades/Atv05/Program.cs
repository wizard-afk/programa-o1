using System.Runtime.Intrinsics.Arm;
using Atv05.Models;

bool aux = true;
do {

    Console.WriteLine("**********************");
    Console.WriteLine("MEU POGRAMA DE PIDIDUX");
    Console.WriteLine("**********************");
    Console.WriteLine();

    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Produtos");
    Console.WriteLine("3 - Pedidos");
    Console.WriteLine("0 - Sair")

    int menu = 0;
    try
    {
            switch(menu)
        {
            case 1;
            break;
        }

    }
    catch
    {
        Console.WriteLine("Opção Invalida.")
        aux = true;
    }

}while(aux);

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Jaguara";
c1.EmailAddress = "jaguara@pixote.net";

Customer c2 = new Customer(2);
c1.Name = "Boca-Mole";
c1.EmailAddress = "jbocamole@pixote.net";

// constructor que simula object, construtor por instanciação e atribuição
Customer c3 = new Customer{
    CustomerId = 3,
    Name = "Nerso",
    EmailAddress = "nerso@pixote.com"
};