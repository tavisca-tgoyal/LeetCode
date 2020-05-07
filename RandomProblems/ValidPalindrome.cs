using System;
using System.Collections.Generic;
using System.Text;

namespace RandomProblems
{
    public class ValidPalindrome
    {        
        private bool IsAlphaNumeric(char ch)
        {
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9'))
                return true;
            else
                return false;
        }
        //, a plan, a canal: Pa
        public bool Run(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                char x = s[i];
                char y = s[j];
                if (!IsAlphaNumeric(s[i]))
                {
                    i++;
                    continue;
                }

                if (!IsAlphaNumeric(s[j]))
                {
                    j--;
                    continue;
                }
                if (!Compare(s[i],s[j]))
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        private bool Compare(char v1, char v2)
        {
            if (ToUpper(v1).Equals(ToUpper(v2)))
                return true;
            else
                return false;
        }

        private char ToUpper(char v1)
        {
            if (v1 >= 'A' && v1 <= 'Z')
                return v1;
            else
            {
                return Convert.ToChar(v1 - 32);
            }
        }
    }
}
