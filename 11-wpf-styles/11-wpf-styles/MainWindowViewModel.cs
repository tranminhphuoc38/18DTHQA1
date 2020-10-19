using _11_wpf_styles.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_wpf_styles {
    public class MainWindowViewModel {
        public List<Class> ListClass { get; set; } = new List<Class> {
            new Class("Class A1", 2019),
            new Class("Class A2", 2020),
            new Class("Class A3", 2021),
        };
    }
}
