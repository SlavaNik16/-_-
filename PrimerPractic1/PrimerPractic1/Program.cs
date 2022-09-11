using System;
//ПЗ_Николаев Вячеслав
class Program
{
    static void Main(string[] args)

    {
        /* Задание 1
         * Напишите консольную программу, в которую пользователь вводит
         * с клавиатуры число. Если число одновременно больше 5 и меньше
         * 10, то программа выводит "Число больше 5 и меньше 10". Иначе
         * программа выводит сообщение "Неизвестное число".
        int i = int.Parse(Console.ReadLine());

        if ((i > 5) && (i < 10)) Console.WriteLine("Число больше 5 и меньше 10 : " + i);
        else Console.WriteLine("Неизвестное число : " + i);
        */

        /* Задание 2
         * Напишите консольную программу, в которой пользователь вводит
         * последовательность целых положительных чисел. Необходимо
         * определить максимальное четное число и его порядковый номер
        Console.Write("Введите колличество чисел в последовательности (целое число): ");
        int b = int.Parse(Console.ReadLine());
        int max = -100;
        int j = 0;

        for (int i = 0; i < b; i++)
        {
            Console.Write("Введите целое число: ");
            int f = int.Parse(Console.ReadLine());

            if (f >= max && f % 2 == 0)
            {
                max = f;
                j = ++i;

            }

        }
        if (max == -100) Console.WriteLine("Нет максимального четного числа");
        else Console.WriteLine($"max = {max} и порядок  = {j}");
        */

        /*Задание 3
         * Напишите программу, которая вводит три вещественных числа.
         * Найти максимальное из них.
         
        var max= -100f;
        Console.WriteLine("Введите числа через пробел: ");
        var number = Console.ReadLine();
        string[] nums = number.Split(new Char[] { ' ' });
        foreach (string num in nums)
        {
            float num1 = float.Parse(num);
            if (max < num1)
            {
                max = num1;
            }
        }
        Console.WriteLine($"Наибольшее число {max}");
        */
        /*Задание 4
         * Напишите программу, которая вводит трёхзначное число и
         * разбивает его на цифры.
        int result = 0;
        var quan = Console.ReadLine();
        int[] count = new int[10];
        int i = 0;
        if(int.TryParse(quan, out int n))
        {
            do
            {
                result = n % 10;
                count[i] = result;
                n /= 10;
                i++;
            } while (n > 0);
            i--;
            for(; i > 0; i--)
            {
                Console.Write($"{count[i]},");

            }
            Console.Write($"{count[i]}");
        }
        */
        /* Задание 5
         * Напишите программу, нахождения суммы знакопеременного
         * ряда:
        Console.WriteLine("Введите знакопеременный ряд через пробел(+ не указывать): ");
        var exp = Console.ReadLine();
        string[] e = exp.Split(new Char[] { ' ' });
        int sum = 0;
        foreach(string n in e)
        {
            int num = int.Parse(n);
            sum += num;
        }
        Console.WriteLine($"Сумма знакопеременного ряда = {sum}");
        */







    }
}