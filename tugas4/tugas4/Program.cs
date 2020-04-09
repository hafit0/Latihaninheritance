using System;

namespace tugas4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike",20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 35, "190302", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Hafit Abekrori", 19,"19.11.2765", "hafit.abekrori@students.amikom.ac.id" );
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
