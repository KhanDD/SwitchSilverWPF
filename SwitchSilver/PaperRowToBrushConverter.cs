﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SwitchSilver
{
    /// <summary>
    /// Used for converting an paper (PaperRow) to a Solid Brush colour based on compulsory status
    /// </summary>
    class PaperRowToBrushConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Converts a paper row to a Solid Brush colour based on compulsory status
        /// </summary>
        /// <param name="value">Item to be converted</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>red if compulsory, black if not</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // if nothing selected or not a paper row return black
            if (value == null || !(value is study4DataSet.PapersRow)) return Brushes.Black;

            return (value as study4DataSet.PapersRow).Compulsory ? Brushes.Red : Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
