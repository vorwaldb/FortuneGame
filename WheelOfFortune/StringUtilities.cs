using System.Text;

namespace WheelOfFortune
{
    static class StringUtilities
    {
        public static bool IsVowel(string letter)
        {
            return (letter == "A" || letter == "E" || letter == "I" ||
                    letter == "O" || letter == "U");
        }

        public static string RemoveSubStringFromString(string subString, string baseString)
        {
            var baseStringTemp = new StringBuilder(baseString.Trim());

            if (baseString.Contains(subString))
            {
                baseStringTemp.Replace(subString, "");
            }
            return baseStringTemp.ToString();
        }
    }
}
