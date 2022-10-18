
/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < 10; i++)
    {
        array[i] = rand.Next(1,99);
        Console.Write(array[i] + ",");
    }

var max = array[0];
var min = array[0];
for (int i = 1; i < 10; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
     }
            
 Console.WriteLine("Разность равна [{0}]", max - min);
        
