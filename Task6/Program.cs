// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

Console.Write("Введите целое число: ");
string A = Console.ReadLine();
int numberA = int.Parse(A);
if(numberA % 2 == 0)
{
    Console.Write("Число является четным? - ");
    Console.WriteLine("Да!");
}
else
{
    Console.Write("Число является четным? - ");
    Console.WriteLine("Нет!");
}