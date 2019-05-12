using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace 贪吃蛇
{
    class Snake  //蛇 因为一次只有一个蛇，所以使用单例模式
    {
        private List<Block> _blocks = new List<Block>();
        private util.Direction _direction;
        private int _length;
        static public Snake _snake = null;
        public int length
        {
            get { return _length; }
        }
        private Snake()
        {
            _blocks.Add(new Block(true, new Point(util.Width / 2, util.Height / 2)));  //初始化时只有蛇头
            _length = 1;
            _direction = util.Direction.NULL;
        }
        static public Snake snake //单例
        {
            get
            {
                if (_snake == null)
                { _snake = new Snake(); }
                return _snake;
            }
        }
        public util.Direction direction //设定前进方向
        {
            get { return _direction; }
            set
            {
                _direction = value;
            }

        }
        public List<Block> blocks
        {
            get { return _blocks; }
        }
        public Block GetHead()
        {
            return _blocks[0];
        }
        /// <summary>
        /// 蛇的转向
        /// </summary>
        /// <param name="nextDirection">想要改变的方向</param>
        public void TurnDirection(util.Direction nextDirection)
        {
            switch (_direction)
            {
                case util.Direction.Up:
                    if (nextDirection == util.Direction.Right)
                        _direction = nextDirection;
                    else if (nextDirection == util.Direction.Left)
                        _direction = nextDirection;
                    break;
                case util.Direction.Down:
                    if (nextDirection == util.Direction.Right)
                        _direction = nextDirection;
                    else if (nextDirection == util.Direction.Left)
                        _direction = nextDirection;
                    break;
                case util.Direction.Left:
                    if (nextDirection == util.Direction.Up)
                        _direction = nextDirection;
                    else if (nextDirection == util.Direction.Down)
                        _direction = nextDirection;
                    break;
                case util.Direction.Right:
                    if (nextDirection == util.Direction.Up)
                        _direction = nextDirection;
                    else if (nextDirection == util.Direction.Down)
                        _direction = nextDirection;
                    break;
            }
        }
        /// <summary>
        /// 蛇吃到食物后长大
        /// </summary>
        public void SnakeGrowth()
        {
            Point newPoint = new Point(_blocks[0].point.X, _blocks[0].point.Y); //新的头部的坐标
            if (_direction == util.Direction.Right)
            {
                newPoint.X++;
            }
            else if (_direction == util.Direction.Left)
            {
                newPoint.X--;
            }
            else if (_direction == util.Direction.Up)
            {
                newPoint.Y--;
            }
            else if (_direction == util.Direction.Down)
            {
                newPoint.Y++;
            }
            _blocks[0].Change();
            Block newHead = new Block(true, newPoint);
            _blocks.Insert(0, newHead);
            _length++;
        }
        /// <summary>
        /// 蛇移动一位
        /// </summary>
        public void SnakeMove()
        {
            SnakeGrowth();
            _length--;
            _blocks.RemoveAt(_length);
        }
        /// <summary>
        /// 把蛇画到地图上
        /// </summary>
        /// <param name="g"></param>
        public void ShowSnake(Graphics g)
        {
            UnShowSnake(g);
            foreach (var i in _blocks)
            {
                i.Draw(g);
            }
        }
        /// <summary>
        /// 是否碰到自己
        /// </summary>
        /// <returns></returns>
        public bool IsTouchSelf()
        {
            bool isTouched = false;
            Point headPoint = _blocks[0].point;
            for (int i = 1; i < _length; i++)
            {
                if (Point.Equals(_blocks[i].point, headPoint))
                {
                    isTouched = true;
                    break;
                }
            }
            return isTouched;
        }
        public void UnShowSnake(Graphics g)
        {
            foreach (var i in _blocks)
            {
                i.UnShowBlock(g);
            }
        }
        /// <summary>
        /// 蛇的重生
        /// </summary>
        public void Reset(Graphics g)
        {
            UnShowSnake(g);
            _snake = new Snake();
        }
    }
}