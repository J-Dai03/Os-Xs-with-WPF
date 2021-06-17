using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MyMaths
    {
        static public int CoOrdToNum(int x, int y)
        {
            int val;
            val = 3 * x;
            val = val + y;
            return val;
        }

        static public int[] NumToCoOrd(int num)
        {
            int[] CoOrd = new int[2];
            CoOrd[1] = num % 3;
            CoOrd[0] = (num - CoOrd[0])/3;
            return CoOrd;
        }
    }
}
