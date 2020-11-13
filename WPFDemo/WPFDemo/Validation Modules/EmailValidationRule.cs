using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;

namespace WPFDemo.Validation_Modules
{
    public class EmailValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            ValidationResult result = new ValidationResult(true, null);
            if(value.ToString().Length > 0 && value.ToString().Length < 5)
            {
                result = new ValidationResult(false, "Should be Atleast 5 characters.");
            }
            return result;
        }
    }
}
