using System;
using System.Diagnostics;

//trabalhando com variaveis

//strings
//Declarando variável sem inicialização
string message1 = null;

// Inicializar a variável com nulo
string message2 = null;

// Inicializar a string vazia 
string message3 = System.String.Empty; //"";

// Declarar uma string com valor implícito
var message4 = "MESSAGE RANDON"; 

Console.WriteLine( message4 );

// Concatenando Strings
string concat = ( message1 == null ? "" : message1) //if ternario
+ " " + message2 + " " + message3 + " " + message4;

Console.WriteLine( "\n" + concat); //\n deixa bonitinho

Console.WriteLine( "A temperatura hoje {0:D} é {1}°C", DateTime.Now, 23);
//ConsoleTraceListener

string nome = string.Empty;
Console.WriteLine( " Qual é o seu nome?");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de jaguarice!";
Console.WriteLine(resultado); 

//esse comentário foi feito na aula 03