using _13_entity_framework.Models;
using hello_swagger;
using System.Data.Entity;

namespace _13_entity_framework {
    public class SchoolDBContext : DbContext {
        public SchoolDBContext() : base("Server=.;Database=SchoolDb;Trusted_Connection=True;") {

            //Database.SetInitializer(new StudentDBInitialize());
            //Database.SetInitializer(new DropCreateDatabaseAlways<SchoolDBContext>());

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolDBContext, Configuration>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
