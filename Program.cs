using System;
using System.Collections.Generic;

namespace PhSharp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // 1 задание
            Task1();

            // 2 задание
            // Task2();

            // 3 задание
            // Task3();

            // 4 задание
            // Task4();

            // 5 задание
            // Task5();

        }

        // 1 задание
        static void Task1()
        {
            Console.Write("Введите размер массива N: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Массив в обратном порядке:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + numbers[i];
            }

            double average = (double)sum / n;
            int closest = numbers[0];

            for (int i = 1; i < n; i++)
            {
                if (Math.Abs(numbers[i] - average) < Math.Abs(closest - average))
                {
                    closest = numbers[i];
                }
            }

            Console.WriteLine("Среднее арифметическое: " + Math.Round(average, 2));
            Console.WriteLine("Ближайшее число: " + closest);
        }

        // 2 задание
        static void Task2()
        {
            Console.Write("Введите количество студентов: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество предметов: ");
            int m = int.Parse(Console.ReadLine());

            int[,] grades = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Студент " + (i + 1));
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Оценка: ");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Средние баллы:");
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum = sum + grades[i, j];
                }

                double average = (double)sum / m;
                Console.WriteLine("Студент " + (i + 1) + ": " + Math.Round(average, 2));
            }
        }

        // 3 задание
        static void Task3()
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine("Повторение: " + number);
                    break;
                }

                numbers.Add(number);
            }

            Console.WriteLine("Массив чисел:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        // 4 задание
        static void Task4()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Команды: добавить, поиск, просмотр, выход");
                Console.Write("Введите команду: ");
                string command = Console.ReadLine();

                if (command == "выход")
                {
                    break;
                }
                else if (command == "добавить")
                {
                    Console.Write("Имя: ");
                    string name = Console.ReadLine();

                    Console.Write("Телефон: ");
                    string phone = Console.ReadLine();

                    phoneBook[name] = phone;
                    Console.WriteLine("Контакт добавлен.");
                }
                else if (command == "поиск")
                {
                    Console.Write("Имя: ");
                    string name = Console.ReadLine();

                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine(phoneBook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Контакт не найден.");
                    }
                }
                else if (command == "просмотр")
                {
                    foreach (string name in phoneBook.Keys)
                    {
                        Console.WriteLine(name + ": " + phoneBook[name]);
                    }
                }
                else
                {
                    Console.WriteLine("Неизвестная команда.");
                }
            }
        }

        // 5 задание
        static void Task5()
        {
            Dictionary<string, int> fruits = new Dictionary<string, int>();

            while (true)
            {
                Console.Write("Введите фрукт (или выход): ");
                string fruit = Console.ReadLine();

                if (fruit == "выход")
                {
                    break;
                }

                if (fruits.ContainsKey(fruit))
                {
                    fruits[fruit] = fruits[fruit] + 1;
                }
                else
                {
                    fruits[fruit] = 1;
                }

                Console.WriteLine(fruit + ": " + fruits[fruit]);
            }

            Console.WriteLine("Словарь:");
            foreach (string fruit in fruits.Keys)
            {
                Console.WriteLine(fruit + ": " + fruits[fruit]);
            }
        }
    }
}