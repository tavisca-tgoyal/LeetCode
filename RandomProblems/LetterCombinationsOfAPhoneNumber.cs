using System;
using System.Collections.Generic;
using System.Text;

namespace RandomProblems
{
    public class LetterCombinationsOfAPhoneNumber
    {
        //this question is asked in google and it has level =  medium
        public List<string> Run(string digits)
        {
            return LetterCombinations(digits);
        }
        private List<string> LetterCombinations(string digitStr)
        {
            if (digitStr.Length < 2)
            {
                if (string.IsNullOrEmpty(digitStr))
                    return new List<string>();
                return DigitToAlpha(digitStr[0]);
            }
            return Cross(DigitToAlpha(digitStr[0]), LetterCombinations(digitStr.Substring(1)));
        }
        private List<string> Cross(List<string> list1, List<string> list2)
        {
            List<string> temp = new List<string>();
            foreach (var i in list1)
            {
                foreach (var j in list2)
                {
                    temp.Add(i + j);
                }
            }
            return temp;
        }
        private List<string> DigitToAlpha(char digit)
        {
            switch (digit)
            {
                case '2':
                    return new List<string> { "a", "b", "c" };
                case '3':
                    return new List<string> { "d", "e", "f" };
                case '4':
                    return new List<string> { "g", "h", "i" };
                case '5':
                    return new List<string> { "j", "k", "l" };
                case '6':
                    return new List<string> { "m", "n", "o" };
                case '7':
                    return new List<string> { "p", "q", "r", "s" };
                case '8':
                    return new List<string> { "t", "u", "v" };
                case '9':
                    return new List<string> { "w", "x", "y", "z" };
                default:
                    return new List<string>();
            }
        }
    }
}
