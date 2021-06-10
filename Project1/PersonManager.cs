using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    public class PersonManager
    {
        
        public List<Person> GetAll(Func<Person, bool> predicate = null)
        {
            return predicate == null
                ? PersonDataSource.persons.ToList()
                : PersonDataSource.persons.Where(predicate).ToList();
        }
        
        public Person GetPerson(Func<Person, bool> predicate)
        {
            return PersonDataSource.persons.FirstOrDefault(predicate);
        }
        
        public bool AddPerson(Person person)
        {
            try
            {
                PersonDataSource.persons.Add(person);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        public bool RemovePerson(Person person)
        {
            try
            {
                PersonDataSource.persons.Remove(person);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        public bool UpdatePerson(Person person)
        {
            try
            {
                var findPerson = PersonDataSource.persons.FirstOrDefault(x => x.Name == person.Name && x.LastName == person.LastName);

                if (findPerson == null)
                {
                    return false;
                }
                PersonDataSource.persons.FirstOrDefault(x => x.Name == person.Name && x.LastName == person.LastName).PhoneNumber = person.PhoneNumber;

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}