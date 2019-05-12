using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    public static class util
    {
        public enum Direction
        {
            Up, Right, Down, Left, NULL
        }
        public static Point MapStartPoint = new Point(30, 30);
        public static int Width = 30;
        public static int Height = 30;
        public static int Size = 25;
        public static Color BackgroundColor = Color.White;
        //public static int Interval = 200;
        public static Color FoodColor = Color.Red;
        public static Color HeadColor = Color.Blue;
        public static Color BlockColor = Color.Black;
        public static int CalcInterval(int Length)
        {
            if (Length >= 0 && Length <= 5)
            {
                return (-25) * Length + 325;
            }
            else if (Length > 5 && Length <= 17)
            {
                return (-10) * Length + 250;
            }
            else
            {
                return 80;
            }
        }
    }
}
