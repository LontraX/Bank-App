using System;

namespace BankAppSqlite.Commons
{
    public class Utilities
    {
        public static string FirstCharacterToUpper(string str)
        {
            string val = char.ToUpper(str[0]) + str.Substring(1);

            return val;
        }


        public static string RemoveDigitsFromStart(string str)
        {
            string val = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    val += str[i];
                }
                else
                {
                    continue;
                }
            }
            return val;
        }


        public static bool IsEmailValid(string str)
        {
            bool val = false;
            if (str.Contains("@"))
            {
                var len = str.Substring(str.LastIndexOf(".")).Length;
                if (len >= 2 && len <= 4)
                {
                    val = true;
                }
            }
            return val;
        }
    }
}
