// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

Console.WriteLine("Введите количество элементов в массиве");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайного диапазона");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите последее число случайного диапазона");
int max = int.Parse(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
Console.WriteLine($"[{String.Join(",",array)}]");
int max_num = array[0];
int min_num = array[0];

for (int i = 1; i < size - 1; i++) //начинаем с i = 1 так как i =0 присвоено переменным.
{
    if (array[i] > max_num)
 {
    max_num = array[i];
 }
 else if (array[i] < min_num)
 {
    min_num = array[i];
 }

   
}    
Console.WriteLine($"Максимальное число в массиве: {max_num}, минимальное: {min_num}");