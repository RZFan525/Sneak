namespace 贪吃蛇
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stbStart = new System.Windows.Forms.ToolStripButton();
            this.tsbPause = new System.Windows.Forms.ToolStripButton();
            this.stbRank = new System.Windows.Forms.ToolStripButton();
            this.tsbOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbSCTip = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(12, 30);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(690, 413);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PbMain_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbStart,
            this.tsbPause,
            this.stbRank,
            this.tsbOut,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(735, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stbStart
            // 
            this.stbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stbStart.Image = ((System.Drawing.Image)(resources.GetObject("stbStart.Image")));
            this.stbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbStart.Name = "stbStart";
            this.stbStart.Size = new System.Drawing.Size(92, 24);
            this.stbStart.Text = "开始游戏(&P)";
            this.stbStart.Click += new System.EventHandler(this.StbStart_Click);
            // 
            // tsbPause
            // 
            this.tsbPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPause.Image = ((System.Drawing.Image)(resources.GetObject("tsbPause.Image")));
            this.tsbPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPause.Name = "tsbPause";
            this.tsbPause.Size = new System.Drawing.Size(61, 24);
            this.tsbPause.Text = "暂停(&L)";
            this.tsbPause.Click += new System.EventHandler(this.TsbPause_Click);
            // 
            // stbRank
            // 
            this.stbRank.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stbRank.Image = ((System.Drawing.Image)(resources.GetObject("stbRank.Image")));
            this.stbRank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbRank.Name = "stbRank";
            this.stbRank.Size = new System.Drawing.Size(93, 24);
            this.stbRank.Text = "查看排名(&K)";
            this.stbRank.Click += new System.EventHandler(this.stbRank_Click);
            // 
            // tsbOut
            // 
            this.tsbOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbOut.Image")));
            this.tsbOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOut.Name = "tsbOut";
            this.tsbOut.Size = new System.Drawing.Size(65, 24);
            this.tsbOut.Text = "退出(&O)";
            this.tsbOut.Click += new System.EventHandler(this.TsbOut_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 24);
            this.toolStripButton1.Text = "设置(&T)";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // timer
            // 
            this.timer.Interval = 150;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lbSCTip
            // 
            this.lbSCTip.AutoSize = true;
            this.lbSCTip.Location = new System.Drawing.Point(600, 11);
            this.lbSCTip.Name = "lbSCTip";
            this.lbSCTip.Size = new System.Drawing.Size(75, 15);
            this.lbSCTip.TabIndex = 2;
            this.lbSCTip.Text = "当前分数:";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.ForeColor = System.Drawing.Color.Red;
            this.lbScore.Location = new System.Drawing.Point(677, 11);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(15, 15);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 470);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbSCTip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbMain);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "贪吃蛇";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stbStart;
        private System.Windows.Forms.ToolStripButton tsbPause;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripButton tsbOut;
        private System.Windows.Forms.ToolStripButton stbRank;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lbSCTip;
        private System.Windows.Forms.Label lbScore;
    }
}

