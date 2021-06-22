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
        public Board b;
        private int DataToDisplay;
        private string[] PlayerSymbols = { " ", "O", "X" };

        //Game state:
        // 0 - Draw
        // 1 - Player 1 wins
        // 2 - Player 2 wins
        // 3 - no Win -> continue
        // 4 - Intergame

        public OsAndXs_Game()
        {
            b = new Board();
            CurrentPlayer = 1;
            GameState = 4;
            DataToDisplay = 1;
        }

        public void ButtonPress(int num)
        {
            if (GameState == 3)
            {
                int[] CoOrd = MyMaths.NumToCoOrd(num);
                //If successfully added
                if (b.addCounter(CurrentPlayer, CoOrd[0], CoOrd[1]))
                {
                    //Switch player
                    CurrentPlayer = (CurrentPlayer % 2) + 1;
                }
                GameState = b.checkwin();
            }
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
        public string GetCurrentPlayerSymbol()
        {
            return GetPlayerSymbol(CurrentPlayer);
        }
        public string GetPlayerSymbol(int num)
        {
            return PlayerSymbols[num];
        }
        public void Start()
        {
            CurrentPlayer = 1;
            GameState = 3;
        }
        public void clearBoard()
        {
            b.clearBoard();
        }

        public string getDataToDisplay()
        {
            string TextToDisplay = "";
            switch (DataToDisplay)
            {
                case 1:
                    TextToDisplay = "Game State: " + Convert.ToString(GameState);
                    break;
                case 2:
                    TextToDisplay = "Current player: " + CurrentPlayer;
                    break;
                default:
                    TextToDisplay = "WTF";
                    break;
            }
            DataToDisplay = (DataToDisplay % 2) + 1;
            return TextToDisplay;
        }
    }
}
