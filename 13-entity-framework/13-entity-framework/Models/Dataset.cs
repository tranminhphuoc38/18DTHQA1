using _13_entity_framework.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Common.Model {
    [XmlRoot("Dataset")]
    public class Dataset
    {

        [XmlElement("Student")]
        public List<Student> Students { get; set; }
    }
}
