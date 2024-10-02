using System;
using System.Numerics;
using System.Runtime.ExceptionServices;

// lab2-02.10.24
class Test1
{
    static void Main()
    {
        //Дана последовательность из n элементов, такая, что n>=3

        /* //1) - Найти количество локальных минимумов.
        Console.Write("Введите количество элементов: ");
        int n = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Введите числа ");

        int prev = Convert.ToInt32(Console.ReadLine());
        int current = Convert.ToInt32(Console.ReadLine());  
        int next =  Convert.ToInt32(Console.ReadLine());

        int count = 0;

        if (current < prev && current < next)
            count++;

        for (int i = 0; i < n - 3; i++)
        {
            prev = current;
            current = next;
            next = Convert.ToInt32(Console.ReadLine());

            if (current < prev && current < next)
                count++;
        }

        Console.WriteLine($"Количество локальных минимумов: {count}"); */

        /* //2) - Определить второй максимальный элемент.        
        Console.Write("Введите количество элементов: ");

        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите числа");

        int first = Convert.ToInt32(Console.ReadLine());
        int second = Convert.ToInt32(Console.ReadLine());

        int max1 = 0;
        int max2 = 0;

        if (first > second)
        {
            max1 = first;
            max2 = second;
        }
        else
        {
            max1 = second;
            max2 = first;
        }

        for (int i = 0; i < n - 2; i++)
        {
            int current = Convert.ToInt32(Console.ReadLine());

            if (current > max1)
            {
                max2 = max1;
                max1 = current;
            }
            else if (current > max2)
                max2 = current;
        }

        Console.WriteLine($"Второй максимальный элемент: {max2}"); */

        /* //3) - Определить количество элементов оканчивающихся на тройку.
        Console.Write("Введите количество элементов: ");
        int n = Convert.ToInt32 (Console.ReadLine());

        Console.WriteLine("Введите числа");

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(number) % 10 == 3)
                count++;
        }

        Console.WriteLine($"Количество элементов оканчивающихся на тройку: {count}"); */


        /* //4) - Определить все ли элементы четные и оканчиваются на 4. Ответ дать в форме да/нет.
        Console.Write("Введите количество элементов: ");
        int n = Convert.ToInt32 (Console.ReadLine());

        Console.WriteLine("Введите числа");

        bool flag = true;

        for (int i = 0; i < n; i++)
        {
            int current = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(current) % 10 == 4 && Math.Abs(current) % 2 == 0) { }
            else { flag = false; }
        }

        if (flag)
            Console.WriteLine("Да");
        else 
            Console.WriteLine("Нет"); */

    }
}