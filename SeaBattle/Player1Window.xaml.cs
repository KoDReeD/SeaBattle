using System;
using System.Collections;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SeaBattle
{
    /// <summary>
    /// Логика взаимодействия для Player1Window.xaml
    /// </summary>
    public partial class Player1Window : Window
    {
        static Button[,] buttons;

        static Button[] setButtons;
        static TextBlock[] setTB;

        public delegate void EventHandler(object sender, EventArgs e);

        Ship ship;

        public static Button currentButton;
        public static TextBlock currentTB;

        static int? shipCount;
        static int? shipCellAmount;

        public Player1Window()
        {
            InitializeComponent();
            shipCount = null;
            shipCellAmount = null;

            setButtons = new Button[4];
            setTB = new TextBlock[4];

             buttons = new Button[10, 10];

            for (int i = 0; i < 4; i++)
            {
                object iBtn = SP_Menu.FindName($"B_S{i + 1}");
                object iTB = SP_Menu.FindName($"TB_{i + 1}ShipAmount");
                setButtons[i] = (Button)iBtn;
                setTB[i] = (TextBlock)iTB;
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btnPlayer1 = new Button();
                    btnPlayer1.Width = 30;
                    btnPlayer1.Height = 30;
                    btnPlayer1.Name = $"b{i}_{j}";
                    btnPlayer1.Background = Brushes.GhostWhite;
                    btnPlayer1.Click += BtnClick;
                    WP_Player1.Children.Add(btnPlayer1);

                    buttons[i, j] = btnPlayer1;

                }
            }

            TB_PlayerName.Text = Manager.Player1.Name;
            currentButton = B_S1;
            currentButton.BorderBrush = Brushes.Red;
            TB_1ShipAmount.Text = "4";
            TB_2ShipAmount.Text = "3";
            TB_3ShipAmount.Text = "2";
            TB_4ShipAmount.Text = "1";
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            if (TB_4ShipAmount.Text == "0")
            {
                Player2Window player2Window = new Player2Window();
                player2Window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не все корабли раставлены");
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

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            shipCellAmount = null;
            shipCount = null;

            TB_1ShipAmount.Text = "4";
            TB_2ShipAmount.Text = "3";
            TB_3ShipAmount.Text = "2";
            TB_4ShipAmount.Text = "1";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    buttons[i, j].IsHitTestVisible = true;
                    buttons[i, j].Background = Brushes.GhostWhite;
                }
            }

            currentButton.BorderBrush = Brushes.DimGray;
            currentButton = B_S1;
            currentButton.BorderBrush = Brushes.Red;
        }

        private void Button_Click_Erazer(object sender, RoutedEventArgs e)
        {
            if (shipCellAmount != null)
            {
                ShipClear();
            }
        }

        public void EndStandShips()
        {
            currentTB.Text = shipCount.ToString();
            shipCellAmount = null;
            shipCount = null;

            int indBtn = Array.IndexOf(setButtons, currentButton);

            if (indBtn < setButtons.Length - 1)
            {
                currentButton.BorderBrush = Brushes.DimGray;
                currentButton = setButtons[indBtn + 1];
                currentButton.BorderBrush = Brushes.Red;
            }
            else
            {
                shipCount = 0;
            }
        }
        public void EndStandShip()
        {
            SetCell(ship.CellList);
            shipCellAmount = ship.CellShipAmount;
            shipCount--;
            currentTB.Text = shipCount.ToString();
            shipCellAmount = null;

        }

        public void ShipClear()
        {
            foreach (var item in ship.CellList)
            {
                item.IsHitTestVisible = true;
                item.Background = Brushes.GhostWhite;
            }
            shipCellAmount = ship.CellShipAmount;
            ship.CellList.Clear();
            ship.PointsList.Clear();
        }

        public static void SetCell(List<Button> btns)
        {
            int i, j;

            for (int k = 0; k < btns.Count; k++)
            {
                int[] ij = btns[k].Name.Remove(0, 1).Split('_').Select(ii => int.Parse(ii)).ToArray();
                i = ij[0];
                j = ij[1];

                for (int ii = i - 1; ii < i + 2; ii++)
                {
                    for (int jj = j - 1; jj < j + 2; jj++)
                    {
                        if (ii >= 0 && ii <= 9 && jj >= 0 && jj <= 9 && buttons[ii, jj].IsHitTestVisible != false)
                        {
                            buttons[ii, jj].Background = new SolidColorBrush(Colors.LightGray);
                            buttons[ii, jj].IsHitTestVisible = false;
                        }
                    }
                }
            }
        }



        void BtnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int[] ij = button.Name.Remove(0, 1).Split('_').Select(ii => int.Parse(ii)).ToArray();
            int i = ij[0];
            int j = ij[1];

            if (shipCellAmount == null)
            {
                ship = new Ship();
            }

            if (currentButton.Name == "B_S1")
            {
                if (shipCount == null && shipCellAmount == null)
                {
                    shipCount = 4;
                    shipCellAmount = 1;
                    TB_1ShipAmount.Text = shipCount.ToString();
                    currentTB = TB_1ShipAmount;
                }
                else if (shipCellAmount == null)
                {
                    shipCellAmount = 1;
                    currentTB.Text = shipCount.ToString();

                    ship.SetShipConst(shipCellAmount, 4);
                }

            }
            else if (currentButton.Name == "B_S2")
            {
                if (shipCount == null && shipCellAmount == null)
                {
                    shipCount = 3;
                    shipCellAmount = 2;
                    currentTB = TB_2ShipAmount;
                    currentTB.Text = shipCount.ToString();
                }
                else if (shipCellAmount == null)
                {
                    shipCellAmount = 2;
                    currentTB.Text = shipCount.ToString();

                    ship.SetShipConst(shipCellAmount, 3);
                }
            }
            else if (currentButton.Name == "B_S3")
            {
                if (shipCount == null && shipCellAmount == null)
                {
                    shipCount = 2;
                    shipCellAmount = 3;
                    currentTB = TB_3ShipAmount;
                    currentTB.Text = shipCount.ToString();
                }
                else if (shipCellAmount == null)
                {
                    shipCellAmount = 3;
                    currentTB.Text = shipCount.ToString();

                    ship.SetShipConst(shipCellAmount, 2);
                }

            }
            else if (currentButton.Name == "B_S4")
            {
                if (shipCount == 0)
                {
                    MessageBox.Show("Все корабли раставлены");
                    return;
                }
                if (shipCount == null && shipCellAmount == null)
                {
                    shipCount = 1;
                    shipCellAmount = 4;
                    currentTB = TB_4ShipAmount;
                    currentTB.Text = shipCount.ToString();
                }
                else if (shipCellAmount == null)
                {
                    shipCellAmount = 4;
                    currentTB.Text = shipCount.ToString();
                    ship.SetShipConst(shipCellAmount, 1);
                }
            }

            if (ship.ShipCount == null && ship.CellShipAmount == null)
            {
                ship.SetShipConst(shipCellAmount, shipCount);
            }

            if (shipCount > 0)
            {
                //1 клетка
                if (ship.CellShipAmount == shipCellAmount)
                {
                    button.Background = Brushes.DarkGray;
                    button.IsHitTestVisible = false;

                    ship.CellList.Add(button);
                    ship.PointsList.Add(new Point(i, j));

                    shipCellAmount--;

                    if (ship.CellShipAmount == 1) //для однопалубника
                    {
                        EndStandShip();
                        if (shipCount == 0)
                        {
                            EndStandShips();
                        }
                    }
                    else //больше одной клетки
                    {
                        return;
                    }
                }
                else //2 клетка
                {
                    int iCheck = i - ship.PointsList[0].I;
                    int jCheck = j - ship.PointsList[0].J;

                    //проверка рядом клетки или нет
                    if ((jCheck == 1 || jCheck == -1) && (i == ship.PointsList[0].I))
                    {
                        ship.Direction = Direction.Column;
                        if (jCheck == 1) ship.Side = Side.plus;
                        else if (jCheck == -1) ship.Side = Side.minus;
                    }
                    else if ((iCheck == 1 || iCheck == -1) && (j == ship.PointsList[0].J))
                    {
                        ship.Direction = Direction.Row;
                        if (iCheck == 1) ship.Side = Side.plus;
                        else if (iCheck == -1) ship.Side = Side.minus;
                    }
                    else
                    {
                        return;
                    }

                    button.Background = new SolidColorBrush(Colors.DarkGray);
                    button.IsHitTestVisible = false;

                    ship.CellList.Add(button);
                    ship.PointsList.Add(new Point(i, j));
                    shipCellAmount--;

                    //достроение кораблей
                    if (shipCellAmount == 0) //если двухпалубник, то достраивать не надо
                    {
                        EndStandShip();

                        if (shipCount == 0)
                        {
                            EndStandShips();
                        }
                    }
                    else
                    {
                        //3 клетка
                        for (int k = 0; k < 2; k++)
                        {
                            if (ship.Direction == Direction.Column) //если идём по колонкам
                            {
                                if (ship.Side == Side.plus && j + 1 <= 9 && buttons[i, j + 1].IsHitTestVisible == true)
                                {
                                    j++;
                                }
                                else if (ship.Side == Side.minus && j - 1 >= 0 && buttons[i, j - 1].IsHitTestVisible == true)
                                {
                                    j--;
                                }
                                else //нельзя достроить
                                {
                                    ShipClear();
                                    return;
                                }
                            }
                            else
                            {
                                if (ship.Side == Side.plus && i + 1 <= 9 && buttons[i + 1, j].IsHitTestVisible == true)
                                {
                                    i++;
                                }
                                else if (ship.Side == Side.minus && i - 1 >= 0 && buttons[i - 1, j].IsHitTestVisible == true)
                                {
                                    i--;
                                }
                                else
                                {
                                    ShipClear();
                                    return;
                                }
                            }

                            Button btn = buttons[i, j];
                            btn.Background = Brushes.DarkGray;
                            btn.IsHitTestVisible = false;

                            ship.CellList.Add(btn);
                            ship.PointsList.Add(new Point(i, j));
                            shipCellAmount--;

                            if (ship.CellShipAmount == 3)
                            {
                                EndStandShip();
                                if (shipCount == 0)
                                {
                                    EndStandShips();
                                    return;
                                }
                                return;
                            }
                            else if (ship.CellShipAmount == 4 && shipCellAmount == 0)
                            {
                                EndStandShip();
                                if (shipCount == 0)
                                {
                                    EndStandShips();
                                    return;
                                }
                                return;
                            }
                        }


                        if (ship.Direction == Direction.Column)
                        {
                            if (ship.Side == Side.plus && j + 1 <= 9 && buttons[i, j + 1].IsHitTestVisible == true)
                            {
                                j++;
                            }
                            else if (ship.Side == Side.minus && j - 1 >= 0 && buttons[i, j - 1].IsHitTestVisible == true)
                            {
                                j--;
                            }
                            else
                            {
                                foreach (var item in ship.CellList)
                                {
                                    item.IsHitTestVisible = true;
                                    item.Background = Brushes.GhostWhite;
                                }
                                shipCellAmount = ship.CellShipAmount;
                                ship.CellList.Clear();
                                ship.PointsList.Clear();
                                return;
                            }
                        }
                        else
                        {
                            if (ship.Side == Side.plus && i + 1 <= 9 && buttons[i + 1, j].IsHitTestVisible == true)
                            {
                                i++;
                            }
                            else if (ship.Side == Side.minus && i - 1 >= 0 && buttons[i - 1, j].IsHitTestVisible == true)
                            {
                                i--;
                            }
                            else
                            {
                                foreach (var item in ship.CellList)
                                {
                                    item.IsHitTestVisible = true;
                                    item.Background = Brushes.GhostWhite;
                                }
                                shipCellAmount = ship.CellShipAmount;
                                ship.CellList.Clear();
                                ship.PointsList.Clear();
                                return;
                            }
                        }
                    }

                }
            }
        }
    }
}