namespace 聊天機器人
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TX_out = new System.Windows.Forms.TextBox();
            this.功能列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟聊天機器人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束程式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tx_in = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_UPPIC = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LB_TIME = new System.Windows.Forms.Label();
            this.BTN_ETR = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能列ToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TX_out
            // 
            this.TX_out.Location = new System.Drawing.Point(42, 54);
            this.TX_out.Multiline = true;
            this.TX_out.Name = "TX_out";
            this.TX_out.Size = new System.Drawing.Size(403, 284);
            this.TX_out.TabIndex = 1;
            // 
            // 功能列ToolStripMenuItem
            // 
            this.功能列ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟聊天機器人ToolStripMenuItem,
            this.結束程式ToolStripMenuItem});
            this.功能列ToolStripMenuItem.Name = "功能列ToolStripMenuItem";
            this.功能列ToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.功能列ToolStripMenuItem.Text = "功能列";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字體ToolStripMenuItem,
            this.顏色ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // 開啟聊天機器人ToolStripMenuItem
            // 
            this.開啟聊天機器人ToolStripMenuItem.Name = "開啟聊天機器人ToolStripMenuItem";
            this.開啟聊天機器人ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.開啟聊天機器人ToolStripMenuItem.Text = "開啟聊天機器人";
            this.開啟聊天機器人ToolStripMenuItem.Click += new System.EventHandler(this.開啟聊天機器人ToolStripMenuItem_Click);
            // 
            // 結束程式ToolStripMenuItem
            // 
            this.結束程式ToolStripMenuItem.Name = "結束程式ToolStripMenuItem";
            this.結束程式ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.結束程式ToolStripMenuItem.Text = "結束程式";
            this.結束程式ToolStripMenuItem.Click += new System.EventHandler(this.結束程式ToolStripMenuItem_Click);
            // 
            // 字體ToolStripMenuItem
            // 
            this.字體ToolStripMenuItem.Name = "字體ToolStripMenuItem";
            this.字體ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.字體ToolStripMenuItem.Text = "字體";
            this.字體ToolStripMenuItem.Click += new System.EventHandler(this.字體ToolStripMenuItem_Click);
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.顏色ToolStripMenuItem.Text = "顏色";
            this.顏色ToolStripMenuItem.Click += new System.EventHandler(this.顏色ToolStripMenuItem_Click);
            // 
            // tx_in
            // 
            this.tx_in.Location = new System.Drawing.Point(42, 360);
            this.tx_in.Name = "tx_in";
            this.tx_in.Size = new System.Drawing.Size(403, 25);
            this.tx_in.TabIndex = 2;
            this.tx_in.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TX_out_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(501, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_UPPIC
            // 
            this.BTN_UPPIC.Location = new System.Drawing.Point(653, 375);
            this.BTN_UPPIC.Name = "BTN_UPPIC";
            this.BTN_UPPIC.Size = new System.Drawing.Size(107, 23);
            this.BTN_UPPIC.TabIndex = 4;
            this.BTN_UPPIC.Text = "上傳照片";
            this.BTN_UPPIC.UseVisualStyleBackColor = true;
            this.BTN_UPPIC.Click += new System.EventHandler(this.BTN_UPPIC_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LB_TIME
            // 
            this.LB_TIME.AutoSize = true;
            this.LB_TIME.Location = new System.Drawing.Point(498, 42);
            this.LB_TIME.Name = "LB_TIME";
            this.LB_TIME.Size = new System.Drawing.Size(32, 15);
            this.LB_TIME.TabIndex = 5;
            this.LB_TIME.Text = "used";
            // 
            // BTN_ETR
            // 
            this.BTN_ETR.Location = new System.Drawing.Point(370, 403);
            this.BTN_ETR.Name = "BTN_ETR";
            this.BTN_ETR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ETR.TabIndex = 6;
            this.BTN_ETR.Text = "送出";
            this.BTN_ETR.UseVisualStyleBackColor = true;
            this.BTN_ETR.Click += new System.EventHandler(this.BTN_ETR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_ETR);
            this.Controls.Add(this.LB_TIME);
            this.Controls.Add(this.BTN_UPPIC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tx_in);
            this.Controls.Add(this.TX_out);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 功能列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟聊天機器人ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束程式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.TextBox TX_out;
        private System.Windows.Forms.TextBox tx_in;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_UPPIC;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LB_TIME;
        private System.Windows.Forms.Button BTN_ETR;
    }
}

