// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным//

Console.Write("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";

int a = int.Parse(userInput1);

if ((a % 2) == 0)
{ 
    Console.WriteLine($" Число четное");
}

else
{
    Console.WriteLine($" Число нечетное ");
}


