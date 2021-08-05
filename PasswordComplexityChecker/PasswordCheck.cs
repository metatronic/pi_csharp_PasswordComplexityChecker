using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordComplexityChecker
{
    class PasswordCheck
    {
        public static bool CheckPassword(string password)
        {
            if (CheckPasswordForLetters(password)
                && CheckPasswordForNumbers(password)
                && CheckPasswordForSymbols(password)
                && CheckPasswordLength(password)
                && CheckPasswordForCapitalLetters(password))
            {
                return true;
            }
            return false;
        }

        private static bool CheckPasswordForLetters(string password)
        {
            for (int index = 0; index < password.Length; index++)
            {
                if (Char.IsLetter(password[index]))
                {
                    return true;
                }
            }

            return false;
        }
        private static bool CheckPasswordForNumbers(string password)
        {
            for (int index = 0; index < password.Length; index++)
            {
                if (Char.IsDigit(password[index]))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool CheckPasswordForSymbols(string password)
        {
            for (int index = 0; index < password.Length; index++)
            {
                if (!Char.IsLetterOrDigit(password[index]))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool CheckPasswordLength(string password)
        {
            if (password.Length >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool CheckPasswordForCapitalLetters(string password)
        {
            for (int index = 0; index < password.Length; index++)
            {
                if (Char.IsUpper(password[index]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
