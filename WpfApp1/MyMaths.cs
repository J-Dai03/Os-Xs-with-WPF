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
            val = val + y + 1;
            return val;
        }

        static public int[] NumToCoOrd(int num)
        {
            int[] CoOrd = new int[2];
            CoOrd[1] = (num-1) % 3;
            CoOrd[0] = (num - (num % 3)) /3;
            return CoOrd;
        }
    }
}
