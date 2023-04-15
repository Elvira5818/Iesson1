//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.//

Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);
int b = int.Parse(userInput2);


if (a > b)
{ 
    Console.WriteLine($" Максимальное число {a}, минимальное число {b}");
}
else
{
    Console.WriteLine($" Максимальное число {b}, минимальное число {a}");
}
