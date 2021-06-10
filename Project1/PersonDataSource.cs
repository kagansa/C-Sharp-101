using System.Collections.Generic;

namespace Project1
{
    public static class PersonDataSource
    {
        public static List<Person> persons;


        static PersonDataSource()
        {
            persons = InitializePersons();
        }


        static List<Person> InitializePersons()
        {
            return new List<Person>()
            {
                new Person("Kağan","Saygın","05464182562"),
                new Person("Ayşe","Yılmaz","05455451284"),
                new Person("Fatma","Taş","05423547651"),
                new Person("Hayriye","Demir","05455466789"),
                new Person("Eren","Yılmaz","05412234050")
            };

        }
    }
}