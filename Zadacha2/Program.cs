//Задача 2
Console.WriteLine("Введите значение a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b: ");
int b = int.Parse(Console.ReadLine());
if (a < b)
{
Console.WriteLine("max = b");
Console.WriteLine("min = a");
}
if (a > b)
{
Console.WriteLine("max = a");
Console.WriteLine("min = b");
}