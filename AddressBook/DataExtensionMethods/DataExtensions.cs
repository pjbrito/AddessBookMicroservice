using System;
using System.Text;

namespace AddressBook.DataExtensionMethods
{
    public static class DataExtensions
    {

        public static string ToTitleCase(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            const string spaceChar = " ";
            if (!str.Contains(spaceChar))
            {
                return char.ToUpper(str[0]) + str.Substring(1).ToLower();
            }

            var wordArray = str.Split(new[] { spaceChar }, StringSplitOptions.RemoveEmptyEntries);
            var wordBuild = new StringBuilder();
            foreach (var word in wordArray)
            {
                wordBuild.Append($"{ToTitleCase(word)}{spaceChar}");
            }

            return wordBuild.ToString().Trim();
        }
    }
}
