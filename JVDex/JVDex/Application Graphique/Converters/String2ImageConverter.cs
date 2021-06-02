using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Data;

namespace Application_Graphique.Converters
{
    class String2ImageConverter : IValueConverter
    {
        public static string imagesPathToAssembly = "pack://application:,,,/Images;component/images/";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imagePath = value as string;

            if (string.IsNullOrWhiteSpace(imagePath)) return null;

            return new Uri(imagesPathToAssembly + imagePath, UriKind.RelativeOrAbsolute);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
