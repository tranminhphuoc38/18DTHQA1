namespace _04_generic_example.Model
{
    public class Student
    {
        public Student(string name, int id)
        {
            Name = name;
            StudentId = id;
        }

        public string Name { get; set; }

        public int StudentId { get; set; }
    }
}
