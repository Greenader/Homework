// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите 8 элементов через 'Enter': ");
int[] nums = new int[8];
for (int i = 0; i < 8; i++)
{
    nums[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nВведенный массив : [ ");

for (int i = 0; i < 8; i++)
{
    Console.Write(nums[i] + " ");
}
Console.WriteLine("]");