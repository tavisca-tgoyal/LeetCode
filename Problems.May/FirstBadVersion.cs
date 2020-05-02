using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.May
{
    public class FirstBadVersion : VersionControl
    {
        //day1
        /*
             F F F T T
             approach1: iterate and return first T
             approach2: use binary search to find first T
         */
        public int Run()
        {
            int length = versionFlags.Length;
            return FindBadVersion(0, length);
        }

        private int FindBadVersion(int start, int end)
        {
            //int mid = (start + end) / 2;
            //do not use about expression to calculate mid, this will cause overflow in case of big inputs
            int mid = start + (end - start) / 2;
            if (IsBadVersion(mid) && mid != 0 && !IsBadVersion(mid - 1))
                return mid;
            else
            {
                if (IsBadVersion(mid) == false)
                {
                    return FindBadVersion(mid + 1, end);
                }
                else
                {
                    return FindBadVersion(start, mid);
                }
            }            
        }
    }

    public class VersionControl
    {
        public readonly bool[] versionFlags = new bool[] { false, false, false, true, true };
        public bool IsBadVersion(int n)
        {
            return versionFlags[n - 1];
        }
    }
}
