using System.ComponentModel.DataAnnotations;

namespace _13_entity_framework.Models {
    public class Result
    {
        [Key]
        public int Id { get; set; }
        
        public string Subject { get; set; }

        public int Score { get; set; }
    }
}
