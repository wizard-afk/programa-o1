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

//substituindo conteúdo de strings
string nomeCompleto = "Mauricio Roberto Gonzatto";
nomeCompleto = nomeCompleto.Replace("Roberto", "Dalua");
Console.WriteLine(nomeCompleto);

// Comparação de strings
bool isNomeEqual = (nomeCompleto == "Mauricio Roberto Gonzatto");

bool isNomeEqual2 = string.Equals(nomeCompleto, "Mauricio Roberto Gonzatto");

Console.WriteLine($"Primeiro resultado: {isNomeEqual}");
Console.WriteLine($"Segundo resultado: {isNomeEqual2}");

//Tipos númericos
/*
    sbyte: Armazena valores entre -128 e 127
    short: Armazena valores entre -32,768 e 32,767
    int:  Armazena valores entre -2,147,483,648 e 2,147,483,647
    long:  Armazena valores entre -9,223,372,036,854,775,808 e -9,223,372,036,854,775,807
*/

float myFloat = 10.0f;
double myDouble = 5d;
decimal myDecimal = 7m;
int myInteger = 0;
