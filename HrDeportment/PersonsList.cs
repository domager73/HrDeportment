using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrDeportment
{
    public class PersonsList
    {
        private List<Person> _persons;

        public PersonsList() 
        {
            _persons = new List<Person>() { 
                new Person(1, "Dima", 2, 1000, PostStorage.Posts[1]),
                new Person(2, "Diwa", 2, 2000, PostStorage.Posts[3]),
                };
        }

        public void AddNew(Person person) 
        {
            _persons.Add(person);
        }
    }
}
