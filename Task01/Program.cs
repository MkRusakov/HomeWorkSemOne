//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2) {Console.Write("Максимальное: " + number1 + "; Минимальное: " + number2);}
else if (number1 == number2) {Console.Write("Числа равны");}
else {Console.Write("Максимальное: " + number2 + "; Минимальное: " + number1);}
