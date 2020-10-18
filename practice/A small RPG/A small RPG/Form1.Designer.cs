namespace A_small_RPG
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
            this.LB_select = new System.Windows.Forms.Label();
            this.LB_level = new System.Windows.Forms.Label();
            this.LB_war_name = new System.Windows.Forms.Label();
            this.LB_war_hp = new System.Windows.Forms.Label();
            this.LB_war_mp = new System.Windows.Forms.Label();
            this.LB_war_atk = new System.Windows.Forms.Label();
            this.LB_mon_name = new System.Windows.Forms.Label();
            this.LB_mon_hp = new System.Windows.Forms.Label();
            this.LB_mon_mp = new System.Windows.Forms.Label();
            this.LB_mon_atk = new System.Windows.Forms.Label();
            this.TX_out = new System.Windows.Forms.TextBox();
            this.BTN_atk = new System.Windows.Forms.Button();
            this.BTN_skl = new System.Windows.Forms.Button();
            this.BTN_cont = new System.Windows.Forms.Button();
            this.BTN_car_war = new System.Windows.Forms.Button();
            this.BTN_car_tank = new System.Windows.Forms.Button();
            this.BTN_car_rider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_select
            // 
            this.LB_select.AutoSize = true;
            this.LB_select.Font = new System.Drawing.Font("微軟正黑體", 11.33333F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_select.Location = new System.Drawing.Point(41, 28);
            this.LB_select.Name = "LB_select";
            this.LB_select.Size = new System.Drawing.Size(78, 22);
            this.LB_select.TabIndex = 0;
            this.LB_select.Text = "選擇職業";
            // 
            // LB_level
            // 
            this.LB_level.AutoSize = true;
            this.LB_level.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_level.Location = new System.Drawing.Point(628, 33);
            this.LB_level.Name = "LB_level";
            this.LB_level.Size = new System.Drawing.Size(37, 15);
            this.LB_level.TabIndex = 1;
            this.LB_level.Text = "關卡";
            // 
            // LB_war_name
            // 
            this.LB_war_name.AutoSize = true;
            this.LB_war_name.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_war_name.Location = new System.Drawing.Point(45, 101);
            this.LB_war_name.Name = "LB_war_name";
            this.LB_war_name.Size = new System.Drawing.Size(77, 24);
            this.LB_war_name.TabIndex = 2;
            this.LB_war_name.Text = "warrior";
            // 
            // LB_war_hp
            // 
            this.LB_war_hp.AutoSize = true;
            this.LB_war_hp.Location = new System.Drawing.Point(45, 136);
            this.LB_war_hp.Name = "LB_war_hp";
            this.LB_war_hp.Size = new System.Drawing.Size(21, 14);
            this.LB_war_hp.TabIndex = 2;
            this.LB_war_hp.Text = "hp";
            // 
            // LB_war_mp
            // 
            this.LB_war_mp.AutoSize = true;
            this.LB_war_mp.Location = new System.Drawing.Point(45, 160);
            this.LB_war_mp.Name = "LB_war_mp";
            this.LB_war_mp.Size = new System.Drawing.Size(24, 14);
            this.LB_war_mp.TabIndex = 2;
            this.LB_war_mp.Text = "mp";
            // 
            // LB_war_atk
            // 
            this.LB_war_atk.AutoSize = true;
            this.LB_war_atk.Location = new System.Drawing.Point(45, 188);
            this.LB_war_atk.Name = "LB_war_atk";
            this.LB_war_atk.Size = new System.Drawing.Size(24, 14);
            this.LB_war_atk.TabIndex = 2;
            this.LB_war_atk.Text = "atk";
            // 
            // LB_mon_name
            // 
            this.LB_mon_name.AutoSize = true;
            this.LB_mon_name.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_mon_name.Location = new System.Drawing.Point(639, 101);
            this.LB_mon_name.Name = "LB_mon_name";
            this.LB_mon_name.Size = new System.Drawing.Size(83, 24);
            this.LB_mon_name.TabIndex = 2;
            this.LB_mon_name.Text = "monster";
            // 
            // LB_mon_hp
            // 
            this.LB_mon_hp.AutoSize = true;
            this.LB_mon_hp.Location = new System.Drawing.Point(639, 136);
            this.LB_mon_hp.Name = "LB_mon_hp";
            this.LB_mon_hp.Size = new System.Drawing.Size(21, 14);
            this.LB_mon_hp.TabIndex = 2;
            this.LB_mon_hp.Text = "hp";
            // 
            // LB_mon_mp
            // 
            this.LB_mon_mp.AutoSize = true;
            this.LB_mon_mp.Location = new System.Drawing.Point(639, 160);
            this.LB_mon_mp.Name = "LB_mon_mp";
            this.LB_mon_mp.Size = new System.Drawing.Size(24, 14);
            this.LB_mon_mp.TabIndex = 2;
            this.LB_mon_mp.Text = "mp";
            // 
            // LB_mon_atk
            // 
            this.LB_mon_atk.AutoSize = true;
            this.LB_mon_atk.Location = new System.Drawing.Point(639, 188);
            this.LB_mon_atk.Name = "LB_mon_atk";
            this.LB_mon_atk.Size = new System.Drawing.Size(24, 14);
            this.LB_mon_atk.TabIndex = 2;
            this.LB_mon_atk.Text = "atk";
            // 
            // TX_out
            // 
            this.TX_out.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TX_out.Location = new System.Drawing.Point(224, 66);
            this.TX_out.Multiline = true;
            this.TX_out.Name = "TX_out";
            this.TX_out.ReadOnly = true;
            this.TX_out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TX_out.Size = new System.Drawing.Size(333, 293);
            this.TX_out.TabIndex = 3;
            // 
            // BTN_atk
            // 
            this.BTN_atk.Font = new System.Drawing.Font("新細明體", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_atk.Location = new System.Drawing.Point(45, 239);
            this.BTN_atk.Name = "BTN_atk";
            this.BTN_atk.Size = new System.Drawing.Size(111, 42);
            this.BTN_atk.TabIndex = 4;
            this.BTN_atk.Text = "攻擊";
            this.BTN_atk.UseVisualStyleBackColor = true;
            this.BTN_atk.Click += new System.EventHandler(this.BTN_atk_Click);
            // 
            // BTN_skl
            // 
            this.BTN_skl.Font = new System.Drawing.Font("新細明體", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_skl.Location = new System.Drawing.Point(45, 297);
            this.BTN_skl.Name = "BTN_skl";
            this.BTN_skl.Size = new System.Drawing.Size(111, 42);
            this.BTN_skl.TabIndex = 4;
            this.BTN_skl.Text = "技能";
            this.BTN_skl.UseVisualStyleBackColor = true;
            this.BTN_skl.Click += new System.EventHandler(this.BTN_skl_Click);
            // 
            // BTN_cont
            // 
            this.BTN_cont.Font = new System.Drawing.Font("新細明體", 11.33333F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_cont.Location = new System.Drawing.Point(642, 338);
            this.BTN_cont.Name = "BTN_cont";
            this.BTN_cont.Size = new System.Drawing.Size(111, 42);
            this.BTN_cont.TabIndex = 4;
            this.BTN_cont.Text = "繼續";
            this.BTN_cont.UseVisualStyleBackColor = true;
            this.BTN_cont.Click += new System.EventHandler(this.BTN_cont_Click);
            // 
            // BTN_car_war
            // 
            this.BTN_car_war.Location = new System.Drawing.Point(134, 25);
            this.BTN_car_war.Name = "BTN_car_war";
            this.BTN_car_war.Size = new System.Drawing.Size(75, 23);
            this.BTN_car_war.TabIndex = 5;
            this.BTN_car_war.Text = "戰士";
            this.BTN_car_war.UseVisualStyleBackColor = true;
            this.BTN_car_war.Click += new System.EventHandler(this.BTN_car_war_Click);
            // 
            // BTN_car_tank
            // 
            this.BTN_car_tank.Location = new System.Drawing.Point(224, 25);
            this.BTN_car_tank.Name = "BTN_car_tank";
            this.BTN_car_tank.Size = new System.Drawing.Size(75, 23);
            this.BTN_car_tank.TabIndex = 5;
            this.BTN_car_tank.Text = "坦克";
            this.BTN_car_tank.UseVisualStyleBackColor = true;
            this.BTN_car_tank.Click += new System.EventHandler(this.BTN_car_tank_Click);
            // 
            // BTN_car_rider
            // 
            this.BTN_car_rider.Location = new System.Drawing.Point(316, 25);
            this.BTN_car_rider.Name = "BTN_car_rider";
            this.BTN_car_rider.Size = new System.Drawing.Size(75, 23);
            this.BTN_car_rider.TabIndex = 5;
            this.BTN_car_rider.Text = "遊俠";
            this.BTN_car_rider.UseVisualStyleBackColor = true;
            this.BTN_car_rider.Click += new System.EventHandler(this.BTN_car_rider_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 406);
            this.Controls.Add(this.BTN_car_rider);
            this.Controls.Add(this.BTN_car_tank);
            this.Controls.Add(this.BTN_car_war);
            this.Controls.Add(this.BTN_cont);
            this.Controls.Add(this.BTN_skl);
            this.Controls.Add(this.BTN_atk);
            this.Controls.Add(this.TX_out);
            this.Controls.Add(this.LB_mon_atk);
            this.Controls.Add(this.LB_war_atk);
            this.Controls.Add(this.LB_mon_mp);
            this.Controls.Add(this.LB_war_mp);
            this.Controls.Add(this.LB_mon_hp);
            this.Controls.Add(this.LB_war_hp);
            this.Controls.Add(this.LB_mon_name);
            this.Controls.Add(this.LB_war_name);
            this.Controls.Add(this.LB_level);
            this.Controls.Add(this.LB_select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_select;
        private System.Windows.Forms.Label LB_level;
        private System.Windows.Forms.Label LB_war_name;
        private System.Windows.Forms.Label LB_war_hp;
        private System.Windows.Forms.Label LB_war_mp;
        private System.Windows.Forms.Label LB_war_atk;
        private System.Windows.Forms.Label LB_mon_name;
        private System.Windows.Forms.Label LB_mon_hp;
        private System.Windows.Forms.Label LB_mon_mp;
        private System.Windows.Forms.Label LB_mon_atk;
        private System.Windows.Forms.TextBox TX_out;
        private System.Windows.Forms.Button BTN_atk;
        private System.Windows.Forms.Button BTN_skl;
        private System.Windows.Forms.Button BTN_cont;
        private System.Windows.Forms.Button BTN_car_war;
        private System.Windows.Forms.Button BTN_car_tank;
        private System.Windows.Forms.Button BTN_car_rider;
    }
}

