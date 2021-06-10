using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = string.Empty;
            str1 = "Kağan Saygın";
            string ad = "Kağan";
            string soyad = "SAYGIN";
            string tamIsım = ad + soyad;

            int integer1 = 8;
            int integer2 = 2;
            int integer3 = integer1 + integer2;

            bool bool1 = 10 > 2;


            string str40 = "40";
            int int40 = 40;

            string yeniDeger = str40 + int40.ToString();
            Console.WriteLine(yeniDeger); 

            int int21 = int40 + Convert.ToInt32(str40);
            Console.WriteLine(int21);

            int int22 = int40 + int.Parse(str40);


            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
