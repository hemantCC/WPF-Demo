using Assignment_1.Enums;
using Assignment_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Assignment_1.Implementations
{
    /// <summary>
    /// Helper Class for Managing Theme Change
    /// </summary>
    /// <seealso cref="Assignment_1.Interfaces.IThemeHelper" />
    public class ThemeHelper : IThemeHelper
    {
     
        // The resouce dictionary for storing theme
        public static ResourceDictionary currentResouceDictionary;

        /// <summary>
        /// Changes the application theme.
        /// </summary>
        /// <param name="theme">The theme.</param>
        public void ChangeApplicationTheme(ThemeMode theme)
        {
            switch (theme)
            {
                case ThemeMode.Dark:
                    Application.Current.Resources.MergedDictionaries.Add(currentResouceDictionary =
                        new ResourceDictionary { Source = Constants.FilePath.DarkThemePath });
                    break;
                case ThemeMode.Light:
                    Application.Current.Resources.MergedDictionaries.Add(currentResouceDictionary =
                        new ResourceDictionary() { Source = Constants.FilePath.LightThemePath });
                    break;
                case ThemeMode.Default:
                    Application.Current.Resources.MergedDictionaries.Add(currentResouceDictionary =
                        new ResourceDictionary() { Source = Constants.FilePath.DefaultThemePath });
                    break;
            }
        }
    }
}
