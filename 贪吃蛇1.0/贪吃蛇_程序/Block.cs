using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace 贪吃蛇
{
    class Block : Node //蛇身体的一块
    {
        private bool _isHead; //是否为头部
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
            g.FillRectangle(pen, point.X * size, point.Y * size, size - 1, size - 1);
        }
        public Block(bool isHead,Point point) //构造函数
        {
            this._isHead = isHead;
            this._point = point;
            if(_isHead==true)
            {
                _color = util.HeadColor;
            }
            else
            {
                _color = util.BlockColor;
            }
            _size = util.Size;
        }
        public void Change()
        {
            if(_isHead)
            {
                _isHead = false;
                _color = util.BlockColor;
            }
            else
            {
                _isHead = true;
                _color = util.HeadColor;
            }
        }
        public void UnShowBlock(Graphics g)
        {
            SolidBrush pen = new SolidBrush(util.BackgroundColor);
            g.FillRectangle(pen, point.X * size, point.Y * size, size - 1, size - 1);
        }

    }
}
