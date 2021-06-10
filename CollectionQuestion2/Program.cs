using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionQuestion2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int counter = 0;

            while (counter < 20)
            {
                Console.WriteLine($"{counter + 1}. Sayıyı Giriniz.");

                int value = int.Parse(Console.ReadLine());

                if (value <= 0)
                {
                    Console.WriteLine("Sayı Sıfırdan Küçük Olamaz.");
                    continue;
                }

                numbers.Add(value);
                counter++;

                Console.WriteLine($"En Büyük 3 Sayı : {string.Join(",", numbers.OrderByDescending(x => x).Take(3))}");
                Console.WriteLine($"En Küçük 3 Sayı : {string.Join(",", numbers.OrderBy(x => x).Take(3))}");
                Console.WriteLine($"En Büyük 3 Sayının Ortalaması : {string.Join(",", numbers.OrderByDescending(x => x).Take(3).Average())}");
                Console.WriteLine($"En Küçük 3 Sayının Ortalaması : {string.Join(",", numbers.OrderBy(x => x).Take(3).Average())}");

            }
        }
    }
}
