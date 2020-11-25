using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Constants
{
    /// <summary>
    /// Stores Path of Files in Uri format
    /// </summary>
    public static class FilePath
    {
        public static Uri DefaultThemePath =
            new Uri("pack://application:,,,/ResourceDictionaries/Themes/DefaultMode.xaml", UriKind.RelativeOrAbsolute);

        public static Uri DarkThemePath =
            new Uri("pack://application:,,,/ResourceDictionaries/Themes/DarkMode.xaml", UriKind.RelativeOrAbsolute);

        public static Uri LightThemePath =
            new Uri("pack://application:,,,/ResourceDictionaries/Themes/LightMode.xaml", UriKind.RelativeOrAbsolute);

    }
}
