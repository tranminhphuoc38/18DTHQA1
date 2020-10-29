using Common.Model;
using System.Data.Entity;
using System.IO;
using System.Xml.Serialization;
using web_service;

namespace hello_swagger {
    public class StudentDBInitialize : DropCreateDatabaseAlways<SIMContext> {

        protected override void Seed(SIMContext context) {
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