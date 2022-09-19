// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

Console.Write("Введите первое число: ");
string A = Console.ReadLine();
int numberA = int.Parse(A);
Console.Write("Введите второе число: ");
string B = Console.ReadLine();
int numberB = int.Parse(B);
Console.Write("Введите третье число: ");
string C = Console.ReadLine();
int numberC = int.Parse(C);

int max = numberA;
if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);