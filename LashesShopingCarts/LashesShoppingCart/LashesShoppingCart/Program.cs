﻿using System;

namespace LashesShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            int theActualResult = MyMethod();

            Console.WriteLine(theActualResult);
        }

        public static int MyMethod()
        {
            int result = 30;

            return result;
        }
    }
}
