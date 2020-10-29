using Common.Model;
using hello_swagger;
using System.Data.Entity;

namespace web_service {
    public class SIMContext : DbContext {
        public SIMContext(string connectionString) : base(connectionString) {
            Database.SetInitializer(new StudentDBInitialize());
        }

        public DbSet<Student> Students { get; set; }
        //public DbSet<Class> Classes { get; set; }
    }
}