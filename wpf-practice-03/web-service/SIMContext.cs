using Common.Model;
using System.Data.Entity;

namespace web_service {
    public class SIMContext : DbContext {
        public SIMContext() : base() {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}