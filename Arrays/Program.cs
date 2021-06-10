using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.Write("Lütfen dizinin eleman sayısını giriniz");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısı giriniz.", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;

            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama :" + toplam / diziuzunlugu);
        }
    }
}
