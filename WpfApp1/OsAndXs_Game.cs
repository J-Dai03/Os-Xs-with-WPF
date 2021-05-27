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
        private Board b;
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
            GameState = 0;
        }

        public void Play()
        {
            GameState = 0;
            Console.WriteLine("Begin game");

            while (GameState == 0)
            {
                //Player turn
                Console.WriteLine("Turn: Player " + Convert.ToString(CurrentPlayer));
                MoveValidity = b.addCounter(CurrentPlayer, players[CurrentPlayer - 1].getMove());
                while (MoveValidity == false)
                {
                    Console.WriteLine("Invalid move. Please try again");
                    int xCoord = Convert.ToInt32(Console.ReadLine());
                    int yCoord = Convert.ToInt32(Console.ReadLine());
                    MoveValidity = b.addCounter(CurrentPlayer, xCoord, yCoord);
                }
                //Next player
                CurrentPlayer = (CurrentPlayer) % 2;
                CurrentPlayer++;
                GameState = b.checkwin(players[0].getSymbol(), players[1].getSymbol());
            }
            Console.WriteLine("Game over");

            //Winner announcement
            switch (GameState)
            {
                case 1:
                    Console.WriteLine("Player 1 wins");
                    players[0].addWin();
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins");
                    players[1].addWin();
                    break;
                case 3:
                    Console.WriteLine("Draw");
                    break;
                default:
                    Console.WriteLine("Error: Unknown GameState");
                    Console.WriteLine("GameState value: " + Convert.ToString(GameState));
                    break;
            }

            ShowWins();
        }
        public void ShowWins()
        {
            Console.WriteLine("Current tally:");
            Console.WriteLine("Player 1: " + Convert.ToString(players[0].getWins()));
            Console.WriteLine("Player 2: " + Convert.ToString(players[1].getWins()));
        }
    }
}
