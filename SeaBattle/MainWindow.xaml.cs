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

namespace SeaBattle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TB_Player1.Text = "1";
            TB_Player2.Text = "2";
        }

        private void Button_Click_Play(object sender, RoutedEventArgs e)
        {
            if (TB_Player1.Text == "" || TB_Player2.Text == "")
            {
                if (TB_Player1.Text == "")
                {
                    TB_Player1.BorderBrush = new SolidColorBrush(Colors.Red);
                    TB_Player1.ToolTip = "Поле не заполнено";
                }
                if (TB_Player2.Text == "")
                {
                    TB_Player2.BorderBrush = new SolidColorBrush(Colors.Red);
                    TB_Player2.ToolTip = "Поле не заполнено";
                }

            }
            else
            {
                TB_Player1.BorderBrush = new SolidColorBrush(Colors.Transparent);
                TB_Player1.ToolTip = "";

                TB_Player2.BorderBrush = new SolidColorBrush(Colors.Transparent);
                TB_Player2.ToolTip = "";
                Manager.Player1.Name = TB_Player1.Text;
                Manager.Player2.Name = TB_Player2.Text;

                Player1Window player1Window = new Player1Window();
                player1Window.Show();
                this.Close();
            }
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Min(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
