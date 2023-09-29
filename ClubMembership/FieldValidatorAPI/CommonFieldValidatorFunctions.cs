using System;
using System.Text.RegularExpressions;

namespace FieldValidatorAPI
{
    public delegate bool RequiredValidDel(string fieldVal);
    public delegate bool StringLengthValidDel(string fieldVal, int min, int max);
    public delegate bool DateValidDel(string fieldVal, out DateTime validDate);
    public delegate bool PatternMatchDel(string fieldVal, string pattern);
    public delegate bool CompareFieldsValidDel(string fieldVal, string fieldValCompare);
    
    public class CommonFieldValidatorFunctions
    {
        private static RequiredValidDel _requiredValidDel = null;
        private static StringLengthValidDel _stringLengthValidDel = null;
        private static DateValidDel _dateValidDel = null;
        private static PatternMatchDel _patternMatchDel = null;
        private static CompareFieldsValidDel _compareFieldsValidDel = null;

        public static RequiredValidDel RequiredFieldValidDel => _requiredValidDel ?? (_requiredValidDel = new RequiredValidDel(RequiredFieldValid));

        public static StringLengthValidDel StringLengthFieldValidDel =>
            _stringLengthValidDel ??
            (_stringLengthValidDel = new StringLengthValidDel(StringFieldLengthValid));

        public static DateValidDel DateValidDel =>
            _dateValidDel ??
            (_dateValidDel = new DateValidDel(DateValid));

        public static PatternMatchDel PatternMatchDel =>
            _patternMatchDel ??
            (_patternMatchDel = new PatternMatchDel(FieldPatternValid));
        
        public static CompareFieldsValidDel CompareFieldsValidDel =>
            _compareFieldsValidDel ??
            (_compareFieldsValidDel = new CompareFieldsValidDel(FieldComparisonValid));
        
        private static bool RequiredFieldValid(string fieldVal)
        {
            return !string.IsNullOrEmpty(fieldVal);
        }

        private static bool StringFieldLengthValid(string fieldVal, int min, int max)
        {
            return fieldVal.Length >= min && fieldVal.Length <= max;
        }
        
        private static bool DateValid(string fieldVal, out DateTime validDate)
        {
            return DateTime.TryParse(fieldVal, out validDate);
        }
        
        private static bool FieldPatternValid(string fieldVal, string regularExpressionPattern)
        {
            var regex = new Regex(regularExpressionPattern);
            return regex.IsMatch(fieldVal);
        }

        private static bool FieldComparisonValid(string fieldVal, string fieldValCompare)
        {
            return fieldVal.Equals(fieldValCompare);
        }
    }
}