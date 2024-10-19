using System;

namespace TimeCalculation
{
    public class TimeCalculator
    {
        // Метод, який обчислює години, хвилини та секунди
        public static (int hours, int minutes, int seconds) CalculateTime(int totalSeconds)
        {
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;
            return (hours, minutes, seconds);
        }

        static void Main()
        {
            // Запит у користувача
            Console.Write("Введіть кількість секунд, що пройшли з початку доби: ");
            int totalSeconds = int.Parse(Console.ReadLine());

            // Обчислення та вивід
            var (hours, minutes, seconds) = CalculateTime(totalSeconds);
            Console.WriteLine($"З початку доби пройшло {hours} годин {minutes} хвилин {seconds} секунд.");
        }
    }
}
