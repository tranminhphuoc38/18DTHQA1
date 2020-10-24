using System;

namespace Common.Model {
    public class Student {
        public int Id { get; set; }

        public string Class { get; set; }

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public string Gender { get; set; }

        public string City { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
