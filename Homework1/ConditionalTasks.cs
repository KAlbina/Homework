using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    internal class ConditionalTasks
    {
        public static string GetTimeOfDayMessage(int hour)
        {
            if (hour < 0 || hour > 23)
                throw new ArgumentException("Час должен быть другой");
            if (hour >= 6 && hour <= 11)
                return "Доброе утро";
            if (hour >= 12 && hour <= 17)
                return "Добрый день";
            if (hour >= 18 && hour <= 22)
                return "Добрый вечер";
            return "Доброй ночи";
        }
        public static string GetSeasonByMonth(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "Зима";

                case 3:
                case 4:
                case 5:
                    return "Весна";

                case 6:
                case 7:
                case 8:
                    return "Лето";

                case 9:
                case 10:
                case 11:
                    return "Осень";

                default:
                    throw new ArgumentException("Месяц должен быть от 1 до 12");
            }
        }
        public static bool IsLeapYear(int year)
        {
            if (year <= 0)
                throw new ArgumentException("Год  не можеь быть отрицательным");

            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }
        public static bool CanTriangleExist(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны должны быть положительными");

            return a + b > c && a + c > b && b + c > a;

        }
    }
}
