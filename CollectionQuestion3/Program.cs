using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionQuestion3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            Console.WriteLine("Bir Cümle Giriniz.");
            sentence = Convert.ToString(Console.ReadLine());

            List<char> chars = new List<char>();

            foreach (char charr in sentence)
            {
                if (charr == 'a' || charr == 'e' || charr == 'i' || charr == 'o' || charr == 'u')
                {
                    chars.Add(charr);
                }

            }

            chars.Sort();
            Console.WriteLine($"Sesli Harfler : {string.Join(",", chars.ToList())}");
        }
    }
}
