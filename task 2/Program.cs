/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void PrintArray(int[] Array){
    int Sum = 0;
    Console.Write("[");
for (int i=0; i < Array.Length; i++) 
{
    Array[i] = new Random().Next(0, 100);
    Console.Write(Array[i]);
    if (i % 2 != 0)
    Sum = Sum + Array[i];
    if(i < Array.Length-1) Console.Write(", ");
}
    Console.WriteLine("]");
    Console.Write($"Сумма элементов на нечётных позициях: {Sum}");
}
//------------------
int[] Arr = new int[new Random().Next(1, 11)];
Console.WriteLine($"Элементов в массиве: {Arr.Length}");
PrintArray(Arr);