///Задача 4
Console.WriteLine("Введите значение a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение c: ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);