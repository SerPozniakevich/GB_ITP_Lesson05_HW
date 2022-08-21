// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] CreateRandomtArray(int size, int min, int max)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}
Console.WriteLine("Размер массива 4.");
int size = 4;
Console.WriteLine("Заполнение случайными положительными трёхзначными числами.");
int min = 100;
int max = 1000;
int[] TreeDigitArray = CreateRandomtArray(size, min, max);
ShowArray(TreeDigitArray);
int quanteven = 0;

for (int i = 0; i < TreeDigitArray.Length; i++)
{
    if (TreeDigitArray[i] % 2 == 0)
    {
        quanteven ++;
    }

}
Console.Write($"Количество чётных чисел в массиве: {quanteven}");
