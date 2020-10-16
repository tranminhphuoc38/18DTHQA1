using System.Collections.Generic;
using System.Xml.Serialization;

namespace _07_linq {
    [XmlRoot("dataset")]
    public class Dataset {

        [XmlElement("Student")]
        public List<Student> Students { get; set; }
    }
}
