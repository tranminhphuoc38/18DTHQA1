using System.Collections.Generic;

namespace _07_linq {
    public class Student {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string City { get; set; }

        public int StudentId { get; set; }

        public List<Result> Exam { get; set; }
    }
}
