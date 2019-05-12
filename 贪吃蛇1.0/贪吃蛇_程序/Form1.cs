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
    public partial class Form1 : Form
    {
        private Map map;
        private Gamer_Player game_Player;
        private Graphics g;
        private bool change; //1可改变方向 0不可改变方向

        public Form1()
        {
            InitializeComponent();
            change = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && map.snake.direction != util.Direction.Down && change)
            {
                map.snake.direction = util.Direction.Up;
                change = false;
            }
            if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && map.snake.direction != util.Direction.Up && change)
            {
                map.snake.direction = util.Direction.Down;
                change = false;
            }
            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && map.snake.direction != util.Direction.Right && change)
            {
                map.snake.direction = util.Direction.Left;
                change = false;
            }
            if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && map.snake.direction != util.Direction.Left && change)
            {
                map.snake.direction = util.Direction.Right;
                change = false;
            }
        }

        private void PbMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = new Bitmap(util.Width * util.Size, util.Height * util.Size);
            pbMain.Image = image;
            new Setting().UseSetting();
            map = new Map();
			game_Player = new Gamer_Player();
            this.Location = new Point(5, 5);
            this.pbMain.Location = util.MapStartPoint;
            this.pbMain.Size = new Size(util.Width * util.Size, util.Height * util.Size);
            this.Size = new Size(util.Width * util.Size + 60, util.Height * util.Size + 80);
            this.pbMain.BackColor = util.BackgroundColor;
            this.lbScore.Location = new Point(this.Right - 45,11);
            this.lbSCTip.Location= new Point(this.Right - 100, 11);
            g = Graphics.FromImage(pbMain.Image);
            map.ShowMap(g);
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            change = true;
            timer.Interval = util.CalcInterval(map.snake.length);

            if (map.snake.IsTouchSelf() || map.IsKnockWall())
            {
                timer.Stop();
                MessageBox.Show("游戏结束!  得分:" + map.score.ToString(), "提示", MessageBoxButtons.OK);
                game_Player.judgeGamePlayers(map.score);
                game_Player.ShowDialog();
                map.Reset(g);
                map = null;
                map = new Map();
            }
            this.lbScore.Text = map.score.ToString();
            map.ShowMap(g);
            pbMain.Refresh();
        }

       private void StbStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void TsbPause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void TsbOut_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult result = MessageBox.Show("确定退出?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (game_Player.JudgeBreak(map.score))//如果打破记录给出提示，是否保存
                {
                    DialogResult result1 = MessageBox.Show("你已打破记录，点击“是”进行保存", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        game_Player.judgeGamePlayers(map.score);
                        game_Player.ShowDialog();
                    }
                }
                this.Close();
            }
            else
            {
                timer.Start();
            }
        }

        private void stbRank_Click(object sender, EventArgs e)
        {
            timer.Stop();
            game_Player.ShowDialog();
            timer.Start();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Setting setting = new Setting();
            setting.ShowDialog();
            timer.Start();
        }
    }
}