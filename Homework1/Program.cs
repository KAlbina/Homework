
using Homework1;
using System;
class Program
{
    static void Main(string[] args)
    {
        // Задание 1 — поменять десятки и единицы
        int result1 = LinearTasks.SwapTensAndOnes(54);
        Console.WriteLine($"Задание 1: {result1}");


        // Задание 2 — сложение с проверкой переполнения
        try
        {
            int result2 = LinearTasks.SumWithOverFlowChek(100, 200);
            Console.WriteLine($"Задание 2: {result2}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Задание 2: {ex.Message}");
        }

        // Задание 3 - вычислить XOR и привести к char
        int result3 = LinearTasks.XorToChar(10, 20);
        Console.WriteLine($"Задание 3: {result3}");

        //Задание 4 - получить последнее число
        int result4 = LinearTasks.GetLastDigit(12.34f);
        Console.WriteLine($"Задание 4: {result4}");

        // Задание 5 — число превратить в символ
        char result5 = LinearTasks.NumberToChar(5);
        Console.WriteLine($"Задание 5: {result5}");

        // Задание 6 - получить сообщение времени суток
        string result6 = ConditionalTasks.GetTimeOfDayMessage(7);
        Console.WriteLine($"Задание 6: {result6}");


        // Задание 7 — определение сезона
        string result7 = ConditionalTasks.GetSeasonByMonth(7);
        Console.WriteLine($"Задание 7: {result7}");

        // Задание 8 — проверка високосного года
        bool result8 = ConditionalTasks.IsLeapYear(2024);
        Console.WriteLine($"Задание 8: {result8}");

        // Задание 9 — проверка существования треугольника
        bool result9 = ConditionalTasks.CanTriangleExist(3, 4, 5);
        Console.WriteLine($"Задание 9: {result9}");









    }

}
