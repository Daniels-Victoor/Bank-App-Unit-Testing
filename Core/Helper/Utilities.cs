using Core.Abstractions;
using System;
using System.Globalization;
using System.Linq;

namespace Core.Helper
{
    public static class Utilities
    {
        //Generate random number
        public static string GenerateRandomNumber(int length, string prefix)
        {
            var random = new Random();
            string str = "";
            for (int i = 0; i < length; i++)
                str = String.Concat(str, random.Next(length).ToString());
            return prefix + str;
        }

        //Generates user id
        public static string GenerateCustomerId()
        {
            return GenerateRandomNumber(4, "CAZ");
        }

        public static string RemoveDigits(string str)
        {
            string chars = new String(str.Where(x => x != '_' && (x < '0' || x > '9')).ToArray());
            return chars;
        }
        //Changes the removed digits to a title case
        public static string ChangeToTitle(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);

        }
    }
}
