using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 贪吃蛇
{
    class Map
    {
        private Point _mapStart;
        private int _score;
        private Snake _snake;
        private Food _food;
        public Snake snake
        {
            get { return _snake; }
        }
        public int score
        {
            get { return _score; }
        }
        public Map()
        {
            _mapStart = util.MapStartPoint;
            _score = 0;
            _snake = Snake.snake;
            _food = NewFood();
        }
        
        /// <summary>
        /// 生成新食物
        /// </summary>
        /// <returns>新的食物</returns>
        private Food NewFood()
        {
            Random d = new Random();
            bool isAgain=false;
            int x, y;
            do
            {
                x = d.Next(0, util.Width);
                y = d.Next(0, util.Height);
                isAgain = false;
                foreach (var i in _snake.blocks)
                {
                    if (x == i.point.X && y == i.point.Y)
                    {
                        isAgain = true;
                        break;
                    }
                }
            } while (isAgain);
            Food food = new Food(new Point(x, y));
            return food;
        }
        /// <summary>
        /// 显示食物
        /// </summary>
        /// <param name="g"></param>
        public void ShowFood(Graphics g)
        {
            _food.UnShowFood(g);
            _food = NewFood();
            _food.Draw(g);
        }
        /// <summary>
        /// 蛇是否撞墙
        /// </summary>
        /// <returns></returns>
        public bool IsKnockWall()
        {
            bool isKnockWall=false;
            if(_snake.GetHead().point.X*util.Size>=util.Width*util.Size || _snake.GetHead().point.X * util.Size<0 || _snake.GetHead().point.Y * util.Size >=util.Height * util.Size || _snake.GetHead().point.Y * util.Size < 0)
            {
                isKnockWall = true;
            }
            return isKnockWall;
        }
        /// <summary>
        /// 重新开始
        /// </summary>
        /// <param name="g"></param>
        public void Reset(Graphics g)
        {
            _snake.Reset(g);
            _food.UnShowFood(g);
            _score = 0;
        }
        /// <summary>
        /// 蛇是否吃到了食物
        /// </summary>
        /// <returns></returns>
        public bool isEatFood()
        {
            return Point.Equals(_snake.GetHead().point, _food.point);
        }
        /// <summary>
        /// 显示地图
        /// </summary>
        /// <param name="g"></param>
        public void ShowMap(Graphics g)
        {
            _snake.UnShowSnake(g);
            //显示食物
            _food.Draw(g);
            if (isEatFood())
            {
                _snake.SnakeGrowth();
                ShowFood(g);
                _score += 10;
                _snake.ShowSnake(g);
            }
            else
            {
                _snake.SnakeMove();
                _snake.ShowSnake(g);
            }
        }
    }
}
