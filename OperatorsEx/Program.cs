using System;

namespace OperatorsEx
{
    class Program
    {
        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int sub(int num1, int num2)
        {
            return num1 - num2;
        }


        public static int divide(int num1, int num2)
        {
            return num1 / num2;
        }


        public static int mod(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Add: {add(1, 5)}");
            Console.WriteLine($"Sub: {sub(5, 4)}");
            Console.WriteLine($"Multiply: {multiply(3, 3)}");
            Console.WriteLine($"Divide: {divide(6, 2)}");
            Console.WriteLine($"Remainder: {mod(6, 2)}");
        }
    }
}

