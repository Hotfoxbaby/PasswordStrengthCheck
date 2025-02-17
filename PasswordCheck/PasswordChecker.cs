using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheck
{
    internal static class PasswordChecker
    {
        public static List<String> CheckPassword(string password)
        {
            List <string> messages = new List<string> ();
            string lengthMessage = CheckPasswordLength(password);
            string phraseMessage = CheckPasswordCommonPhrases(password);
            string characterMessage = CheckPasswordCharacters(password);
            if (lengthMessage != "")
                messages.Add(lengthMessage);
            if (phraseMessage != "")
                messages.Add(phraseMessage);
            if (characterMessage != "")
                messages.Add(characterMessage);
            if(messages.Count == 0)
            {
                return new List<string> {"Your password is strong" };
            }
            return messages;
        }
        private static String CheckPasswordLength(string password)
        {
            if (password.Length < 8)
            {
                return "Password must be at least 8 characters long";
            }
            return "";
        }

        private static String CheckPasswordCommonPhrases(string password)
        {
            if (password.ToLower().Contains("password") || password.ToLower().Contains("pass"))
            {
                return "Password cannot contain any common words like 'password'";
            }
            return "";
        }
        private static String CheckPasswordCharacters(string password)
        {
            if(password.Any(char.IsWhiteSpace))
            {
                return "Password cannot contain spaces";
            } else if (!password.Any(char.IsUpper))
            {
                return "Password must contain at least one uppercase letter";
            } else if (!password.Any(char.IsLetter) && !password.Any(char.IsDigit))
            {
                return "Password must contain at least one letter and digit";
            } else if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return "Password must contain at least one symbol";
            }
            return "";
        }
    }
}
