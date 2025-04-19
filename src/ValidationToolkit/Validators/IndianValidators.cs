using System.Text.RegularExpressions;

namespace ValidationToolkit.Validators
{
    public static class IndianValidators
    {
        public static bool IsValidPAN(string pan)
        {
            if (string.IsNullOrWhiteSpace(pan)) return false;

            var pattern = @"^[A-Z]{5}[0-9]{4}[A-Z]{1}$";
            return Regex.IsMatch(pan, pattern);
        }

        public static bool IsValidAadhar(string aadhar)
        {
            if (string.IsNullOrWhiteSpace(aadhar)) return false;

            var pattern = @"^\d{12}$";
            return Regex.IsMatch(aadhar, pattern);
        }

        public static bool IsValidIndianMobile(string mobile)
        {
            if (string.IsNullOrWhiteSpace(mobile)) return false;

            var pattern = @"^[6-9]\d{9}$";
            return Regex.IsMatch(mobile, pattern);
        }
    }
}
