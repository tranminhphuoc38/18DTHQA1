using Common.Model;
using hello_swagger;
using System.Data.Entity;

namespace web_service {
    public class SIMContext : DbContext {
        public SIMContext() : base("Server=.;Database=SIM;Trusted_Connection=True;") {
            Database.SetInitializer(new StudentDBInitialize());
        }

        public DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<Common.Model.Class> Classes { get; set; }
        //public DbSet<Class> Classes { get; set; }
    }
}