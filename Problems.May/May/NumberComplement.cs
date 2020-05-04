using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenges.May
{
    public class NumberComplement
    {
        
        public int Run(int num)
        {
            return ToDecimal(Complement(ToBinary(num)));
        }

        private int ToDecimal(List<int> list)
        {
            int result = 0;
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                result += Convert.ToInt32(Math.Pow(2,i)) * list[i];                
            }
            return result;
        }
        
        private List<int> Complement(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0)
                    list[i] = 1;
                else
                    list[i] = 0;
            }
            return list;
        }

        private List<int> ToBinary(int num)
        {
            List<int> temp = new List<int>();
            while(num != 0)
            {
                temp.Add(num % 2);
                num = num / 2;
            }
            temp.Reverse();
            return temp;
        }
    }
}
