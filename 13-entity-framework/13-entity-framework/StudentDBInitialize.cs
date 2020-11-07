using _13_entity_framework;
using Common.Model;
using System.Data.Entity;
using System.IO;
using System.Xml.Serialization;

namespace hello_swagger {
    public class StudentDBInitialize : DropCreateDatabaseIfModelChanges<SchoolDBContext> {

        protected override void Seed(SchoolDBContext context) {
            var dataset = LoadDataFromXml();

            context.Students.AddRange(dataset.Students);

            base.Seed(context);
        }

        private static Dataset LoadDataFromXml() {
            XmlSerializer reader = new XmlSerializer(typeof(Dataset));
            StreamReader file = new StreamReader(@"D:\MPT\Document\Hutech\18DTHQA1\wpf-practice-03\student_sample_data.xml");

            Dataset data = (Dataset)reader.Deserialize(file);
            file.Close();
            return data;
        }
    }
}