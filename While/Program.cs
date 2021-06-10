using System;

namespace While
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("**** Foreach ******");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (string araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}