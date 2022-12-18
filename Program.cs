/* Задача 32. Напишите программу замены элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот. 
  [-4, -8, 8, 2] - > [4, 8, -8, -2]     */

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
Print(array);

for (int i = 0; i < array.Length; i++)
    array[i] = -array[i];
Print(array);

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}