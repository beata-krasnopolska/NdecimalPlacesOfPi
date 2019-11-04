using System;

namespace NplacesOfPi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program returns PI to n decimal places. ");
            
            Console.WriteLine("Enter the number of n decimal places of PI you would like to see");
            int decimalPlaces = int.Parse(Console.ReadLine());

            var nDecimalPlaces = new DecimalFinder();
            nDecimalPlaces.Find(decimalPlaces);

            Console.WriteLine(nDecimalPlaces);

            Console.ReadKey();
        }
    }
}
