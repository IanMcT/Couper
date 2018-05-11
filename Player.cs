using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Couper
{
    class Player
    {
        public Point point;
        public int speed;
        public Player(Point p, int s) {
            point = p;
            speed = s;
        }
        public Point update()
        {
            point.X = point.X + speed;
            return point;
        }
    }
}
