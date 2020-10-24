using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace wpf_practice
{
    public class StudentDetailViewModel : BaseViewModel
    {
        public StudentDetailViewModel()
        {
            CloseCommand = new RelayCommand(Close);
        }

        public ICommand CloseCommand { get; set; }

        public void Close(object o)
        {
            var window = o as StudentDetailWindow;
            if (window != null)
            {
                window.Close();
            }
        }
    }
}
