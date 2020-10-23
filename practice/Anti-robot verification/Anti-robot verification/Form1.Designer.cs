namespace Anti_robot_verification
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
            this.GP_Ans = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_time = new System.Windows.Forms.Label();
            this.BTN_Q = new System.Windows.Forms.Button();
            this.BTN_W = new System.Windows.Forms.Button();
            this.BTN_E = new System.Windows.Forms.Button();
            this.BTN_R = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.LB_Q = new System.Windows.Forms.Label();
            this.LB_W = new System.Windows.Forms.Label();
            this.LB_E = new System.Windows.Forms.Label();
            this.LB_R = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GP_Ans.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GP_Ans
            // 
            this.GP_Ans.Controls.Add(this.LB_R);
            this.GP_Ans.Controls.Add(this.LB_E);
            this.GP_Ans.Controls.Add(this.LB_W);
            this.GP_Ans.Controls.Add(this.LB_Q);
            this.GP_Ans.Location = new System.Drawing.Point(59, 23);
            this.GP_Ans.Name = "GP_Ans";
            this.GP_Ans.Size = new System.Drawing.Size(135, 85);
            this.GP_Ans.TabIndex = 0;
            this.GP_Ans.TabStop = false;
            this.GP_Ans.Text = "Answer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vScrollBar1);
            this.groupBox2.Controls.Add(this.hScrollBar1);
            this.groupBox2.Controls.Add(this.BTN_R);
            this.groupBox2.Controls.Add(this.BTN_E);
            this.groupBox2.Controls.Add(this.BTN_W);
            this.groupBox2.Controls.Add(this.BTN_Q);
            this.groupBox2.Location = new System.Drawing.Point(59, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User_input";
            // 
            // LB_time
            // 
            this.LB_time.AutoSize = true;
            this.LB_time.Location = new System.Drawing.Point(229, 23);
            this.LB_time.Name = "LB_time";
            this.LB_time.Size = new System.Drawing.Size(35, 15);
            this.LB_time.TabIndex = 2;
            this.LB_time.Text = "Used";
            // 
            // BTN_Q
            // 
            this.BTN_Q.Location = new System.Drawing.Point(45, 40);
            this.BTN_Q.Name = "BTN_Q";
            this.BTN_Q.Size = new System.Drawing.Size(90, 90);
            this.BTN_Q.TabIndex = 0;
            this.BTN_Q.Text = "Q";
            this.BTN_Q.UseVisualStyleBackColor = true;
            this.BTN_Q.Click += new System.EventHandler(this.BTN_Q_Click);
            // 
            // BTN_W
            // 
            this.BTN_W.Location = new System.Drawing.Point(141, 40);
            this.BTN_W.Name = "BTN_W";
            this.BTN_W.Size = new System.Drawing.Size(90, 90);
            this.BTN_W.TabIndex = 1;
            this.BTN_W.Text = "W";
            this.BTN_W.UseVisualStyleBackColor = true;
            this.BTN_W.Click += new System.EventHandler(this.BTN_W_Click);
            // 
            // BTN_E
            // 
            this.BTN_E.Location = new System.Drawing.Point(237, 40);
            this.BTN_E.Name = "BTN_E";
            this.BTN_E.Size = new System.Drawing.Size(90, 90);
            this.BTN_E.TabIndex = 1;
            this.BTN_E.Text = "E";
            this.BTN_E.UseVisualStyleBackColor = true;
            this.BTN_E.Click += new System.EventHandler(this.BTN_E_Click);
            // 
            // BTN_R
            // 
            this.BTN_R.Location = new System.Drawing.Point(333, 40);
            this.BTN_R.Name = "BTN_R";
            this.BTN_R.Size = new System.Drawing.Size(90, 90);
            this.BTN_R.TabIndex = 1;
            this.BTN_R.Text = "R";
            this.BTN_R.UseVisualStyleBackColor = true;
            this.BTN_R.Click += new System.EventHandler(this.BTN_R_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(45, 214);
            this.hScrollBar1.Maximum = 3;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(378, 26);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(449, 40);
            this.vScrollBar1.Maximum = 1;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(33, 200);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // LB_Q
            // 
            this.LB_Q.AutoSize = true;
            this.LB_Q.Location = new System.Drawing.Point(21, 25);
            this.LB_Q.Name = "LB_Q";
            this.LB_Q.Size = new System.Drawing.Size(17, 15);
            this.LB_Q.TabIndex = 0;
            this.LB_Q.Text = "Q";
            // 
            // LB_W
            // 
            this.LB_W.AutoSize = true;
            this.LB_W.Location = new System.Drawing.Point(21, 25);
            this.LB_W.Name = "LB_W";
            this.LB_W.Size = new System.Drawing.Size(20, 15);
            this.LB_W.TabIndex = 0;
            this.LB_W.Text = "W";
            // 
            // LB_E
            // 
            this.LB_E.AutoSize = true;
            this.LB_E.Location = new System.Drawing.Point(21, 25);
            this.LB_E.Name = "LB_E";
            this.LB_E.Size = new System.Drawing.Size(16, 15);
            this.LB_E.TabIndex = 0;
            this.LB_E.Text = "E";
            // 
            // LB_R
            // 
            this.LB_R.AutoSize = true;
            this.LB_R.Location = new System.Drawing.Point(21, 25);
            this.LB_R.Name = "LB_R";
            this.LB_R.Size = new System.Drawing.Size(16, 15);
            this.LB_R.TabIndex = 0;
            this.LB_R.Text = "R";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 416);
            this.Controls.Add(this.LB_time);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GP_Ans);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GP_Ans.ResumeLayout(false);
            this.GP_Ans.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GP_Ans;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button BTN_R;
        private System.Windows.Forms.Button BTN_E;
        private System.Windows.Forms.Button BTN_W;
        private System.Windows.Forms.Button BTN_Q;
        private System.Windows.Forms.Label LB_time;
        private System.Windows.Forms.Label LB_R;
        private System.Windows.Forms.Label LB_E;
        private System.Windows.Forms.Label LB_W;
        private System.Windows.Forms.Label LB_Q;
        private System.Windows.Forms.Timer timer1;
    }
}

