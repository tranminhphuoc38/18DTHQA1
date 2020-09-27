using System;
using System.Collections.Generic;
using _04_generic_example.Model;
using _04_generic_example.Repository;

namespace _04_generic_example
{
    class Program
    {
        private static List<Student> s_students = new List<Student>();
        private static List<Class> s_classes = new List<Class>();

        static void Main(string[] args)
        {
            IClassRepository classRepo = new ClassRepository(s_classes);
            IStudentRepository studentRepo = new StudentRepository(s_students);

            classRepo.Add(new Class("18DTHQA1"));
            classRepo.Add(new Class("18DTHQA2"));

            studentRepo.Add(new Student("Nguyen Van A", 4576));
            studentRepo.Add(new Student("Tran B", 2257));
            studentRepo.Add(new Student("Phan Van C", 9008));

            Console.WriteLine("List all classes");
            foreach (var c in classRepo.GetAll())
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("List all students");
            foreach (var student in studentRepo.GetAll())
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
