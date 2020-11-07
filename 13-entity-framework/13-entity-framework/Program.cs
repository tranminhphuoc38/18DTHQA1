using _13_entity_framework.Models;
using System;
using System.Linq;

namespace _13_entity_framework {
    class Program {
        static void Main(string[] args) {
            var stud = new Student() {
                Id = 2,
                FirstName = "Tim",
                LastName = "Cook",
                Birthdate = new DateTime(2000, 1, 12),
                GradeId = 2
            };

            using (var ctx = new SchoolDBContext()) {
                ctx.Database.Log = Console.WriteLine;



                ctx.Students.Attach(stud);
                Console.WriteLine("Current State = " + ctx.Entry(stud).State);
                ctx.Entry(stud).State = System.Data.Entity.EntityState.Modified;

                //ctx.Students.Add(stud);
                ctx.SaveChanges();

                //var std = ctx.Students.First();
                //ctx.Students.Remove(std);
                //ctx.SaveChanges();

                Console.ReadLine();
            }
        }
    }
}
