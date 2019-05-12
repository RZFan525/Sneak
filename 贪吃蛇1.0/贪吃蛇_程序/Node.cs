using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    abstract class Node //抽象父类，结点
    {
        protected Color _color; //颜色
        protected int _size;  //大小
        protected Point _point; //坐标
        public abstract void Draw(Graphics g);
    }
}
