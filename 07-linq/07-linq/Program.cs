using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace _07_linq {
    public class Program {
        public static void Main(string[] args) {
            XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Dataset));
            StreamReader file = new StreamReader(@"D:\MPT\Document\Hutech\18DTHQA1\07-linq\student_sample_data.xml");

            var data = (Dataset)reader.Deserialize(file);
            file.Close();

            ListData(data.Students, s => $"{s.FirstName} {s.LastName}");

            // Statistic student by Gender
            StatistucByGender(data);

            CalculateGPA(data);

            Console.ReadLine();
        }

        private static void ListData<T>(IEnumerable<T> data, Func<T, string> selector) {
            foreach (var s in data.ToList()) {
                Console.WriteLine(selector.Invoke(s));
            }
        }

        private static void StatistucByGender(Dataset data) {
            var genderData = data.Students.GroupBy(s => s.Gender, s => s.Id, (k, v) => new { Gender = k, Number = v.Count() });
            foreach (var g in genderData) {
                Console.WriteLine($"{g.Gender}: {g.Number}");
            }
        }

        private static void CalculateGPA(Dataset data) {
            var gpaData = data.Students.Select(s => new { 
                Name = $"{s.FirstName} {s.LastName}", 
                //Gpa = s.Exam.Select(e => e.Score).Average()
                Gpa = s.Exam.Average(e => e.Score)
            });
            ListData(gpaData, g => $"{g.Name}: {g.Gpa}");
        }

        

    }
}
