using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SwitchSilver
{
    /// <summary>
    /// Used to convert the index of a combo box to bool
    /// </summary>
    class IndexToBoolConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Converts the index of a combo box to bool
        /// </summary>
        /// <param name="value">the index to be converted</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>true if greater than -1, false otherwise</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value is int) && (int)value > -1; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
