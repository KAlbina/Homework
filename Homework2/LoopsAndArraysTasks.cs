using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    internal class LoopsAndArraysTasks
    {
        public static int SearchInsert(int[] numbers, int target)
        {
            int left = 0;

            int right = numbers.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (numbers[middle] == target)
                {
                    return middle;
                }
                if (numbers[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return left;
        }
        public static int MaxProFit(int[] prices)
        {
            int minprice = prices[0];
            int maxprofit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                {
                    minprice = prices[i];
                }
                int currentprofit = prices[i] - minprice;
                if (currentprofit > maxprofit)
                {
                    maxprofit = currentprofit;
                }
            }
            return maxprofit;
        }
        public static int GreattestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
        public static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }
        public static void PrintMultiplicationTable(int number, int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }




    }
}
