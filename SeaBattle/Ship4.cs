using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SeaBattle
{
    public enum Direction
    {
        Row,
        Column
    }

    public enum Side
    {
        minus,
        plus
    }

    public class Ship
    {
        public List<Button> CellList { get; set; }
        public List<Point> PointsList { get; set; }

        public Direction Direction { get; set; }
        public Side Side { get; set; }

        public int? CellShipAmount { get; private set; }
        public int? ShipCount { get; private set; }

        public Ship()
        {
            CellList = new List<Button>();
            PointsList = new List<Point>();
            CellShipAmount = null;
            ShipCount = null;
        }

        public void SetShipConst(int? shipCellAmount, int? shipCount)
        {
            CellShipAmount = shipCellAmount;
            ShipCount = shipCount;
        }
    }

    public class Ship3
    {

    }

    public class Ship2
    {

    }

    public class Point
    {
        public int I { get; set; }
        public int J { get; set; }

        public Point(int i, int j)
        {
            I = i;
            J = j;
        }
    }
}
