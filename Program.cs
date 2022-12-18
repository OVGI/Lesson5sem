/* Задача 33. Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.  */
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
    Console.Write($"{array[i]} ");
}
int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

int s = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == a)
    {
        Console.Write($"Да");
        break;
    }
    s = s + 1;
}
if (s == array.Length)
    Console.Write($"Нет");
