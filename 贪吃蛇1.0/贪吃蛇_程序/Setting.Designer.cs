namespace 贪吃蛇
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbHC = new System.Windows.Forms.Label();
            this.lbBC = new System.Windows.Forms.Label();
            this.lbFC = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.btHC = new System.Windows.Forms.Button();
            this.btBC = new System.Windows.Forms.Button();
            this.btFC = new System.Windows.Forms.Button();
            this.TrBSize = new System.Windows.Forms.TrackBar();
            this.lbMinSize = new System.Windows.Forms.Label();
            this.lbMaxSize = new System.Windows.Forms.Label();
            this.lbMiddleSize = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrBSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHC
            // 
            this.lbHC.AutoSize = true;
            this.lbHC.Location = new System.Drawing.Point(43, 32);
            this.lbHC.Name = "lbHC";
            this.lbHC.Size = new System.Drawing.Size(82, 15);
            this.lbHC.TabIndex = 0;
            this.lbHC.Text = "蛇头颜色：";
            // 
            // lbBC
            // 
            this.lbBC.AutoSize = true;
            this.lbBC.Location = new System.Drawing.Point(43, 89);
            this.lbBC.Name = "lbBC";
            this.lbBC.Size = new System.Drawing.Size(82, 15);
            this.lbBC.TabIndex = 0;
            this.lbBC.Text = "蛇身颜色：";
            // 
            // lbFC
            // 
            this.lbFC.AutoSize = true;
            this.lbFC.Location = new System.Drawing.Point(43, 162);
            this.lbFC.Name = "lbFC";
            this.lbFC.Size = new System.Drawing.Size(82, 15);
            this.lbFC.TabIndex = 0;
            this.lbFC.Text = "食物颜色：";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(43, 224);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(82, 15);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "界面大小：";
            // 
            // btHC
            // 
            this.btHC.BackColor = System.Drawing.SystemColors.Control;
            this.btHC.Location = new System.Drawing.Point(121, 28);
            this.btHC.Name = "btHC";
            this.btHC.Size = new System.Drawing.Size(75, 23);
            this.btHC.TabIndex = 1;
            this.btHC.UseVisualStyleBackColor = false;
            this.btHC.Click += new System.EventHandler(this.BtHC_Click);
            // 
            // btBC
            // 
            this.btBC.BackColor = System.Drawing.SystemColors.Control;
            this.btBC.Location = new System.Drawing.Point(121, 85);
            this.btBC.Name = "btBC";
            this.btBC.Size = new System.Drawing.Size(75, 23);
            this.btBC.TabIndex = 1;
            this.btBC.UseVisualStyleBackColor = false;
            this.btBC.Click += new System.EventHandler(this.BtBC_Click);
            // 
            // btFC
            // 
            this.btFC.BackColor = System.Drawing.SystemColors.Control;
            this.btFC.Location = new System.Drawing.Point(121, 154);
            this.btFC.Name = "btFC";
            this.btFC.Size = new System.Drawing.Size(75, 23);
            this.btFC.TabIndex = 1;
            this.btFC.UseVisualStyleBackColor = false;
            this.btFC.Click += new System.EventHandler(this.BtFC_Click);
            // 
            // TrBSize
            // 
            this.TrBSize.LargeChange = 1;
            this.TrBSize.Location = new System.Drawing.Point(121, 224);
            this.TrBSize.Maximum = 25;
            this.TrBSize.Minimum = 15;
            this.TrBSize.Name = "TrBSize";
            this.TrBSize.Size = new System.Drawing.Size(179, 56);
            this.TrBSize.TabIndex = 2;
            this.TrBSize.TickFrequency = 5;
            this.TrBSize.Value = 15;
            this.TrBSize.ValueChanged += new System.EventHandler(this.TrBSize_ValueChanged);
            // 
            // lbMinSize
            // 
            this.lbMinSize.AutoSize = true;
            this.lbMinSize.Location = new System.Drawing.Point(130, 264);
            this.lbMinSize.Name = "lbMinSize";
            this.lbMinSize.Size = new System.Drawing.Size(23, 15);
            this.lbMinSize.TabIndex = 3;
            this.lbMinSize.Text = "15";
            // 
            // lbMaxSize
            // 
            this.lbMaxSize.AutoSize = true;
            this.lbMaxSize.Location = new System.Drawing.Point(268, 264);
            this.lbMaxSize.Name = "lbMaxSize";
            this.lbMaxSize.Size = new System.Drawing.Size(23, 15);
            this.lbMaxSize.TabIndex = 3;
            this.lbMaxSize.Text = "25";
            // 
            // lbMiddleSize
            // 
            this.lbMiddleSize.AutoSize = true;
            this.lbMiddleSize.Location = new System.Drawing.Point(199, 265);
            this.lbMiddleSize.Name = "lbMiddleSize";
            this.lbMiddleSize.Size = new System.Drawing.Size(23, 15);
            this.lbMiddleSize.TabIndex = 3;
            this.lbMiddleSize.Text = "20";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(46, 310);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(107, 36);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "保存并退出";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(172, 310);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(107, 36);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 374);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbMiddleSize);
            this.Controls.Add(this.lbMaxSize);
            this.Controls.Add(this.lbMinSize);
            this.Controls.Add(this.TrBSize);
            this.Controls.Add(this.btFC);
            this.Controls.Add(this.btBC);
            this.Controls.Add(this.btHC);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbFC);
            this.Controls.Add(this.lbBC);
            this.Controls.Add(this.lbHC);
            this.Name = "Setting";
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.TrBSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHC;
        private System.Windows.Forms.Label lbBC;
        private System.Windows.Forms.Label lbFC;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Button btHC;
        private System.Windows.Forms.Button btBC;
        private System.Windows.Forms.Button btFC;
        private System.Windows.Forms.TrackBar TrBSize;
        private System.Windows.Forms.Label lbMinSize;
        private System.Windows.Forms.Label lbMaxSize;
        private System.Windows.Forms.Label lbMiddleSize;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
    }
}