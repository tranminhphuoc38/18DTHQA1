using Common.Model;
using Common.Service;
using System.Collections.ObjectModel;
using System.Windows.Input;
using wpf_practice.Service;

namespace wpf_practice
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _searchText;
        public MainWindowViewModel()
        {
            // Using Web Service
            StudentService = new StudentWebService();

            // Using File
            //StudentService = new StudentService();

            SearchCommand = new RelayCommand(SearchData);
            NewStudentCommand = new RelayCommand(NewStudent);
            ResetCommand = new RelayCommand(o => Reset());

            StudentList = new ObservableCollection<Student>(StudentService.SearchStudent(new StudentSearchCriteria()));
            ClassList = new ObservableCollection<Class>(StudentService.GetAllClasses());
        }

        public IStudentService StudentService { get; set; }

        public ICommand SearchCommand { get; set; }

        public ICommand NewStudentCommand { get; set; }

        public ICommand ResetCommand { get; set; }

        public ObservableCollection<Student> StudentList { get; set; }

        public ObservableCollection<Class> ClassList { get; set; }

        public string SearchText {
            get
            {
                return _searchText;
            }
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }

        public void NewStudent(object o)
        {
            
        }

        public void SearchData(object o)
        {
            StudentList.Clear();
            var result = StudentService.SearchStudent(new StudentSearchCriteria { SearchText = SearchText });
            foreach (var item in result)
            {
                StudentList.Add(item);
            }
        }

        public void Reset()
        {
            SearchText = string.Empty;
        }
    }
}
