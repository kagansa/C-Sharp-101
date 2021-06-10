using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            numberList.Add(23);
            numberList.Add(10);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(92);
            numberList.Add(34);

            List<string> colorList = new List<string>();

            colorList.Add("kirmizi");
            colorList.Add("mavi");
            colorList.Add("turuncu");
            colorList.Add("sarı");
            colorList.Add("lacivert");

            Console.WriteLine(numberList.Count);
            Console.WriteLine(colorList.Count);

            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }

            foreach (string number in colorList)
            {
                Console.WriteLine(number);
            }

            numberList.ForEach(x => Console.WriteLine(x));
            colorList.ForEach(x => Console.WriteLine(x));

            numberList.Remove(4);
            colorList.Remove("Yeşil");

            numberList.RemoveAt(0);
            colorList.RemoveAt(1);

            numberList.ForEach(x => Console.WriteLine(x));
            colorList.ForEach(x => Console.WriteLine(x));
        }
    }
}