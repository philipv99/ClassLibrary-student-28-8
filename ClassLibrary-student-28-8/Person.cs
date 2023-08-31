using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_student_28_8
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set;}

        public GenderEnum Gender { get; set; }

        public Person(string? name, int id, GenderEnum gender)
        {
            Id = id;
            Name = name;
            Gender = gender;
        }


        public override string ToString()
        {
            return $"#{Id}: {Name}";
        }
        public void ValidName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("Name");
            }
            if (Name == "")
            {
                throw new ArgumentException("Name can not be empty", "Name");
            }
        }

        public void Validate()
        {
            ValidName();
        }
    }
}
