using Aula04.Models;

Customer c1 = new Customer();

c1.CustumerId = 1;
c1.FirstName = "Mauricio";
c1.LastName = "Gonzatto";
c1.BirthDate = new DateTime();
c1.EmailAddres = "mauricio.gonzatto@unoesc.edu.br";

Address address1 = new Address();
address1.AddressId = 1;
address1.Street = "Gonçalves Dias";
address1.District = "São Carlos";
address1.City = "Monte Carlo";
address1.Number = 69;
address1.FederalState = "SC";
address1.Country = "Brasil";
address1.ZipCode = "89618-000";

c1.Addresses.Add(address1);

Console.WriteLine("ENDEREÇOS:");

foreach(var ad in c1.Addresses)
{
    Console.WriteLine("------------------");
    Console.WriteLine($"Rua {ad.Street}");
    Console.WriteLine($"Bairro {ad.District}");
    Console.WriteLine($"Estado: {ad.FederalState}");

}


Console.WriteLine( $"Nome: {c1.FirstName} {c1.LastName}");
Console.WriteLine( $"Email: {c1.EmailAddres}");