using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_student_28_8
{
    public class Student : Person
    {
        public int Semester { get; set; }

        public Student(int id, string name, int semester, GenderEnum gender) 
            : base(name, id, gender)
        {
            Semester = semester;
        }

        public override string ToString()
        {
            return $"#{Id}: {Name}, {Semester}. semester student";
        }

        public void ValidSemester()
        {
            if (Semester <= 0)
            {
                throw new ArgumentException("semseter must be more the 0", "semester");
            }
        }

        public void Validate()
        {
            ValidName();
            ValidSemester();
        }
    }
}
