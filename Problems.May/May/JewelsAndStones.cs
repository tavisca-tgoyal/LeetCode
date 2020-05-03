using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.May
{
    public class JewelsAndStones
    {
        public int Run(string J, string S)
        {
            return FindJewelsAndStones(J,S);
        }

        private int FindJewelsAndStones(string j, string s)
        {
            HashSet<char> jewel = new HashSet<char>();
            foreach (char ch in j)
            {
                jewel.Add(ch);
            }
            int result = 0;
            foreach (char ch in s)
            {
                if (jewel.Contains(ch))
                {
                    result++;
                }
            }
            return result;
        }
    }
}
