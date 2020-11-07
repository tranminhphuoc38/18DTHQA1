using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace _13_entity_framework.Models {
    [Table("StudentInfo")]
    public class Student {
        [Key]
        public int Id { get; set; }

        public string Class { get; set; }

        public int StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public string Gender { get; set; }

        public string City { get; set; }

        public string Email { get; set; }

        public int GradeId { get; set; }

        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }

        //[XmlElement("exam")]
        //public IList<Result> exam { get; set; }

    }
}
