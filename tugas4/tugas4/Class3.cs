using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas4
{
    public class Student : Person
    {
        public Student(string name = "blank", int age = 0, string studentId = "blank", string email = "blank")
        {
            Name = name;
            Age = age;
            StudentId = studentId;
            Email = email;
        }
        public string StudentId { get; set; }
        public string Email { get; set; }
        
      
    }
}
