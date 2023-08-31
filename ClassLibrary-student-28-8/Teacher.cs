namespace ClassLibrary_student_28_8
{
    public class Teacher:Person
    {

        public int Salary { get; set; }
        public List<string> Classes { get; set; }


        public Teacher(int id, string name, int salary, GenderEnum gender) 
            : base(name, id, gender) 
        {
            Salary = salary;
            Classes = new List<string>();
        }

        public Teacher(int id, string name, int salary, GenderEnum gender, string listOne, string listTwo) 
            : base(name, id, gender)
        {
            Salary = salary;
            Classes = new List<string>
            {
                listOne,
                listTwo
            };
        }

        public void Add(string item)
        {
            Classes.Add(item);
        }

        public override string ToString()
        {
            string? prefix;
            if (Gender == GenderEnum.Male) { prefix = "Mr."; }
            else if (Gender == GenderEnum.Female) { prefix = "Mrs."; }
            else { prefix = string.Empty; }

            return $"#{Id}: {prefix}{Name}, Teahcer";
        }
       
        public void ValidSalary() 
        {
            if (Salary <= 0)
            {
                throw new ArgumentException("salary must be more then 0");
            }
        }

        public void ValidClasses()
        {
            if (Classes == null)
            {
                throw new NullReferenceException("classes is null");
            }
        }

        public void Validate() 
        {
            ValidName();
            ValidSalary();
        }
    }
}