namespace FieldValidatorAPI
{
    public static class CommonRegularExpressionValidationPatterns
    {
        public const string Email_Address_RegEx_Pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

        public const string Polish_PhoneNumber_RegEx_Pattern = @"(?<!\w)(\(?(\+|00)?48\)?)?[ -]?\d{3}[ -]?\d{3}[ -]?\d{3}(?!\w)";

        public const string Polish_Post_Code_RegEx_Pattern = @"\d{2}-\d{3}";

        public const string Strong_Password_RegEx_Pattern = @"(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$";
    }
}