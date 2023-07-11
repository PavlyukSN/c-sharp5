/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

// float

void GetArray(double[] Array){
    Console.Write("[");
for (int i=0; i < Array.Length; i++) 
{
    Array[i] = Math.Round((new Random().NextDouble())*10 , 2);
        Console.Write(Array[i]);
        if(i < Array.Length-1) Console.Write(" ");
}
    Console.WriteLine("]");
return;
}

double[] Array = new double[8];
GetArray(Array);
double Big, Small, Dif;
Big = Array.Max();
Small = Array.Min();
Dif = Big - Small;
Console.Write($"Разниц между максимальным и минимальным элементами: {Big} - {Small} = {Dif}");
