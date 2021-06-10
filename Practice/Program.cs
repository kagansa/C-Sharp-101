using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Practice1();
            //Practice2();
            //Practice3();
            Practice4();
        }

        private static void Practice1()
        {
            Console.WriteLine("Pozitif Bir Sayı Giriniz.");

            int iterationValue = int.Parse(Console.ReadLine());

            if (iterationValue <= 0)
                Console.WriteLine("Girdiğiniz Sayı Pozitif Değil.");
            else
            {
                List<int> numbers = new List<int>();

                for (int i = 0; i < iterationValue; i++)
                {
                    Console.WriteLine($"{i}. Sayıyı Giriniz.");

                    int value = int.Parse(Console.ReadLine());

                    if (value <= 0)
                    {
                        Console.WriteLine("Girdiğiniz Sayı Pozitif Değil.");

                        //SAYIYI TEKRAR AL
                        i--;
                    }
                    else
                        numbers.Add(value);
                }

                Console.WriteLine($"Çift Sayılar : {string.Join(",", numbers.Where(x => x % 2 == 0))}");
            }
        }

        private static void Practice2()
        {
            Console.WriteLine("Birinci Sayıyı Giriniz (n)");
            int numberN = int.Parse(Console.ReadLine());

            if (numberN <= 0)
            {
                throw new ArgumentException();
            }

            Console.WriteLine("Birinci Sayıyı Giriniz (m)");
            int numberM = int.Parse(Console.ReadLine());

            if (numberM <= 0)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < numberN; i++)
            {
                Console.WriteLine($"{i + 1}. Sayıyı Giriniz.");

                int value = int.Parse(Console.ReadLine());

                if (value <= 0)
                {
                    Console.WriteLine("Girdiğiniz Sayı Pozitif Değil.");

                    //SAYIYI TEKRAR AL
                    i--;
                }
                else if (value == numberM || value % numberM == 0)
                {
                    Console.WriteLine(value.ToString());
                }
            }
        }

        private static void Practice3()
        {
            Console.WriteLine("Bir Sayı Giriniz.");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                throw new ArgumentException();
            }

            string[] wordArray = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i + 1}. kelimeyi giriniz.");
                wordArray[i] = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine("Girdiğiniz Kelimeler :");
            for (int i = number - 1; i >= 0; i--)
            {
                Console.WriteLine(wordArray[i]);
            }
        }

        private static void Practice4()
        {
            Console.WriteLine("Lütfen Bir Cümle Giriniz.");
            string cumle = Convert.ToString(Console.ReadLine());

            int harfSayisi = cumle.Replace(" ", string.Empty).Length;
            int kelimeSayisi = cumle.Split(' ').Length;
            Console.WriteLine("Harf Sayısı : " + harfSayisi.ToString());
            Console.WriteLine("Kelime Sayısı : " + kelimeSayisi.ToString());
        }
    }
}