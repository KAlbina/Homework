using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    internal class LinearTasks
    {
        public static int SwapTensAndOnes(int n)
        {
            int tens = n / 10;
            int ones = n % 10;
            int result = ones * 10 + tens;
            return result;
        }
        public static int SumWithOverFlowChek(int a, int b)
        {
            return checked(a + b);
        }
        public static char XorToChar(int a, int b)
        {
            return (char)(a ^ b);
        }
        public static int GetLastDigit(float num)
        {
            int number = (int)num;
            int result = number % 10;
            return result;
        }
        public static char NumberToChar(int n)
        {
            int sum = '0' + n;
            char result = (char)sum;
            return result;
        }
    }
}
