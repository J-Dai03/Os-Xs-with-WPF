using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    abstract class Player
    {
        protected Board b;
        public Player(Board b)
        {
            this.b = b;
        }
        //public abstract int GetMove();
    }
}
