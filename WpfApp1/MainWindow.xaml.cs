﻿using System;
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

        private void BoardButtonClick(int x, int y)
        {
            Display.Text = "AAA";
        }
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
            BoardButtonClick(0,0);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Display.Text = "1";
            BoardButtonClick(0, 1);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Display.Text = "2";
            BoardButtonClick(0, 2);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Display.Text = "3";
            BoardButtonClick(1, 0);
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Display.Text = "4";
            BoardButtonClick(1, 1);
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Display.Text = "5";
            BoardButtonClick(1, 2);
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Display.Text = "6";
            BoardButtonClick(2, 0);
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Display.Text = "7";
            BoardButtonClick(2, 1);
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Display.Text = "8";
            BoardButtonClick(2, 0);
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "Reset";
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "Start";
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "Save";
        }

        public void updateDisplay()
        {
            int GameState = Game.GetGameState();
            if (GameState != 0)
            {
                switch (GameState)
                {
                    case 1:
                        Display.Text = "Player 1 wins";
                        break;
                    case 2:
                        Display.Text = "Player 2 wins";
                        break;
                    case 3:
                        Display.Text = "Draw";
                        break;
                    default:
                        Display.Text = "Error: Unknown GameState. GameState value: " + Convert.ToString(GameState);
                        break;
                }
            }
            P1.
        }
    }
}
