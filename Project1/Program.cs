using System;
using System.Linq;

namespace Project1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintStartScreen();
            int processType = int.Parse(Console.ReadLine());
        }

        private static void PrintStartScreen()
        {
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
            Console.WriteLine("******************************************************");
            Console.WriteLine("(1) Yeni Numara Eklemek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            int processType = int.Parse(Console.ReadLine());
            RouteProcess(processType);
        }

        private static void RouteProcess(int processType)
        {
            switch (processType)
            {
                case 1: StartAddPersonProcess(); break;
                case 2: StartDeletePersonProcess(); break;
                case 3: StartUpdatePersonProcess(); break;
                case 4: StartListPersonsProcess(); break;
                case 5: FilterPersonsProcess(); break;
                default: Console.WriteLine("Geçersiz İşlem."); PrintStartScreen(); break;
            }
        }

        private static void StartAddPersonProcess()
        {
            var person = new Person();

            Console.WriteLine("Lütfen İsim Giriniz.");
            person.Name = Console.ReadLine();
            Console.WriteLine("Lütfen Soyisim Giriniz.");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Lütfen Numara Giriniz.");
            person.PhoneNumber = Console.ReadLine();

            PersonManager pm = new PersonManager();
            var result = pm.AddPerson(person);
            var a = PersonDataSource.persons.ToList();

            if (result)
                Console.WriteLine("Numara Eklendi.");
            else
                Console.WriteLine("Numara Eklenemedi.");

            PrintStartScreen();
        }

        private static void StartDeletePersonProcess()
        {
            Console.WriteLine("Lütfen Silmek İstediğiniz Kişinin Adını veya Soyadını Giriniz.");
            string nameOrLastName = Console.ReadLine().ToLower();

            PersonManager _pm = new PersonManager();
            var findPerson = _pm.GetPerson(x => x.Name.ToLower() == (nameOrLastName) || x.LastName.ToLower() == (nameOrLastName));

            if (findPerson == null)
            {
                Console.WriteLine("Kullanıcı Bulunamadı. Bir Seçim Yapınız.");
                Console.WriteLine("Ana Menüye Dön (1)");
                Console.WriteLine("Tekrar Dene (2)");

                int backProcessType = int.Parse(Console.ReadLine());

                if (backProcessType == 1)
                    PrintStartScreen();
                else if (backProcessType == 2)
                {
                    StartDeletePersonProcess();
                }
            }
            else
            {
                Console.WriteLine($"{findPerson.Name} {findPerson.LastName} İsimli, {findPerson.PhoneNumber} Numaralı Kullanıcı Siliniyor. Onaylıyor Musunuz ? (y/n)");
                string confirmResult = Console.ReadLine().ToLower();

                if (confirmResult == "y")
                {
                    var result = _pm.RemovePerson(findPerson);

                    if (result)
                        Console.WriteLine("Kullanıcı Silindi.");
                    else
                        Console.WriteLine("Kullanıcı Silinemedi.");
                }

                PrintStartScreen();
            }
        }

        private static void StartUpdatePersonProcess()
        {
            Console.WriteLine("Lütfen Güncellemek İstediğiniz Kişinin Adını veya Soyadını Giriniz.");
            string nameOrLastName = Console.ReadLine().ToLower();

            PersonManager _pm = new PersonManager();
            var findPerson = _pm.GetPerson(x => x.Name.ToLower() == (nameOrLastName) || x.LastName.ToLower() == (nameOrLastName));

            if (findPerson == null)
            {
                Console.WriteLine("Kullanıcı Bulunamadı. Bir Seçim Yapınız.");
                Console.WriteLine("Ana Menüye Dön (1)");
                Console.WriteLine("Tekrar Dene (2)");

                int backProcessType = int.Parse(Console.ReadLine());

                if (backProcessType == 1)
                    PrintStartScreen();
                else if (backProcessType == 2)
                {
                    StartUpdatePersonProcess();
                }
            }
            else
            {
                Console.WriteLine($"{findPerson.Name} {findPerson.LastName} İsimli Kullanıcının Mevcut Numarası : {findPerson.PhoneNumber}");
                Console.WriteLine("Yeni Telefon Numarasını Giriniz.");
                string phoneNumber = Console.ReadLine();
                findPerson.PhoneNumber = phoneNumber;
                var result = _pm.UpdatePerson(findPerson);

                if (result)
                    Console.WriteLine("Kullanıcı Güncellendi.");
                else
                    Console.WriteLine("Kullanıcı Güncellenemedi.");

                PrintStartScreen();
            }
        }

        private static void StartListPersonsProcess()
        {
            PersonManager _pm = new PersonManager();
            _pm.GetAll().ForEach(x => Console.WriteLine($" İsim : {x.Name} \n Soyisim : {x.LastName} \n Numara : {x.PhoneNumber} \n --------------------------------------"));
            PrintStartScreen();
        }

        private static void FilterPersonsProcess()
        {
            Console.WriteLine("Arama Yapmak İstediğiniz Tipi Seçiniz.");
            Console.WriteLine("*************************************************");

            Console.WriteLine("İsim veya Soyisime göre arama yap (1)");
            Console.WriteLine("Telefon Numarasına göre arama yap (2)");

            int filterType = int.Parse(Console.ReadLine());

            if (filterType == 1)
            {
                Console.WriteLine("İsim veya Soyisim Giriniz.");
                string nameOrLastname = Console.ReadLine().ToLower();

                PersonManager _pm = new PersonManager();
                Console.WriteLine("Bulunan Sonuçlar");
                _pm.GetAll(x => x.Name.ToLower() == nameOrLastname || x.LastName.ToLower() == nameOrLastname)
                    .ForEach(x => Console.WriteLine($" İsim : {x.Name} \n Soyisim : {x.LastName} \n Numara : {x.PhoneNumber} \n --------------------------------------"));
                PrintStartScreen();
            }
            else if (filterType == 2)
            {
                Console.WriteLine("Numara Giriniz.");
                string phoneNumber = Console.ReadLine();

                PersonManager _pm = new PersonManager();
                Console.WriteLine("Bulunan Sonuçlar");
                _pm.GetAll(x => x.PhoneNumber == phoneNumber)
                    .ForEach(x => Console.WriteLine($" İsim : {x.Name} \n Soyisim : {x.LastName} \n Numara : {x.PhoneNumber} \n --------------------------------------"));
                PrintStartScreen();
            }
        }
    }
}