using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassTask
{
    internal static class Helper
    {
     public static  bool IsOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
     public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
     public static bool HasDigit(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPassword(string password)
        {
            bool hasLower = false;
            bool hasUpper = false;
            bool hasDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                
                if (Char.IsLower(password[i]))
                    hasLower = true;
                if (Char.IsUpper(password[i]))
                    hasUpper = true;
                if (Char.IsDigit(password[i]))
                    hasDigit = true;

                
                if (hasLower && hasUpper && hasDigit)
                    return true;
            }
            

            return false;
        }

        public static string Captalize(this string text)
        {
            return Char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }

    }
}
