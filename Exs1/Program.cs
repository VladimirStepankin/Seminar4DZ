/*Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.*/

int number = ReadInt("Введите первое число: ");
int extent = ReadInt("Введите второе число: ");
int i = 0;
int prod = 1;
while (i < extent)
{
    prod = prod * number;
    i++;
}
Console.Write($"{number} в степени {extent} равно {prod}");
    int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }