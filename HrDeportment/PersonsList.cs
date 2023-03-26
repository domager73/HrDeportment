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

        public List<Person> GetAllActive()
        {
            return _persons.Where(person => person.IsActive()).ToList();
        }

        public Person GetActiveById(int id)
        {
            return _persons.FirstOrDefault(person => person.IsActive() && person.GetId() == id);
        }

        public void DeleteActiveById(int id)
        {
            Person person = GetActiveById(id);
            person.SoftDelete();
        }

        public void ChangeSalaryActiveById(int id, double newSalary) 
        {
            Person person = GetActiveById(id);

            person.SetSalary(newSalary);
        }

        public void ChangePostActiveById(int id, string newPost)
        {
            Person person = GetActiveById(id);

            person.SetPost(newPost);
        }
    }
}
