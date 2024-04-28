using Atv4.Models;

//primeira clinica
Clinica c1 = new Clinica();
c1.InstanceCount = 1;
c1.ObjectCount = 1;

Clinica c2 = new clinica();
Clinica.InstanceCount++;
c2.ObjectCount = 10;

Console.WriteLine($"Valor C1: {c1.ObjectCount}");
Console.WriteLine($"Instance Count: {Clinica.InstanceCount}");
Console.WriteLine($"Valor C2: {c2.ObjectCount}");
