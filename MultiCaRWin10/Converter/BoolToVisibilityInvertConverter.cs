﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MultiCaRWin10.Converter
{
    /// <summary>
    /// Convertisseur d'un boolean en indication de Visible
    /// </summary>
    public class BoolToVisibilityInvertConverter : IValueConverter
    {
        /// <summary>
        /// Boolean to Visible
        /// </summary>
        /// <param name="value">la donnée</param>
        /// <param name="targetType">targettype</param>
        /// <param name="parameter">parameter</param>
        /// <param name="language">Culture</param>
        /// <returns>la conversion</returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return ((bool)value) ? Visibility.Collapsed : Visibility.Visible;
        }

        /// <summary>
        /// Visible to boolean
        /// </summary>
        /// <param name="value">la donnée</param>
        /// <param name="targetType">targettype</param>
        /// <param name="parameter">parameter</param>
        /// <param name="language">Culture</param>
        /// <returns>la conversion</returns>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return ((Visibility)value == Visibility.Collapsed);
        }
    }
}
