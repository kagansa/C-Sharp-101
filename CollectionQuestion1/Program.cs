using System;
using System.Collections;

namespace CollectionQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();

            int counter = 0;

            while (counter < 20)
            {
                Console.WriteLine($"{counter + 1}. Sayıyı Giriniz.");
                int value = int.Parse(Console.ReadLine());


                if (IsNumberPrime(value))
                    primeNumbers.Add(value);
                else
                    nonPrimeNumbers.Add(value);

                counter++;

            }

            Console.WriteLine($"Asal Sayılar : {string.Join(",", primeNumbers.ToArray())}");
            Console.WriteLine($"Asal Olmayan Sayılar : {string.Join(",", nonPrimeNumbers.ToArray())}");
        }





        static bool IsNumberPrime(int number)
        {
            bool result = true;

            if (number == 1)
                return false;


            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }

            }

            return result;
        }
    }
}
