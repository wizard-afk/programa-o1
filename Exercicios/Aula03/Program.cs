﻿// Operadores
int a = 3;
int b = a++; // ++ é um acumulador
//Neste caso, ++ vai somar a + 1
// Entretanto, o acúmulo vai ocorrer após a atribuíção pois o acumulador está ao lado direito de a (após a atribuíção)
Console.WriteLine($"a é {a}, b é {b}");

//----------------------------------------------------------------------------------------------------------------------
int c = 3;
int d = ++c;
Console.WriteLine($"c é {c}, d é {d}");
// Neste caso, o acumulador está ao lado esquerdo, logo o acúmulo ocorre antes da atribuíção.
//----------------------------------------------------------------------------------------------------------------------

// Combinando operadores de atribuíção
int p = 6;
p += 3;
p -= 3;
p *= 3;
p /= 3;

// Operadores lógicos
bool b_A = true;
bool b_B = false; // b_ = identificando que é booleana para facilitar depois

Console.WriteLine($"AND  | b_A   | b_B  ");
Console.WriteLine($"b_A  | {b_A & b_A, -5} | {b_A & b_B, -5}");
Console.WriteLine($"b_B  | {b_B & b_A, -5} | {b_B & b_B, -5}");
Console.WriteLine();
Console.WriteLine($"OR   | b_A   | b_B  ");
Console.WriteLine($"b_A  | {b_A | b_A, -5} | {b_A | b_B, -5}");
Console.WriteLine($"b_B  | {b_B | b_A, -5} | {b_B | b_B, -5}");
Console.WriteLine();
Console.WriteLine($"XOR  | b_A   | b_B  "); // XOR - Testa a diferença
Console.WriteLine($"b_A  | {b_A ^ b_A, -5} | {b_A ^ b_B, -5}");
Console.WriteLine($"b_B  | {b_B ^ b_A, -5} | {b_B ^ b_B, -5}");