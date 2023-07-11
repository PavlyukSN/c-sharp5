/* Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void PrintArray(int[] Array){
    int Count = 0;
    Console.Write("[");
for (int i=0; i < Array.Length; i++) 
{
    Array[i] = new Random().Next(100, 1000);
    Console.Write(Array[i]);
    if (Array[i] % 2 == 0)
    Count++;
    if(i < Array.Length-1) Console.Write(", ");
}
    Console.WriteLine("]");
    Console.Write($"Чётных: {Count}");
}
//------------------
int[] Arr = new int[new Random().Next(1, 11)];
Console.WriteLine($"Элементов в массиве: {Arr.Length}");
PrintArray(Arr);