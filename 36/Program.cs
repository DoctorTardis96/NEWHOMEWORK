/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Random rand = new Random();
        for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1,99);
            }
        int sum = 0;
        for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            Console.Write(array[i] + "|");
            }
    Console.WriteLine("[" + sum + "]" + " <-Сумма нечетных чисел");
    }
}