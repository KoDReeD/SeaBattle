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
using System.Windows.Shapes;

namespace SeaBattle
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btnPlayer1 = new Button();
                    btnPlayer1.Width = 30;
                    btnPlayer1.Height = 30;
                    btnPlayer1.Name = $"BtnP1_{i}_{j}";
                    WP_Player1.Children.Add(btnPlayer1);

                    Button btnPlayer2 = new Button();
                    btnPlayer2.Width = 30;
                    btnPlayer2.Height = 30;
                    btnPlayer2.Name = $"BtnP2_{i}_{j}";
                    WP_Player2.Children.Add(btnPlayer2);
                }
            }

        }
    }
}
