// Задача 32 

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
Print(array);

Invers(array);

Print(array);

void Invers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)

        arr[i] = -arr[i];
}


void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}