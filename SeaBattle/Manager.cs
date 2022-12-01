using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public static class Manager
    {
        public static Player Player1 { get; set; }
        public static Player Player2 { get; set; }

        static Manager()
        {
            Player1 = new Player();
            Player2 = new Player();
        }
    }
}
