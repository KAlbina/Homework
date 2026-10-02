using Homework2;

class Program
{
    static void Main()
    {
        // Задание 1
        int[] numbers = { 1, 3, 5, 6 };
        int target = 5;

        int result = LoopsAndArraysTasks.SearchInsert(numbers, target);

        Console.WriteLine($"Целевое значение = {result}");


        // Задание 2
        int[] prices = { 7, 1, 5, 3, 6, 4 };

        int profit = LoopsAndArraysTasks.MaxProFit(prices);

        Console.WriteLine($"максимальная прибыль = {profit}");


        // Задание 3
        int gcd = LoopsAndArraysTasks.GreattestCommonDivisor(48, 18);
        Console.WriteLine($"НОД = {gcd}");



        // Задание 4
        bool perfectNumber = LoopsAndArraysTasks.IsPerfectNumber(6);

        Console.WriteLine($"число совершенное? {perfectNumber}");


        // Задание 5
        Console.WriteLine("Таблица умножения: ");
        LoopsAndArraysTasks.PrintMultiplicationTable(7, 6);

         
        // Задание 1
        StringsTasks.LineStatistic("C# 2026!");

        // Задание 2
        StringsTasks.FindRichestWord("cat cucumber hi");

        // Задание 3
        StringsTasks.RemoveShortWords("I am learning CSharp now");

        // Задание 4
        StringsTasks.RemoveExtraSpaces("   Hello     world    hello   ");
    }

}
