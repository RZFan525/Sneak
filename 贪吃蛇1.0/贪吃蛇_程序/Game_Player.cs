using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace 贪吃蛇
{
    public partial class Gamer_Player : Form
    {
        private List<GamePlayer> _gamePlayers;
        private string path;

        public List<GamePlayer> gamePlayers
        {
            get { return _gamePlayers; }
        }

        public Gamer_Player()
        {
            InitializeComponent();
            _gamePlayers = new List<GamePlayer>();
            path = System.AppDomain.CurrentDomain.BaseDirectory + "GamePlayers.txt";//获取当前路径并加上玩家名单文本文件            
            if (!File.Exists(path))
            {
                File.Create(path).Close();//创建完之后关闭 不然该进程一直使用该文件

            }
            _gamePlayers.Capacity = 10;//限定可以存贮玩家记录的个数
            update();
        }

        /// <summary>
        /// 判断当前分数是否打破记录
        /// </summary>
        public Boolean JudgeBreak(int map_score)
        {
            if (_gamePlayers.Count <10 && map_score != 0)
                return true;
            else
            {
                for (int i = _gamePlayers.Count - 1; i >= 0; i--)
                {
                    GamePlayer g1 = _gamePlayers[i];
                    if (map_score > g1.score)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public void judgeGamePlayers(int map_score)
        {
            if (JudgeBreak(map_score))
            {
                new_game_player ngp = new new_game_player();
                if (ngp.ShowDialog() == DialogResult.OK)
                {
                    GamePlayer gp;
                    gp = new GamePlayer(ngp.name, map_score);
                    if (_gamePlayers.Count < 10)
                    {
                        _gamePlayers.Add(gp);
                        _gamePlayers.Sort();
                    }
                    else
                    {
                        _gamePlayers.RemoveAt(_gamePlayers.Count - 1);
                        for(int i=_gamePlayers.Count-1;i>=0;i--)
                        {
                            if(gp.score<=_gamePlayers[i].score)
                            {
                                _gamePlayers.Insert(i + 1, gp);
                                break;
                            }
                        }
                    }
                    FileStream fs1 = new FileStream(path, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs1);
                    fs1.Seek(0, SeekOrigin.Begin);
                    fs1.SetLength(0);
                    for(int i=0;i<_gamePlayers.Count;i++)
                    {
                        sw.WriteLine(_gamePlayers[i].name);
                        sw.WriteLine(_gamePlayers[i].score);
                    }
                    sw.Close();
                    fs1.Close();
                }
            }
        }
        /// <summary>
        /// 从文件读取用户信息
        /// </summary>
        public void update()
        {
            _gamePlayers.Clear();
            using (StreamReader sr = File.OpenText(path))//从文件读取玩家信息
            {
                string s;
                int r;
                while ((s = sr.ReadLine()) != null)
                {
                    int.TryParse(sr.ReadLine(),out r);
                    GamePlayer g = new GamePlayer(s, r);
                    _gamePlayers.Add(g);
                }

            }
            _gamePlayers.Sort();
        }



        private void Game_Player_Load(object sender, EventArgs e)
        {
            update();
            lvGameplayer.Items.Clear();
            for (int i = 0; i < _gamePlayers.Count; i++)//显示到listview上
            {
                GamePlayer g = _gamePlayers[i];
                ListViewItem item = new ListViewItem(new string[] { g.name, g.score.ToString(), (i + 1).ToString() });
                lvGameplayer.Items.Add(item);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定清除所有玩家数据？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                File.Create(path).Close();//创建完之后关闭 不然该进程一直使用该文件
                lvGameplayer.Items.Clear();
                _gamePlayers.Clear();
            }
        }
    }
}
