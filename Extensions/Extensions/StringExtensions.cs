using System.Collections.Generic;
using System.Linq;

namespace Extensions {
    public static class StringExtensions {

        public static string RemoveLast(this string str, char charToRemove)
        {
            var indexOfCharToRemove = str.LastIndexOf(charToRemove);
            return indexOfCharToRemove < 0 ? str : str.Remove(indexOfCharToRemove, 1);
        }
        public static string RemoveFirst(this string str, char charToRemove)
        {
            var indexOfCharToRemove = str.IndexOf(charToRemove);
            return indexOfCharToRemove < 0 ? str : str.Remove(indexOfCharToRemove, 1);
        }
        public static string Remove(this string str, string stringToRemove) => str.Replace(stringToRemove, null);
        public static string Remove(this string str, IEnumerable<char> charsToRemove) =>
            charsToRemove.Aggregate(str, (current, charToRemove) => current.Remove(charToRemove.ToString()));
        public static string RemoveAfter(this string str, char lastChar) => str.Remove(str.LastIndexOf(lastChar));
        public static string RemoveBefore(this string str, char firstChar) => str.Substring(str.LastIndexOf(firstChar));

        public static string Keep(this string str, List<char> charsToKeep)
        {
            var tmpString = "";

            foreach (var character in str)
            {
                if (charsToKeep.Contains(character))
                    tmpString += character;
            }

            return tmpString;
        }

        public static bool IsEmpty(this string str) => string.IsNullOrWhiteSpace(str);

        public static string Add(this string str, string stringToAdd) => stringToAdd + str;

        public static string Attach(this string str, string stringToAttach) => str + stringToAttach;

        public static string FillAt(this string str, int index, string stringToFill) => str.Insert(index, stringToFill);
        public static string FillAt(this string str, char character, string stringToFill) =>
            str.FillAt(str.IndexOf(character), stringToFill);
    }
}
