using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class HumanPlayer : Player
    {
        Board ConnectedBoard;
        public HumanPlayer(Board b) : base(b)
        {
            ConnectedBoard = b;
        }
        //Player symbol input & validation
        
        /*public override int GetMove()
        {
            bool valid = false;
            int input = 0;
            string ErrorMessage = "Invalid input. Input must be an integer character between 0 and 9 inclusive";
            while (valid == false)
            {
                Console.WriteLine("Please enter the code for the square you want to chose");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input > 8 || input < 0)
                    {
                        valid = false;
                        Console.WriteLine(ErrorMessage);
                    }
                    else
                    {
                        valid = true;
                    }
                }
                catch
                {
                    Console.WriteLine(ErrorMessage);
                    valid = false;
                }
            }
            return input;
        }
        */
    }
}
