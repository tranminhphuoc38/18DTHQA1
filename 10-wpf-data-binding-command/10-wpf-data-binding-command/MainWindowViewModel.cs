using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_wpf_data_binding_command {
    public class MainWindowViewModel : INotifyPropertyChanged, IDataErrorInfo {
        private string m_hello;

        public MainWindowViewModel() {
            Hello = "Welcome XXX";
        }

        public string Hello { 
            get => m_hello; 
            set {
                m_hello = value;
                Classes.Add(value);
                OnPropertyChanged(nameof(Hello));
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<string> Classes { get; set; } = new ObservableCollection<string>();

        public string Name { get; set; }

        #region validation (IDataErrorInfo)
        public string this[string columnName] {
            get {
                string result = string.Empty;
                if (nameof(Name) == columnName) {
                    if(string.IsNullOrEmpty(Name)) {
                        result = "Name is mandatory";
                    }
                }
                return result;
            }
        }

        public string Error {
            get { throw new NotImplementedException(); }
        }


        #endregion
    }
}
