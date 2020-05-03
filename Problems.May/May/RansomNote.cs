using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenges.May
{
    public class RansomNote
    {
        public bool Run(string rNote, string magazine)
        {
            int[] mCounter = new int[26];
            foreach (char ch in magazine)
            {
                mCounter[ch % 97]++;
            }
            foreach (char ch in rNote)
            {
                if (mCounter[ch % 97] > 0)
                    mCounter[ch % 97]--;
                else
                    return false;
            }
            return true;
        }
        
    }
}
