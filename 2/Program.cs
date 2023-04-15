//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.//
Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
Console.Write("Введите Третье число: ");
string userInput3 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);
int b = int.Parse(userInput2);
int c = int.Parse(userInput3);
int max = a;

if (max < b)
{ 
   max = b;
}

if (max < c)
{ 
   max = c;
}

    Console.WriteLine($" {a} {b} {c} -> {max}");
