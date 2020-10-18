namespace WindowsFormsApp1
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
            this.Q_btn = new System.Windows.Forms.Button();
            this.W_btn = new System.Windows.Forms.Button();
            this.E_btn = new System.Windows.Forms.Button();
            this.R_btn = new System.Windows.Forms.Button();
            this.T_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Livetime = new System.Windows.Forms.Label();
            this.Start_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Q_btn
            // 
            this.Q_btn.Location = new System.Drawing.Point(48, 186);
            this.Q_btn.Name = "Q_btn";
            this.Q_btn.Size = new System.Drawing.Size(75, 75);
            this.Q_btn.TabIndex = 0;
            this.Q_btn.Text = "Q";
            this.Q_btn.UseVisualStyleBackColor = true;
            this.Q_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Q_btn_KeyPress);
            // 
            // W_btn
            // 
            this.W_btn.Location = new System.Drawing.Point(152, 109);
            this.W_btn.Name = "W_btn";
            this.W_btn.Size = new System.Drawing.Size(75, 75);
            this.W_btn.TabIndex = 0;
            this.W_btn.Text = "W";
            this.W_btn.UseVisualStyleBackColor = true;
            // 
            // E_btn
            // 
            this.E_btn.Location = new System.Drawing.Point(252, 186);
            this.E_btn.Name = "E_btn";
            this.E_btn.Size = new System.Drawing.Size(75, 75);
            this.E_btn.TabIndex = 0;
            this.E_btn.Text = "E";
            this.E_btn.UseVisualStyleBackColor = true;
            // 
            // R_btn
            // 
            this.R_btn.Location = new System.Drawing.Point(363, 109);
            this.R_btn.Name = "R_btn";
            this.R_btn.Size = new System.Drawing.Size(75, 75);
            this.R_btn.TabIndex = 0;
            this.R_btn.Text = "R";
            this.R_btn.UseVisualStyleBackColor = true;
            // 
            // T_btn
            // 
            this.T_btn.Location = new System.Drawing.Point(475, 186);
            this.T_btn.Name = "T_btn";
            this.T_btn.Size = new System.Drawing.Size(75, 75);
            this.T_btn.TabIndex = 0;
            this.T_btn.Text = "T";
            this.T_btn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(653, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 11F);
            this.label1.Location = new System.Drawing.Point(597, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "數量:";
            // 
            // Livetime
            // 
            this.Livetime.AutoSize = true;
            this.Livetime.Font = new System.Drawing.Font("新細明體", 11F);
            this.Livetime.Location = new System.Drawing.Point(611, 92);
            this.Livetime.Name = "Livetime";
            this.Livetime.Size = new System.Drawing.Size(46, 17);
            this.Livetime.TabIndex = 3;
            this.Livetime.Text = "label2";
            // 
            // Start_btn
            // 
            this.Start_btn.Font = new System.Drawing.Font("Calibri", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.Location = new System.Drawing.Point(600, 139);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(75, 34);
            this.Start_btn.TabIndex = 4;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bound
            // 
            this.bound.AutoSize = true;
            this.bound.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bound.Location = new System.Drawing.Point(0, 436);
            this.bound.MinimumSize = new System.Drawing.Size(700, 0);
            this.bound.Name = "bound";
            this.bound.Size = new System.Drawing.Size(700, 14);
            this.bound.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bound);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Livetime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.T_btn);
            this.Controls.Add(this.R_btn);
            this.Controls.Add(this.E_btn);
            this.Controls.Add(this.W_btn);
            this.Controls.Add(this.Q_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Q_btn;
        private System.Windows.Forms.Button W_btn;
        private System.Windows.Forms.Button E_btn;
        private System.Windows.Forms.Button R_btn;
        private System.Windows.Forms.Button T_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Livetime;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label bound;
    }
}

