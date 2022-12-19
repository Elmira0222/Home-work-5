/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */


int[] array = new int[new Random().Next(6, 10)];
for (int Numb=0; Numb<array.Length; Numb++)
{
    array[Numb] = new Random().Next(0, 10);
    Console.Write($"{array[Numb]} ");
}
int Count=0;
for (int Numb=1; Numb<array.Length; Numb+=2)
    Count+=array[Numb];
Console.WriteLine();
Console.Write($"The sum of odd values of an arbitrarily given array is equal to: {Count}");