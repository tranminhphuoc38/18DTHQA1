using System;
using System.ComponentModel.DataAnnotations;

namespace web_service.Models {
    public class Student {
        [Key]
        public int Id { get; set; }

        public int ClassId { get; set; }

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

    }
}
