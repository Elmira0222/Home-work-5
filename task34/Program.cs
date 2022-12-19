/* Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */


int[] array = new int[new Random().Next(10, 10)];
for (int Numb=0; Numb<array.Length; Numb++)
{
    array[Numb] = new Random().Next(100, 1000);
    Console.Write($"{array[Numb]} ");
}
int Count=0;
foreach (var Even in array)
if (Even%2 == 0)
    Count++;
Console.WriteLine();
Console.Write($"an array filled with random positive three-digit numbers: {Count}");
