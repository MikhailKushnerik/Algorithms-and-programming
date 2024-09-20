using System;

// lab1
class Test1
{
    static void Main()
    {
        /* поменять значения переменных местами

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"До замены: {a} {b}");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"После замены: {a} {b}"); */

        /*  вывести наибольшее/ наименьшее
         
        int first_number = Convert.ToInt32(Console.ReadLine());
        int second_number = Convert.ToInt32(Console.ReadLine());

        int min = (first_number + second_number - Math.Abs(first_number - second_number)) / 2;
        int max = (first_number + second_number + Math.Abs(first_number - second_number)) / 2;

        Console.WriteLine($"Наименьшее число: {min}");
        Console.WriteLine($"Наибольшее число: {max}"); */

        /* задача про грядки

        Console.Write("Введите количество грядок: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите ширину грядок: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите длину грядок: ");
        int l = Convert.ToInt32(Console.ReadLine());

        int p = 5;

        int L = n * ( 2 * (m + l)) + 2 * n * p + n * l * (n - 1);

        Console.WriteLine($"Пройденный путь: {L}");
        */
    }
}