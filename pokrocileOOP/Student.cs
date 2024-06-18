using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokrocileOOP
{
    public abstract class Person
    {
        public string FullName { get; set; }
        public Person(string fullName)
        {
            FullName = fullName;
        }
    }
    public class Teacher: Person
    {
        public decimal Salary { get; set; }

        public Teacher(string fullname, decimal salary): base(fullname)
        {
            Salary = salary;
        }

        public override bool GetIsNormal()
        {
            return true;
        }
    }
    public class Student : Person
    {
        public Student(string fullname, DateTime birthday): base(fullname)
        {
            Birthday = birthday;
        }
        public string FullName { get; set; }
        public bool Normal { get; set; }
        public DateTime Birthday { get; private set; }
        
        public bool GetIsNormal()
        {
            return Normal;
        }
    }
}
