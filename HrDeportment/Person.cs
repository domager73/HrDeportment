using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HrDeportment
{
    public class Person
    {
        private int _id;
        private string _name;
        private double _experience;
        private double _salary;
        private string _post;

        public Person(int id, string name, double experience, double salary, string post) 
        {
            _id = id;
            _name = name;
            _experience = experience;
            _salary = salary;
            _post = post;
        }

        public override string ToString()
        {
            return string.Format("{0,-3}{1,-14}{2,-8}{3, -17}{4, -9}{5, -16}", _id, _name, _experience, _salary, _post);
        }
    }
}
