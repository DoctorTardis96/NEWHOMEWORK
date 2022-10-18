/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] array;
Random rand;
int Lenght, sum, count;

static void startMyMethod(out int[] array, out Random rand, out int Lenght, out int sum, out int count)
{
    array = new int[16];
    rand = new Random();
    Lenght = array.Length;
    sum = 0;
    count = 0;
}

static void CountMyMethod(int[] array, Random rand, int Lenght, ref int sum, ref int count)
{
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = rand.Next(-999, 999);
        Console.Write($" { array[i] } ");
        if (array[i] >= 1)
            sum = sum + 1;
        count = count + 1;
    }
    Console.WriteLine();
    Console.Write("Колличество чисел больше нуля = " + sum);
}

startMyMethod(out array, out rand, out Lenght, out sum, out count);

CountMyMethod(array, rand, Lenght, ref sum, ref count);