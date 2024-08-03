using System;
using System.Diagnostics;

namespace 01_USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The price in USD is : {0:f2} ",usd);
            Console.WriteLine(" |     |       |      |     " );
            Console.WriteLine(" V     V       V      V     " );
            Console.WriteLine("The price in BGN is : {0:f2} ",bgn);

        }
    }
}
