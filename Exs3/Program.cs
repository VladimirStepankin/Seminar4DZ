/*Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
 Вывод сделать отдельным методом*/

int number = ReadInt("Введите длинну массива: ");

int[] array = new int[number];

FillArray(array);
PrintArray(array);

void FillArray(int[] coll)
{
    int lenght = coll.Length;
    int index = 0;
    while (index < lenght)
    {
        coll[index] = new Random().Next(0, 100);
        index++;
    }
}
void PrintArray(int[] collect)
{
    int count = collect.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(collect[position] + " ");
        position++;
    }
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}