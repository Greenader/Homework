// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int size = 5;
double[] array = new double[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
Console.WriteLine();
Console.Write("[");
Console.Write(string.Join(",", array));
Console.Write("] => ");
double maxValue = array.Max<double>();
double minValue = array.Min<double>();
double result = maxValue - minValue;
Console.Write($"Разница максимального и минимального элементов массива = {result}");


