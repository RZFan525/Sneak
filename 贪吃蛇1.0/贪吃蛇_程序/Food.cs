using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 贪吃蛇
{
    class Food : Node
    {
        public Color color //颜色
        {
            get { return _color; }
        }
        public Point point //坐标
        {
            get { return _point; }
        }
        public int size //大小
        {
            get { return _size; }
        }
        public override void Draw(Graphics g) //画到picturebox上
        {
            SolidBrush pen = new SolidBrush(color);
            g.FillRectangle(pen, point.X * size,  point.Y * size, size - 1, size - 1);
        }
        public Food( Point point) //构造函数
        {
            this._point = point;
            _color =util.FoodColor;
            _size = util.Size;
        }
        public void UnShowFood(Graphics g)
        {
            SolidBrush pen = new SolidBrush(util.BackgroundColor);
            g.FillRectangle(pen, point.X * size,  point.Y * size, size - 1, size - 1);
        }
    }
}
