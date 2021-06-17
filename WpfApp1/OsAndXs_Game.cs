using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class OsAndXs_Game
    {
        private int CurrentPlayer;
        private int GameState;
        private bool MoveValidity;
        public Board b;
        private Player[] players;

        //Game state:
        // 0 - Draw
        // 1 - Player 1 wins
        // 2 - Player 2 wins
        // 3 - no Win -> continue

        public OsAndXs_Game()
        {
            Board b = new Board();
            Player[] players = new Player[2];
            CurrentPlayer = 1;
            GameState = 3;
        }

        public void ButtonPress(int x, int y)
        {
            //If successfully added
            if (b.addCounter(CurrentPlayer, x, y))
            {
                //Switch player
                CurrentPlayer = (CurrentPlayer % 2) + 1;
            }
            GameState = b.checkwin();
        }
        public int GetGameState()
        {
            GameState = b.checkwin();
            return GameState;
        }
        public char GetCharFromButton(int num)
        {
            char charToReturn = ' ';
            int[] CoOrd = MyMaths.NumToCoOrd(num);
            int posVal = b.GetPos(CoOrd[0], CoOrd[1]);
            switch (posVal)
            {
                case 1:
                    charToReturn = 'O';
                    break;
                case 2:
                    charToReturn = 'X';
                    break;
                default:
                    charToReturn = ' ';
                    break;
            }
            return charToReturn;
        }
    }
}
