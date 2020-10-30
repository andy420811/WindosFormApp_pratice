namespace Small_Red_Car
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
            this.LB_time = new System.Windows.Forms.Label();
            this.BTN_import = new System.Windows.Forms.Button();
            this.BTN_restart = new System.Windows.Forms.Button();
            this.BTN_UP = new System.Windows.Forms.Button();
            this.BTN_down = new System.Windows.Forms.Button();
            this.BTN_LEFT = new System.Windows.Forms.Button();
            this.BTN_right = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LB_time
            // 
            this.LB_time.AutoSize = true;
            this.LB_time.Location = new System.Drawing.Point(427, 20);
            this.LB_time.Name = "LB_time";
            this.LB_time.Size = new System.Drawing.Size(41, 14);
            this.LB_time.TabIndex = 0;
            this.LB_time.Text = "label1";
            // 
            // BTN_import
            // 
            this.BTN_import.Location = new System.Drawing.Point(430, 49);
            this.BTN_import.Name = "BTN_import";
            this.BTN_import.Size = new System.Drawing.Size(185, 32);
            this.BTN_import.TabIndex = 1;
            this.BTN_import.Text = "Import Auto Solve Step";
            this.BTN_import.UseVisualStyleBackColor = true;
            this.BTN_import.Click += new System.EventHandler(this.BTN_import_Click);
            // 
            // BTN_restart
            // 
            this.BTN_restart.Location = new System.Drawing.Point(430, 87);
            this.BTN_restart.Name = "BTN_restart";
            this.BTN_restart.Size = new System.Drawing.Size(185, 32);
            this.BTN_restart.TabIndex = 1;
            this.BTN_restart.Text = "Restart";
            this.BTN_restart.UseVisualStyleBackColor = true;
            this.BTN_restart.Click += new System.EventHandler(this.BTN_restart_Click);
            // 
            // BTN_UP
            // 
            this.BTN_UP.Location = new System.Drawing.Point(481, 200);
            this.BTN_UP.Name = "BTN_UP";
            this.BTN_UP.Size = new System.Drawing.Size(70, 70);
            this.BTN_UP.TabIndex = 2;
            this.BTN_UP.Text = "UP";
            this.BTN_UP.UseVisualStyleBackColor = true;
            this.BTN_UP.Click += new System.EventHandler(this.BTN_UP_Click);
            // 
            // BTN_down
            // 
            this.BTN_down.Location = new System.Drawing.Point(481, 276);
            this.BTN_down.Name = "BTN_down";
            this.BTN_down.Size = new System.Drawing.Size(70, 70);
            this.BTN_down.TabIndex = 2;
            this.BTN_down.Text = "DOWN";
            this.BTN_down.UseVisualStyleBackColor = true;
            this.BTN_down.Click += new System.EventHandler(this.BTN_down_Click);
            // 
            // BTN_LEFT
            // 
            this.BTN_LEFT.Location = new System.Drawing.Point(405, 276);
            this.BTN_LEFT.Name = "BTN_LEFT";
            this.BTN_LEFT.Size = new System.Drawing.Size(70, 70);
            this.BTN_LEFT.TabIndex = 2;
            this.BTN_LEFT.Text = "LEFT";
            this.BTN_LEFT.UseVisualStyleBackColor = true;
            this.BTN_LEFT.Click += new System.EventHandler(this.BTN_LEFT_Click);
            // 
            // BTN_right
            // 
            this.BTN_right.Location = new System.Drawing.Point(557, 276);
            this.BTN_right.Name = "BTN_right";
            this.BTN_right.Size = new System.Drawing.Size(70, 70);
            this.BTN_right.TabIndex = 2;
            this.BTN_right.Text = "RIGHT";
            this.BTN_right.UseVisualStyleBackColor = true;
            this.BTN_right.Click += new System.EventHandler(this.BTN_right_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 350);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_LEFT);
            this.Controls.Add(this.BTN_right);
            this.Controls.Add(this.BTN_down);
            this.Controls.Add(this.BTN_UP);
            this.Controls.Add(this.BTN_restart);
            this.Controls.Add(this.BTN_import);
            this.Controls.Add(this.LB_time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_time;
        private System.Windows.Forms.Button BTN_import;
        private System.Windows.Forms.Button BTN_restart;
        private System.Windows.Forms.Button BTN_UP;
        private System.Windows.Forms.Button BTN_down;
        private System.Windows.Forms.Button BTN_LEFT;
        private System.Windows.Forms.Button BTN_right;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer2;
    }
}

