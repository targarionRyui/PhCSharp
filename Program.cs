using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhCSharp
{
    internal class Program
    {
        //1 задание
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольника: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            int b = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine($"Площадь прямоугольника - {a * b}.\nПериметр прямоугольника - {(a + b) * 2}.");
        }

        //2 задание
        //static void Main(string[] args)
        //{
        //    Console.Write("Введите сумму в рублях: ");
        //    double rubles = double.Parse(Console.ReadLine());

        //    Console.Write("Введите текущий курс доллара (рублей за 1$): ");
        //    double rate = double.Parse(Console.ReadLine());

        //    double dollars = rubles / rate;

        //    Console.WriteLine($"Сумма в долларах: {dollars}$");
        //}

        //3 задание
        //static void Main(string[] args)
        //{
        //    double sum = 0;
        //    Console.WriteLine("Введите температуру для каждого из 7 дней недели:");

        //    for (int i = 1; i <= 7; i++)
        //    {
        //        Console.Write($"День {i}: ");
        //        sum += double.Parse(Console.ReadLine());
        //    }

        //    double averageTemp = sum / 7;
        //    Console.WriteLine($"Средняя температура за неделю: {averageTemp}°C");
        //}

        //4 задание
        //static void Main(string[] args)
        //{
        //    double[] averages = new double[3];

        //    for (int student = 1; student <= 3; student++)
        //    {
        //        Console.WriteLine($"\nВведите 5 оценок для {student}-го студента:");
        //        double studentSum = 0;

        //        for (int grade = 1; grade <= 5; grade++)
        //        {
        //            Console.Write($"Оценка {grade}: ");
        //            studentSum += double.Parse(Console.ReadLine());
        //        }

        //        averages[student - 1] = studentSum / 5;
        //    }

        //    Console.WriteLine("\nСредние значения оценок:");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine($"Студент {i + 1}: {averages[i]:F2}");
        //    }
        //}

        //5 задание
        //static void Main(string[] args)
        //{
        //    int[,] matrix = new int[3, 3];
        //    int[,] transposed = new int[3, 3];

        //    Console.WriteLine("Введите 9 чисел матрицы 3х3 через пробел (например: 1 2 3 4 5 6 7 8 9):");
        //    string input = Console.ReadLine();

        //    string[] tokens = input.Split(' ');

        //    int index = 0;

        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            matrix[i, j] = int.Parse(tokens[index++]);
        //        }
        //    }


        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            transposed[j, i] = matrix[i, j];
        //        }
        //    }

        //    Console.WriteLine("\nСтало:");
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write(transposed[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}