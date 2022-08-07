//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3) {Console.Write("Максимальное: " + number1);}
else if (number2 > number1 && number2 > number3) {Console.Write("Максимальное: " + number2);}
else {Console.Write("Максимальное: " + number3);}