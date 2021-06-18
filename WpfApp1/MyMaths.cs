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
            /*
             *  Num = 3*x + y + 1
                Y = (Num – 1) % 3
                X = Math.Floor((Num – 1) / 3)
                X = (Num – Y – 1)/3
             */
            int[] CoOrd = new int[2];
            CoOrd[1] = (num-1) % 3;
            CoOrd[0] = (num - CoOrd[1] - 1) /3;
            return CoOrd;
        }
    }
}
