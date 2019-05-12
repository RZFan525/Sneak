using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贪吃蛇
{
    public partial class new_game_player : Form
    {
        public string name;
        public new_game_player()
        {
            InitializeComponent();
        }
        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("请输入姓名！","提醒",MessageBoxButtons.OK);
            }
            else
            { 
            name = tbName.Text;
            DialogResult = DialogResult.OK;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
