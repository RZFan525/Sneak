using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贪吃蛇
{
    public partial class Setting : Form
    {
        private  Color HeadColor;
        private  Color BlockColor;
        private  Color FoodColor;
        private int size;
        private string path;
        public Setting()
        {
            InitializeComponent();
            path = System.AppDomain.CurrentDomain.BaseDirectory + "Setting.txt";//获取当前路径            
            if (!File.Exists(path))
            {
                FileStream fs1 = new FileStream(path,FileMode.Create,FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(util.HeadColor.ToArgb().ToString());
                sw.WriteLine(util.BlockColor.ToArgb().ToString());
                sw.WriteLine(util.FoodColor.ToArgb().ToString());
                sw.WriteLine(util.Size.ToString());
                sw.Close();
                fs1.Close();
            }
            using (StreamReader sr = new StreamReader(path))//从文件读取设置信息
            {
                HeadColor = Color.FromArgb(int.Parse(sr.ReadLine()));
                BlockColor = Color.FromArgb(int.Parse(sr.ReadLine()));
                FoodColor = Color.FromArgb(int.Parse(sr.ReadLine()));
                bool isSuccessful = int.TryParse(sr.ReadLine(), out size);
                if(!isSuccessful)
                {
                    size = util.Size;
                }
            }
            //改变按钮颜色
            this.btHC.BackColor = HeadColor;
            this.btBC.BackColor = BlockColor;
            this.btFC.BackColor = FoodColor;
            this.TrBSize.Value = size;
        }
        /// <summary>
        /// 将设置里的信息应用到游戏里
        /// </summary>
        public void UseSetting()
        {
            util.HeadColor = HeadColor;
            util.BlockColor = BlockColor;
            util.FoodColor = FoodColor;
            util.Size = size;
        }
        private void BtHC_Click(object sender, EventArgs e)//选蛇头颜色
        {
            ColorDialog ColorForm = new ColorDialog();
            if(ColorForm.ShowDialog()==DialogResult.OK)
            {
                Color getColor = ColorForm.Color;
                HeadColor = getColor;
                this.btHC.BackColor = getColor;
            }
        }

        private void BtBC_Click(object sender, EventArgs e)//选蛇身颜色
        {
            ColorDialog ColorForm = new ColorDialog();
            if (ColorForm.ShowDialog() == DialogResult.OK)
            {
                Color getColor = ColorForm.Color;
                BlockColor = getColor;
                this.btBC.BackColor = getColor;
            }
        }
        private void BtFC_Click(object sender, EventArgs e)//选食物颜色
        {
            ColorDialog ColorForm = new ColorDialog();
            if (ColorForm.ShowDialog() == DialogResult.OK)
            {
                Color getColor = ColorForm.Color;
                FoodColor = getColor;
                this.btFC.BackColor = getColor;
            }
        }
        private void TrBSize_ValueChanged(object sender, EventArgs e)//选界面大小
        {
            size = this.TrBSize.Value;
        }
        private void BtSave_Click(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            fs1.Seek(0, SeekOrigin.Begin);
            fs1.SetLength(0);
            sw.WriteLine(HeadColor.ToArgb().ToString());
            sw.WriteLine(BlockColor.ToArgb().ToString());
            sw.WriteLine(FoodColor.ToArgb().ToString());
            sw.WriteLine(size.ToString());
            sw.Close();
            fs1.Close();
            MessageBox.Show("下次启动时生效！", "提醒");
            this.Close();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
