using System;

namespace tugas4
{
    public class Teacher : Person
    {
        public Teacher (string name= "blank" , int age= 0, string teacherId = "blank", string subject = "blank")
        {
            Name = name;
            Age = age;
            TeacherId = teacherId;
            Subject = subject;
        }

        public string TeacherId { get; set; }
        public string Subject { get; set; }

    }
}
