using System;

// lab1
class Test1
{
static void Main()
    {
        /* task1 

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Исходный порядок: {a} {b}");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"После замены: {a} {b}"); */

        /*  task2
        int first_number = Convert.ToInt32(Console.ReadLine());
        int second_number = Convert.ToInt32(Console.ReadLine());

        int min = (first_number + second_number - Math.Abs(first_number - second_number)) / 2;
        int max = (first_number + second_number + Math.Abs(first_number - second_number)) / 2;

        Console.WriteLine($"Наименьшее число: {min}");
        Console.WriteLine($"Наибольшее число: {max}"); */

        // task3
        Console.Write("Введите количество грядок : ");

        int n = Convert.ToInt32(Console.ReadLine());

        int m = 3;
        int l = 3;
        int p = 5;

        int L = n * ( 2 * (m + l)) + 2 * n * p + n * l * (n - 1);

        Console.WriteLine(L);
        Console.ReadLine();
    }
}