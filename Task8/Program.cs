// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();

Console.Write("Введите целое число: ");
string A = Console.ReadLine();
int numberA = int.Parse(A);

int i = 2;
while (i <= numberA)
{
    Console.Write(i);
    Console.Write(" ");
    i = i + 2;
}
if (numberA <= 1)
{
   Console.Write("Неверное значение!");
}