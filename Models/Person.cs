using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfObjectSerializeDeserialize.Models
{
    internal class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id = {Id}\n" +
                $"Name = {Name}\n" +
                $"Age = {Age}\n";
        }
    }
}
