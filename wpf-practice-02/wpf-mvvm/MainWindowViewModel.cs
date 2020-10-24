using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf_mvvm
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _name;
        private string _helloText;

        

        public string Name {
            get
            {
                return _name;
            }
            set{
                _name = value;
                HelloText = $"Hello {_name}";
            }
        }

        public string HelloText { get { return _helloText; }
            set {
                _helloText = value;
                OnPropertyChanged(nameof(HelloText));
            }
        }

        public List<Class> ClassList { get; set; } = new List<Class> {
            new Class() { ClassName = "CNTT 1" },
            new Class() { ClassName = "CNTT 2" },
            new Class() { ClassName = "CNTT 3" },
        };

        private Class _class;
        public Class SelectedClass {
            get {
                return _class;
            }
            set {
                _class = value;
                OnPropertyChanged(nameof(SelectedClass));
            }
        }

        public MainWindowViewModel()
        {
            SaveCommand = new RelayCommand(o => SaveData());
        }

        public ICommand SaveCommand { get; set; }

        public void SaveData()
        {

        }
    }
}
