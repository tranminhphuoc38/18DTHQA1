using System;
using System.Globalization;
using System.Windows.Data;

namespace _10_wpf_data_binding_command {
    public class HelloConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            var text = value as String;
            return !string.IsNullOrEmpty(text) ? $"Hello {text}" : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
