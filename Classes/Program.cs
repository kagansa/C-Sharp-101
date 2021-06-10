using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Ahmet", "Taş", 312312, "Yazılım");



            Calisan calisan2 = new Calisan();
            calisan1.Ad = "Hayriye";
            calisan1.Soyad = "Yılmaz";
            calisan1.No = 32131231;
            calisan1.Departman = "Pazarlama";

            calisan1.CalisanBilgileri();
            calisan2.CalisanBilgileri();

            Console.WriteLine(Islemler.Topla(50, 100));
            Console.WriteLine(Islemler.Cikar(350, 100));
        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }


        public Calisan()
        {

        }


        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }



        public Calisan(string ad, string soyad, int no, string departman) : this(ad, soyad)
        {
            this.No = no;
            this.Departman = departman;
        }



        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı : {Ad}");
            Console.WriteLine($"Çalışan Soyadı : {Soyad}");
            Console.WriteLine($"Çalışan Numarası : {No}");
            Console.WriteLine($"Çalışan Departmanı : {Departman}");
        }
    }



    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }


        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
