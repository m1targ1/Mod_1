using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Вывод пояснений для пользователя
                Console.WriteLine("Выберите модуль:");
                Console.WriteLine("1. Модуль 1.1. Основы C#");
                Console.WriteLine("2. Модуль 1.2. Массивы, строки, переключатели");
                Console.WriteLine("3. Модуль 1.3. Статические методы (методы классов)");
                Console.WriteLine("4. Выход");

                string choice1 = Console.ReadLine(); // Переменная для выбора
                if (choice1 == "1") // Если выбрана 1
                {
                    Console.Clear();
                    while (true)
                    {
                        // Вывод пояснений для пользователя
                        Console.WriteLine("Модуль 1.1. Основы C#");
                        Console.WriteLine("Выберите действие:");
                        Console.WriteLine("1. Преобразовать из Цельсия в Фаренгейт");
                        Console.WriteLine("2. Преобразовать из Фаренгейта в Цельсий");
                        Console.WriteLine("3. Число чётное или нечётное");
                        Console.WriteLine("4. Является ли строка палиндромом");
                        Console.WriteLine("5. Есть ли введённый город в списке");
                        Console.WriteLine("6. Угадай число");
                        Console.WriteLine("7. Выйти");

                        string choice = Console.ReadLine(); // Переменная для выбора

                        if (choice == "1") // Если выбрана 1
                        {
                            Console.Clear();
                            Console.Write("Введите температуру в градусах Цельсия: ");
                            double cels = Convert.ToDouble(Console.ReadLine());
                            double fahr = (cels * 9 / 5) + 32;  // Перевод градусов Цельсия в градусы Фаренгейта
                            Console.WriteLine($"Температура в Фаренгейтах: {fahr}°F");
                        }
                        else if (choice == "2") // Если выбрана 2
                        {
                            Console.Clear();
                            Console.Write("Введите температуру в градусах Фаренгейта: ");
                            double fahr = Convert.ToDouble(Console.ReadLine());
                            double cels = (fahr - 32) * 5 / 9; // Перевод градусов Фаренгейта в градусы Цельсия
                            Console.WriteLine($"Температура в Цельсиях: {cels}°C");
                        }
                        else if (choice == "3") // Если выбрана 3
                        {
                            Console.Clear();
                            Console.Write("Введите целое число: ");

                            int num = Convert.ToInt32(Console.ReadLine()); // Ввод пользователем числа и конвертация в целое число
                                                                           // проверка, является число четным или нечетным
                            if (num % 2 == 0)
                            {
                                Console.WriteLine($"Число {num} является четным.");
                            }
                            else
                            {
                                Console.WriteLine($"Число {num} является нечетным.");
                            }
                        }
                        else if (choice == "4") // Если выбрана 4
                        {
                            Console.Clear();
                            Console.Write("Введите строку: ");
                            string originalLine = Console.ReadLine();

                            // Убрать пробелы и привести строку к нижнему регистру для корректного сравнения
                            string processedLine = originalLine.Replace(" ", "").ToLower();

                            // Инвертирование строку
                            char[] symbol = processedLine.ToCharArray();
                            Array.Reverse(symbol);
                            string reverse_line = new string(symbol);

                            // Сравнение исходной обработанной строки с перевернутой
                            if (processedLine == reverse_line)
                            {
                                Console.WriteLine($"Строка \"{originalLine}\" является палиндромом.");
                            }
                            else
                            {
                                Console.WriteLine($"Строка \"{originalLine}\" не является палиндромом.");
                            }
                        }
                        else if (choice == "5") // Если выбрана 5
                        {
                            Console.Clear();
                            // Создание пустого массива на 5 элементов
                            string[] cities = new string[5];
                            Console.WriteLine("Введите 5 городов.");
                            // Ввод пользователем названий городов для заполнения массива
                            for (int i = 0; i < cities.Length; i++)
                            {
                                Console.Write($"Введите название города {i + 1}: ");
                                cities[i] = Console.ReadLine();
                            }
                            Console.WriteLine();
                            // Запрос у пользователя названия города, который необъходимо найти
                            Console.Write("Введите название города, который необходимо найти: ");
                            string int_city = Console.ReadLine();

                            // Поиск индекса введенного города в массиве
                            int index = Array.IndexOf(cities, int_city);

                            // Проверка, найден ли город в массиве
                            if (index != -1)
                            {
                                index = index + 1;
                                Console.WriteLine($"Город {int_city} найден в массиве под номером {index}.");
                            }
                            else
                            {
                                Console.WriteLine($"Город {int_city} не найден в массиве.");
                            }
                        }
                        else if (choice == "6") // Если выбрана 6
                        {
                            Console.Clear();
                            // Генерация случайного числа от 1 до 10
                            Random random = new Random();
                            int planned_num = random.Next(1, 11); // Генерация число от 1 до 10 включительно

                            // Запрос у пользователя ввести число
                            Console.Write("Угадайте число от 1 до 10: ");
                            int guessed_num = Convert.ToInt32(Console.ReadLine());

                            // Проверка, угадал ли пользователь
                            if (guessed_num == planned_num)
                            {
                                Console.WriteLine("Поздравляем! Вы угадали число.");
                            }
                            else
                            {
                                Console.WriteLine($"К сожалению, вы не угадали. Загаданное число было: {planned_num}.");
                            }
                        }
                        else if (choice == "7") // Если выбрана 7
                        {
                            break; // Выход из программы
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Неверный выбор, попробуйте снова.");
                        }
                        Console.ReadKey();
                        Console.Clear();

                    }
                }
                else if (choice1 == "2") // Если выбрана 2
                {
                    Console.Clear();
                    while (true)
                    {
                        // Вывод пояснений для пользователя
                        Console.WriteLine("Модуль 1.2. Массивы, строки, переключатели");
                        Console.WriteLine("Выберите действие:");
                        Console.WriteLine("1. Массив размера N");
                        Console.WriteLine("2. Целочисленный массив");
                        Console.WriteLine("3. Вычислить К простых чисел");
                        Console.WriteLine("4. Поиск максимального и минимального элементов массива");
                        Console.WriteLine("5. Символьный массив из К элементов");
                        Console.WriteLine("6. Вещественный массив из 10-ти элементов");
                        Console.WriteLine("7. Выйти");
                        string choice2 = Console.ReadLine(); // Переменная для выбора
                        if (choice2 == "1") // Если выбрана 1
                        {
                            Console.Clear();
                            Console.WriteLine("Пояснение:\nЭлементы оригинального массива делятся на максимальный\nэлемент по модулю и выводится разделённый массив.");
                            Console.WriteLine();
                            // Ввод размера массива
                            Console.Write("Введите размер массива N: ");
                            int N = int.Parse(Console.ReadLine());

                            // Создание массива
                            double[] mass = new double[N];

                            //  Заполнение элементов массива
                            for (int i = 0; i < N; i++)
                            {
                                Console.Write($"Введите элемент № {i + 1}:");
                                mass[i] = double.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("Оригинальный массив:");
                            foreach (double value in mass)
                            {
                                Console.Write(value + " ");
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            // Поиск максимального по модулю элемента
                            double maxAbsValue = mass.Max(Math.Abs);

                            // Нормировка элементов массива
                            for (int i = 0; i < N; i++)
                            {
                                mass[i] /= maxAbsValue;
                            }

                            // Вывод измененного массива
                            Console.WriteLine("Измененный массив:");
                            foreach (double value in mass)
                            {
                                Console.Write(value + " ");
                            }
                        }
                        else if (choice2 == "2") // Если выбрана 2
                        {
                            Console.Clear();
                            Console.WriteLine("Пояснение:\nЦелочисленный массив из 10-ти элементов заполняется рандомными значениями от 1 до 100.\nМаксимальный элементв массиве заменяется значением пользователя (ввод с клавиатуры).");
                            Console.WriteLine();
                            // Инициализация массива из 10 целых чисел
                            int[] array = new int[10];
                            Random random = new Random();
                            for (int i = 0; i < array.Length; i++)
                            {
                                array[i] = random.Next(1, 101);
                            }
                            // Вывод оригинального массива
                            Console.WriteLine("Оригинальный массив:");
                            foreach (int value in array)
                            {
                                Console.Write(value + " ");
                            }
                            Console.WriteLine();
                            // Ввод целого числа
                            Console.WriteLine("Введите целое число: ");
                            int x = int.Parse(Console.ReadLine());

                            // Поиск индекса максимального элемента в массиве
                            int maxValue = array[0];
                            int maxIndex = 0;
                            for (int i = 1; i < array.Length; i++)
                            {
                                if (array[i] > maxValue)
                                {
                                    maxValue = array[i];
                                    maxIndex = i;
                                }
                            }
                            // Замена максимального элемента на введенное число
                            array[maxIndex] = x;

                            // Вывод измененного массива
                            Console.WriteLine("Измененный массив:");
                            foreach (int value in array)
                            {
                                Console.Write(value + " ");
                            }
                        }
                        else if (choice2 == "3") // Если выбрана 3
                        {
                            Console.Clear();
                            Console.WriteLine("Пояснение:\nВыводит простые числа в количстве К.\nПростое число - число, которое имеет два делителя: единица и само это число.");
                            Console.WriteLine();
                            // Метод для проверки, является ли число простым
                            bool IsPrime(int num)
                            {
                                if (num < 2) return false;
                                for (int i = 2; i <= Math.Sqrt(num); i++)
                                {
                                    if (num % i == 0) return false;
                                }
                                return true;
                            }
                            // Ввод значения K
                            Console.Write("Введите количество простых чисел K: ");
                            int K = int.Parse(Console.ReadLine());

                            int count = 0;  // Количество найденных простых чисел
                            int number = 2; // Начало с первого простого числа (2)
                            int numbersInLine = 0; // Счетчик чисел в одной строке

                            // Поиск первых K простых чисел
                            while (count < K)
                            {
                                if (IsPrime(number))
                                {
                                    Console.Write(number + " ");
                                    count++;
                                    numbersInLine++;

                                    // Если выведено 10 чисел в строке, перейти на новую строку
                                    if (numbersInLine == 10)
                                    {
                                        Console.WriteLine();
                                        numbersInLine = 0;
                                    }
                                }
                                number++;
                            }
                        }
                        else if (choice2 == "4") // Если выбрана 4
                        {
                            Console.Clear();
                            Console.WriteLine("Пояснение:\nВыводит рандомные числа из диапазона [A;B) в количстве К.\nПосле выводит значения элементов между максимальным и минимальным элементами.");
                            Console.WriteLine();
                            // Ввод параметров
                            Console.Write("Введите количество элементов в массиве (K): ");
                            int K = int.Parse(Console.ReadLine());
                            Console.Write("Введите начало диапазона (A): ");
                            int A = int.Parse(Console.ReadLine());
                            Console.Write("Введите конец диапазона (B): ");
                            int B = int.Parse(Console.ReadLine());

                            // Создание и заполнение массива случайными значениями из диапазона [A, B)
                            Random random = new Random();
                            int[] arr = new int[K];
                            for (int i = 0; i < K; i++)
                            {
                                arr[i] = random.Next(A, B);
                            }

                            // Вывод сгенерированного массива
                            Console.WriteLine("Сгенерированный массив: [" + string.Join(", ", arr) + "]");
                            // Поиск индексов минимального и максимального элементов
                            int minIndex = 0, maxIndex = 0;

                            for (int i = 1; i < K; i++)
                            {
                                if (arr[i] < arr[minIndex])
                                    minIndex = i;

                                if (arr[i] > arr[maxIndex])
                                    maxIndex = i;
                            }

                            Console.WriteLine($"Минимальный элемент: {arr[minIndex]} (индекс {minIndex})");
                            Console.WriteLine($"Максимальный элемент: {arr[maxIndex]} (индекс {maxIndex})");

                            // Вывод элементов между минимальным и максимальным
                            int start = Math.Min(minIndex, maxIndex);
                            int end = Math.Max(minIndex, maxIndex);
                            Console.WriteLine("Элементы между минимальным и максимальным (включительно):");

                            for (int i = start; i <= end; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                        else if (choice2 == "5") // Если выбрана 5
                        {
                            Console.Clear();
                            Console.WriteLine("Пояснение:\nВыводит буквы русского алфавита в рандомном порядке в количстве К.\nПосле выводит согласные буквы из исходного массива.");
                            Console.WriteLine();
                            // Ввод значения K
                            Console.Write("Введите количество элементов в массиве (K): ");
                            int K = int.Parse(Console.ReadLine());

                            // Русский алфавит
                            char[] russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();

                            // Согласные буквы
                            char[] consonants = "бвгджзйклмнпрстфхцчшщ".ToCharArray();

                            // Создание символьного массива из K элементов
                            Random random = new Random();
                            char[] arr = new char[K];

                            // Заполнение массива случайными буквами из русского алфавита
                            for (int i = 0; i < K; i++)
                            {
                                arr[i] = russianAlphabet[random.Next(russianAlphabet.Length)];
                            }

                            // Создание нового массива из согласных букв
                            char[] consonantArr = arr.Where(c => consonants.Contains(c)).ToArray();

                            // Вывод оригинального массива
                            Console.WriteLine("Оригинальный массив: [" + string.Join(", ", arr) + "]");

                            // Вывод массива с согласными буквами
                            Console.WriteLine("Массив согласных: [" + string.Join(", ", consonantArr) + "]");
                        }
                        else if (choice2 == "6") // Если выбрана 6
                        {
                            // Определение массива вещественных чисел
                            double[] arr = new double[10];
                            Random random = new Random();

                            // Заполнение массива случайными вещественными числами в диапазоне [-10, 10)
                            for (int i = 0; i < arr.Length; i++)
                            {
                                arr[i] = random.NextDouble() * 20 - 10; // Генерация числа от -10 до 10
                            }

                            // Вывод исходного массива
                            Console.WriteLine("Исходный массив: [" + string.Join(", ", arr.Select(x => x.ToString("F2"))) + "]");

                            // Создание массива индексов в порядке возрастания значений элементов
                            int[] indices = arr
                                .Select((value, index) => new { Value = value, Index = index }) // Сопоставление значений и индексов
                                .OrderBy(x => x.Value)                                          // Сортировка по значению
                                .Select(x => x.Index)                                           // Извлечение индексов
                                .ToArray();

                            // Вывод массива индексов
                            Console.WriteLine("Массив индексов: [" + string.Join(", ", indices) + "]");
                        }
                        else if (choice2 == "7") // Если выбрана 7
                        {
                            break; // Выход из программы
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Неверный выбор, попробуйте снова.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (choice1 == "3") // Если выбрана 3
                {
                    Console.Clear();
                    while (true)
                    {
                        // Вывод пояснений для пользователя
                        Console.WriteLine("Модуль 1.3. Статические методы (методы классов)");
                        Console.WriteLine("Выберите действие:");
                        Console.WriteLine("1. Сокращение дроби");
                        Console.WriteLine("2. Массив с минимальным количеством элементов, сумма которых не превышает заданного пользователем числа");
                        Console.WriteLine("3. Квадратная целочисленная матрица с упорядоченными строками по возрастанию сумм элементов в них.");
                        Console.WriteLine("4. Выйти");
                        string choice3 = Console.ReadLine(); // Переменная для выбора
                        if (choice3 == "1") // Если выбрана 1
                        {
                            Console.Clear();
                            Console.WriteLine("Пояснение:\nСокращает дробь на НОД из двух чисел");
                            Console.WriteLine();
                            Console.Write("Введите числитель (неотрицательное целое число): ");
                            int numerator = int.Parse(Console.ReadLine());

                            Console.Write("Введите знаменатель (положительное целое число): ");
                            int denominator = int.Parse(Console.ReadLine());

                            if (denominator <= 0)
                            {
                                Console.WriteLine("Ошибка: знаменатель должен быть положительным.");
                            }
                            else
                            {
                                // Сокращение дробь
                                var reducedFraction = Fraction.Reduce(numerator, denominator);
                                Console.WriteLine($"Сокращенная дробь: {reducedFraction.Item1}/{reducedFraction.Item2}");
                            }
                        }
                        else if (choice3 == "2") // Если выбрана 2
                        {
                            Console.Clear();
                            Console.WriteLine("Пояснение:\nПользователь вводит сумму, программа выводит массив элементов со\nзначениями от 1 до 9, сумма которых не превышает сумму пользователя.");
                            Console.WriteLine();
                            Console.Write("Введите максимальную сумму: ");
                            if (int.TryParse(Console.ReadLine(), out int maxSum) && maxSum > 0)
                            {
                                RandomArrayGenerator generator = new RandomArrayGenerator();
                                int[] resultArray = generator.GenerateArray(maxSum);

                                // Выводим результат
                                Console.WriteLine("Сгенерированный массив:");
                                foreach (int number in resultArray)
                                {
                                    Console.Write(number + " ");
                                }
                                Console.WriteLine($"\nОбщая сумма: {resultArray.Sum()}");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: введите положительное целое число.");
                            }
                        }
                        else if (choice3 == "3") // Если выбрана 3
                        {
                            Console.Clear();
                            Console.WriteLine("Пояснение:\nВыводит квадратную матрицу со значениями в диапазоне [-50;50] указанного пользователем размера.\nПосле сортирует строки по возрастанию сумм элементов в этой строке.");
                            Console.WriteLine();
                            Console.Write("Введите размер квадратной матрицы: ");
                            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
                            {
                                MatrixSorter sorter = new MatrixSorter();
                                sorter.GenerateMatrix(size);
                                Console.WriteLine("Сгенерированная матрица:");
                                sorter.PrintMatrix();
                                sorter.SortRowsBySum();
                                Console.WriteLine("\nМатрица после сортировки строк по возрастанию сумм:");
                                sorter.PrintMatrix();
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: введите положительное целое число.");
                            }
                        }
                        else if (choice3 == "4") // Если выбрана 4
                        {
                            break; // Выход из программы
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Неверный выбор, попробуйте снова.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (choice1 == "4") // Если выбрана 4
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                }
                Console.Clear();
            }
        }
    }
    class Fraction
    {
        // Статический метод для вычисления НОД
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Метод для сокращения дроби
        public static (int, int) Reduce(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю.");

            // Находим НОД
            int gcd = GCD(numerator, denominator);
            // Сокращаем дробь
            return (numerator / gcd, denominator / gcd);

        }
    }
    class RandomArrayGenerator
    {
        // Метод для генерации массива случайных чисел
        public int[] GenerateArray(int maxSum)
        {
            Random random = new Random();
            int[] numbers = new int[100]; // Максимум 100 элементов
            int sum = 0;
            int count = 0;

            // Генерация случайных чисел и добавление их в массив
            while (sum < maxSum && count < numbers.Length)
            {
                int randomNumber = random.Next(1, 10); // Случайное число от 1 до 9
                if (sum + randomNumber <= maxSum) // Проверка, не превысит ли сумма
                {
                    numbers[count] = randomNumber;
                    sum += randomNumber;
                    count++;
                }
            }
            // Создание итогового массива с реальным размером
            int[] resultArray = new int[count];
            Array.Copy(numbers, resultArray, count);
            return resultArray;
        }
    }
    class MatrixSorter
    {
        private int[,] matrix;

        // Метод для генерации квадратной матрицы с случайными значениями
        public void GenerateMatrix(int size)
        {
            Random random = new Random();
            matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(-50, 51); // Случайные значения от -50 до 50
                }
            }
        }

        // Метод для упорядочивания строк матрицы по возрастанию сумм
        public void SortRowsBySum()
        {
            int size = matrix.GetLength(0);
            int[] rowSums = new int[size];

            // Вычисление суммы каждой строки
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    rowSums[i] += matrix[i, j];
                }
            }

            // Сортировки строки матрицы по возрастанию сумм
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (rowSums[i] > rowSums[j])
                    {
                        // Замена строк местами
                        for (int k = 0; k < size; k++)
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[j, k];
                            matrix[j, k] = temp;
                        }

                        // Замена сумм местами
                        int tempSum = rowSums[i];
                        rowSums[i] = rowSums[j];
                        rowSums[j] = tempSum;
                    }
                }
            }
        }

        // Метод для вывода матрицы
        public void PrintMatrix()
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{matrix[i, j],4} "); // Форматирование вывода
                }
                Console.WriteLine();
            }
        }
    }
}
