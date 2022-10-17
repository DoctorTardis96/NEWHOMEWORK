/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

class Program
{
    static void Main(string[] args)
    {
    int[] array = new int[6];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i ++)
        {
            array[i] = rand.Next(100,999);
        }
    int y = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            y++;
        }
    Console.Write(array[i] + "|");
    }
    Console.WriteLine("["+ y + "]" + " <-кол-во четных чисел");

    }

}