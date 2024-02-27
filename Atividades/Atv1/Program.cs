using System;

string nome = string.Empty;
Console.WriteLine( " Qual é o seu nome?");
nome = Console.ReadLine();

string nasc = string.Empty;
Console.WriteLine( " Qual sua data de nascimento");
nasc = Console.ReadLine();

string endereco = string.Empty;
Console.WriteLine( "Qual seu endereço?");
endereco = Console.ReadLine();

string email = string.Empty;
Console.WriteLine( " Qual seu e-mail?");
email = Console.ReadLine();

string resultado = $" Nome: {nome} \n Nasc: {nasc} ";
Console.WriteLine(resultado);