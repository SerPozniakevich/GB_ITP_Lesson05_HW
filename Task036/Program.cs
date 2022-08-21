// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
//Console.Clear();

int[] CreateRandomArray(int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max -1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

Console.WriteLine("Задан массив из 4 элементов в диапазоне двухзначных чисел:");
int size = 4;
int min = -99;
int max = 100;
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

int sumneg = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sumneg += array[i];
    }
   
}
  Console.WriteLine($"Сумма значений нечётных индексов равна {sumneg}");