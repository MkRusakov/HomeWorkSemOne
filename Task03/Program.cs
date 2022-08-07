//Напишите программу, которая на вход принимает число и выдаёт, является ли число 
//чётным.
Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1%2==0) {Console.Write("Четное");}
else {Console.Write("Нечетное");}