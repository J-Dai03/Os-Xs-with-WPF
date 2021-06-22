using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OsAndXs_Game Game;
        public MainWindow()
        {
            InitializeComponent();
            Game = new OsAndXs_Game();
        }

        private void BoardButtonClick(int num)
        {
            if (Game.GetGameState() == 3)
            {
                Game.ButtonPress(num);
                updateDisplay();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BoardButtonClick(1);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BoardButtonClick(2);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            BoardButtonClick(3);
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BoardButtonClick(4);
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            BoardButtonClick(5);
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            BoardButtonClick(6);
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            BoardButtonClick(7);
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            BoardButtonClick(8);
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            BoardButtonClick(9);
        }
        private void RestartStart_Click(object sender, RoutedEventArgs e)
        {
            Game.clearBoard();
            Game.Start();
            updateDisplay();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "Save";
        }
        private void Useless_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = Game.getDataToDisplay();
        }

        public void updateDisplay()
        {
            int GameState = Game.GetGameState();
            switch (GameState)
            {
                case 0:
                    Display.Text = "Draw";
                    break;
                case 1:
                case 2:
                    Display.Text = "Player " + Convert.ToString(GameState) + " (" + Game.GetPlayerSymbol(GameState) + ")  wins";
                    break;
                case 3:
                    Display.Text = "Current player: " + Game.GetCurrentPlayerSymbol();
                    break;
                case 4:
                    Display.Text = "Press Start";
                    break;
                default:
                    Display.Text = "Error: Unknown GameState. GameState value: " + Convert.ToString(GameState);
                    break;
            }
            P1.Content = Game.GetCharFromButton(1);
            P2.Content = Game.GetCharFromButton(2);
            P3.Content = Game.GetCharFromButton(3);
            P4.Content = Game.GetCharFromButton(4);
            P5.Content = Game.GetCharFromButton(5);
            P6.Content = Game.GetCharFromButton(6);
            P7.Content = Game.GetCharFromButton(7);
            P8.Content = Game.GetCharFromButton(8);
            P9.Content = Game.GetCharFromButton(9);
        }
    }
}
