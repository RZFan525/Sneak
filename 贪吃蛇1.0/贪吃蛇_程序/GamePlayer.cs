using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    public class GamePlayer:IComparable<GamePlayer>
    {
        private string _name;
        private int _score;

        public string name
        {
            get{ return _name; }
        }

        public int score
        {
            get{ return _score; }
        }

        public GamePlayer()
        {

        }
        public GamePlayer(string _name,int _score)
        {
            this._name = _name;
            this._score = _score;
        }
        /// <summary>
        /// 用于排序比较
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public int CompareTo( GamePlayer g)
        {
            return g.score - this.score;
        }

    }
}
