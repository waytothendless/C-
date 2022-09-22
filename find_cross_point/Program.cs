// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте k1");
int k1=int.Parse(Console.ReadLine());
Console.WriteLine("Задайте b1");
int b1=int.Parse(Console.ReadLine());
Console.WriteLine("Задайте k2");
int k2=int.Parse(Console.ReadLine());
Console.WriteLine("Задайте b2");
int b2=int.Parse(Console.ReadLine());
Console.WriteLine("Точка пересечения:("+((float)b1*(-1.0)/(float)k1)+";"+((float)b2*(-1.0)/(float)k2)+")");