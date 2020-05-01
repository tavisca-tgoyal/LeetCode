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
            return FindBadVersion(0, 4);
        }

        private int FindBadVersion(int v, int n)
        {
            throw new NotImplementedException();
        }
    }

    public class VersionControl
    {
        readonly bool[] versionFlags = new bool[] { false, false, false, true, true };
        public bool IsBadVersion(int n)
        {
            return versionFlags[n - 1];
        }
    }
}
