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
                Console.WriteLine("Модуль 1.");
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Преобразовать из Цельсия в Фаренгейт");
                Console.WriteLine("2. Преобразовать из Фаренгейта в Цельсий");
                Console.WriteLine("3. Число чётное или нечётное");
                Console.WriteLine("4. Является ли строка палиндромом");
                Console.WriteLine("5. Есть ли введённый город в списке");
                Console.WriteLine("6. Угадай число");
                Console.WriteLine("7. Выйти");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    Console.Write("Введите температуру в градусах Цельсия: ");
                    double cels = Convert.ToDouble(Console.ReadLine());
                    double fahr = (cels * 9 / 5) + 32;
                    Console.WriteLine($"Температура в Фаренгейтах: {fahr}°F");
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.Write("Введите температуру в градусах Фаренгейта: ");
                    double fahr = Convert.ToDouble(Console.ReadLine());
                    double cels = (fahr - 32) * 5 / 9;
                    Console.WriteLine($"Температура в Цельсиях: {cels}°C");
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.Write("Введите целое число: ");

                    // Считываем ввод пользователя и конвертируем его в целое число
                    int num = Convert.ToInt32(Console.ReadLine());

                    // Проверяем, является ли число четным или нечетным
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"Число {num} является четным.");
                    }
                    else
                    {
                        Console.WriteLine($"Число {num} является нечетным.");
                    }
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    Console.Write("Введите строку: ");
                    string originalLine = Console.ReadLine();

                    // Убираем пробелы и приводим строку к нижнему регистру для корректного сравнения
                    string processedLine = originalLine.Replace(" ", "").ToLower();

                    // Инвертируем строку
                    char[] символы = processedLine.ToCharArray();
                    Array.Reverse(символы);
                    string перевернутаяСтрока = new string(символы);

                    // Сравниваем исходную обработанную строку с перевернутой
                    if (processedLine == перевернутаяСтрока)
                    {
                        Console.WriteLine($"Строка \"{originalLine}\" является палиндромом.");
                    }
                    else
                    {
                        Console.WriteLine($"Строка \"{originalLine}\" не является палиндромом.");
                    }
                }
                else if (choice == "5")
                {
                    Console.Clear();
                    // Создаем массив с 5 названиями городов
                    string[] cities = new string[5];
                    // Запрашиваем у пользователя ввод названий городов
                    for (int i = 0; i < cities.Length; i++)
                    {
                        Console.Write($"Введите название города {i + 1}: ");
                        cities[i] = Console.ReadLine();
                    }
                    // Запрашиваем у пользователя название города
                    Console.Write("Введите название города: ");
                    string int_city = Console.ReadLine();

                    // Ищем индекс введенного города в массиве
                    int index = Array.IndexOf(cities, int_city);

                    // Проверяем, найден ли город в массиве
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
                else if (choice == "6")
                {
                    Console.Clear();
                    // Генерация случайного числа от 1 до 10
                    Random random = new Random();
                    int planned_num = random.Next(1, 11); // Next(1, 11) генерирует число от 1 до 10 включительно

                    // Запрашиваем у пользователя ввод числа
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
                else if (choice == "7")
                {
                    break;
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
