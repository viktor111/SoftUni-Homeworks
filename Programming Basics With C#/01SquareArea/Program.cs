﻿using System;

namespace SquareArea

{
   public class Program
    {
        public static void Main()
        {
            Console.WriteLine("a = ");

            var a = int.Parse(Console.ReadLine());
            var area = a * a;

            Console.Write($"Square = {area}");
            
        }
    }
}
