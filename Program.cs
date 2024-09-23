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
                Console.WriteLine("Модуль 1.");
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
    }
}
