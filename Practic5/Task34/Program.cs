// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int size = 4;
int[] array = new int[size];
int minvalue = 100;
int maxvalue = 1000;
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minvalue, maxvalue);


    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.Write("[");
Console.Write(string.Join(",", array));
Console.Write("]=>");

Console.WriteLine(count);