using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressionsHomework5
{
    internal class RegexTask
    {
        public static string RemoveServiceNumbers(string text)
        {
            return Regex.Replace(text, @"#\d+|\[\d+\]", "");
        }

        public static bool Checklogin(string login)
        {
            return Regex.IsMatch(login, "^[A-Za-z][A-Za-z0-9_]{3,10}[A-Za-z0-9]$");
        }
        public static MatchCollection FindNumbers(string text)
        {
            return Regex.Matches(text, @"(?<![A-Za-z])\d+(?![A-Za-z])");
        }
        public static bool CheckPassword(string password)
        {
            return Regex.IsMatch(password, "^(?=.*\\d)(?=.*[A-Z])[A-Za-z0-9]{8,16}$");
        }

    }
}
