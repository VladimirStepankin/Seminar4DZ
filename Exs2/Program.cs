/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе*/

int number = ReadInt("Введите число: ");

int sum = 0;

while (number > 0) 
{
    int digit = number % 10;
    sum += digit;
    number = number / 10;
}

Console.Write($"Сумма цифр равна {sum}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}