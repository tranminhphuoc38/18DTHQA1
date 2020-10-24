using System.Data.Entity;
using web_service.Models;

namespace web_service {
    public class SIMContext : DbContext {
        public SIMContext() : base() {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}