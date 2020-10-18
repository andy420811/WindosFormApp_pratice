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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ob = new System.Windows.Forms.RadioButton();
            this.og = new System.Windows.Forms.RadioButton();
            this.ok = new System.Windows.Forms.RadioButton();
            this.om = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sb = new System.Windows.Forms.RadioButton();
            this.sg = new System.Windows.Forms.RadioButton();
            this.sk = new System.Windows.Forms.RadioButton();
            this.sm = new System.Windows.Forms.RadioButton();
            this.in_unit = new System.Windows.Forms.TextBox();
            this.convert_uni = new System.Windows.Forms.Button();
            this.o_uni = new System.Windows.Forms.TextBox();
            this.convert_but = new System.Windows.Forms.Button();
            this.in_base = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.o2b = new System.Windows.Forms.Label();
            this.o8b = new System.Windows.Forms.Label();
            this.o10b = new System.Windows.Forms.Label();
            this.o16b = new System.Windows.Forms.Label();
            this.s_2bit = new System.Windows.Forms.RadioButton();
            this.s_8bit = new System.Windows.Forms.RadioButton();
            this.s_10bit = new System.Windows.Forms.RadioButton();
            this.s_16bit = new System.Windows.Forms.RadioButton();
            this.tar_2bit = new System.Windows.Forms.CheckBox();
            this.tar_8bit = new System.Windows.Forms.CheckBox();
            this.tar_16bit = new System.Windows.Forms.CheckBox();
            this.tar_10bit = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("標楷體", 11F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.o_uni);
            this.tabPage1.Controls.Add(this.convert_uni);
            this.tabPage1.Controls.Add(this.in_unit);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "資料單位轉換";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tar_16bit);
            this.tabPage2.Controls.Add(this.tar_10bit);
            this.tabPage2.Controls.Add(this.tar_8bit);
            this.tabPage2.Controls.Add(this.tar_2bit);
            this.tabPage2.Controls.Add(this.s_16bit);
            this.tabPage2.Controls.Add(this.s_10bit);
            this.tabPage2.Controls.Add(this.s_8bit);
            this.tabPage2.Controls.Add(this.s_2bit);
            this.tabPage2.Controls.Add(this.o16b);
            this.tabPage2.Controls.Add(this.o10b);
            this.tabPage2.Controls.Add(this.o8b);
            this.tabPage2.Controls.Add(this.o2b);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.in_base);
            this.tabPage2.Controls.Add(this.convert_but);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "進位制轉換";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ob);
            this.groupBox2.Controls.Add(this.og);
            this.groupBox2.Controls.Add(this.ok);
            this.groupBox2.Controls.Add(this.om);
            this.groupBox2.Location = new System.Drawing.Point(419, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 221);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "目標";
            // 
            // ob
            // 
            this.ob.AutoSize = true;
            this.ob.Location = new System.Drawing.Point(16, 26);
            this.ob.Name = "ob";
            this.ob.Size = new System.Drawing.Size(71, 21);
            this.ob.TabIndex = 0;
            this.ob.TabStop = true;
            this.ob.Text = "Bytes";
            this.ob.UseVisualStyleBackColor = true;
            // 
            // og
            // 
            this.og.AutoSize = true;
            this.og.Location = new System.Drawing.Point(16, 164);
            this.og.Name = "og";
            this.og.Size = new System.Drawing.Size(107, 21);
            this.og.TabIndex = 0;
            this.og.TabStop = true;
            this.og.Text = "Gibibytes";
            this.og.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.AutoSize = true;
            this.ok.Location = new System.Drawing.Point(16, 71);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(107, 21);
            this.ok.TabIndex = 0;
            this.ok.TabStop = true;
            this.ok.Text = "Kibibytes";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // om
            // 
            this.om.AutoSize = true;
            this.om.Location = new System.Drawing.Point(16, 117);
            this.om.Name = "om";
            this.om.Size = new System.Drawing.Size(107, 21);
            this.om.TabIndex = 0;
            this.om.TabStop = true;
            this.om.Text = "Mebibytes";
            this.om.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sb);
            this.groupBox1.Controls.Add(this.sg);
            this.groupBox1.Controls.Add(this.sk);
            this.groupBox1.Controls.Add(this.sm);
            this.groupBox1.Location = new System.Drawing.Point(73, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 221);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "來源";
            // 
            // sb
            // 
            this.sb.AutoSize = true;
            this.sb.Location = new System.Drawing.Point(16, 26);
            this.sb.Name = "sb";
            this.sb.Size = new System.Drawing.Size(71, 21);
            this.sb.TabIndex = 0;
            this.sb.TabStop = true;
            this.sb.Text = "Bytes";
            this.sb.UseVisualStyleBackColor = true;
            // 
            // sg
            // 
            this.sg.AutoSize = true;
            this.sg.Location = new System.Drawing.Point(16, 164);
            this.sg.Name = "sg";
            this.sg.Size = new System.Drawing.Size(107, 21);
            this.sg.TabIndex = 0;
            this.sg.TabStop = true;
            this.sg.Text = "Gibibytes";
            this.sg.UseVisualStyleBackColor = true;
            // 
            // sk
            // 
            this.sk.AutoSize = true;
            this.sk.Location = new System.Drawing.Point(16, 71);
            this.sk.Name = "sk";
            this.sk.Size = new System.Drawing.Size(107, 21);
            this.sk.TabIndex = 0;
            this.sk.TabStop = true;
            this.sk.Text = "Kibibytes";
            this.sk.UseVisualStyleBackColor = true;
            // 
            // sm
            // 
            this.sm.AutoSize = true;
            this.sm.Location = new System.Drawing.Point(16, 117);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(107, 21);
            this.sm.TabIndex = 0;
            this.sm.TabStop = true;
            this.sm.Text = "Mebibytes";
            this.sm.UseVisualStyleBackColor = true;
            // 
            // in_unit
            // 
            this.in_unit.Location = new System.Drawing.Point(73, 322);
            this.in_unit.Name = "in_unit";
            this.in_unit.Size = new System.Drawing.Size(260, 27);
            this.in_unit.TabIndex = 5;
            // 
            // convert_uni
            // 
            this.convert_uni.Location = new System.Drawing.Point(340, 322);
            this.convert_uni.Name = "convert_uni";
            this.convert_uni.Size = new System.Drawing.Size(75, 23);
            this.convert_uni.TabIndex = 6;
            this.convert_uni.Text = "->";
            this.convert_uni.UseVisualStyleBackColor = true;
            this.convert_uni.Click += new System.EventHandler(this.convert_uni_Click);
            // 
            // o_uni
            // 
            this.o_uni.Location = new System.Drawing.Point(421, 322);
            this.o_uni.Name = "o_uni";
            this.o_uni.Size = new System.Drawing.Size(278, 27);
            this.o_uni.TabIndex = 7;
            // 
            // convert_but
            // 
            this.convert_but.Font = new System.Drawing.Font("標楷體", 10F);
            this.convert_but.Location = new System.Drawing.Point(542, 44);
            this.convert_but.Name = "convert_but";
            this.convert_but.Size = new System.Drawing.Size(75, 23);
            this.convert_but.TabIndex = 0;
            this.convert_but.Text = "convert";
            this.convert_but.UseVisualStyleBackColor = true;
            this.convert_but.Click += new System.EventHandler(this.convert_but_Click);
            // 
            // in_base
            // 
            this.in_base.Location = new System.Drawing.Point(109, 44);
            this.in_base.Name = "in_base";
            this.in_base.Size = new System.Drawing.Size(408, 27);
            this.in_base.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "來源";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "目標";
            // 
            // o2b
            // 
            this.o2b.AutoSize = true;
            this.o2b.Font = new System.Drawing.Font("標楷體", 15F);
            this.o2b.Location = new System.Drawing.Point(106, 191);
            this.o2b.Name = "o2b";
            this.o2b.Size = new System.Drawing.Size(82, 23);
            this.o2b.TabIndex = 4;
            this.o2b.Text = "label3";
            // 
            // o8b
            // 
            this.o8b.AutoSize = true;
            this.o8b.Font = new System.Drawing.Font("標楷體", 15F);
            this.o8b.Location = new System.Drawing.Point(106, 228);
            this.o8b.Name = "o8b";
            this.o8b.Size = new System.Drawing.Size(82, 23);
            this.o8b.TabIndex = 5;
            this.o8b.Text = "label4";
            // 
            // o10b
            // 
            this.o10b.AutoSize = true;
            this.o10b.Font = new System.Drawing.Font("標楷體", 15F);
            this.o10b.Location = new System.Drawing.Point(106, 264);
            this.o10b.Name = "o10b";
            this.o10b.Size = new System.Drawing.Size(82, 23);
            this.o10b.TabIndex = 6;
            this.o10b.Text = "label5";
            // 
            // o16b
            // 
            this.o16b.AutoSize = true;
            this.o16b.Font = new System.Drawing.Font("標楷體", 15F);
            this.o16b.Location = new System.Drawing.Point(106, 301);
            this.o16b.Name = "o16b";
            this.o16b.Size = new System.Drawing.Size(82, 23);
            this.o16b.TabIndex = 7;
            this.o16b.Text = "label6";
            // 
            // s_2bit
            // 
            this.s_2bit.AutoSize = true;
            this.s_2bit.Location = new System.Drawing.Point(110, 94);
            this.s_2bit.Name = "s_2bit";
            this.s_2bit.Size = new System.Drawing.Size(80, 21);
            this.s_2bit.TabIndex = 8;
            this.s_2bit.TabStop = true;
            this.s_2bit.Text = "二進位";
            this.s_2bit.UseVisualStyleBackColor = true;
            // 
            // s_8bit
            // 
            this.s_8bit.AutoSize = true;
            this.s_8bit.Location = new System.Drawing.Point(250, 94);
            this.s_8bit.Name = "s_8bit";
            this.s_8bit.Size = new System.Drawing.Size(80, 21);
            this.s_8bit.TabIndex = 9;
            this.s_8bit.TabStop = true;
            this.s_8bit.Text = "八進位";
            this.s_8bit.UseVisualStyleBackColor = true;
            // 
            // s_10bit
            // 
            this.s_10bit.AutoSize = true;
            this.s_10bit.Location = new System.Drawing.Point(390, 94);
            this.s_10bit.Name = "s_10bit";
            this.s_10bit.Size = new System.Drawing.Size(80, 21);
            this.s_10bit.TabIndex = 10;
            this.s_10bit.TabStop = true;
            this.s_10bit.Text = "十進位";
            this.s_10bit.UseVisualStyleBackColor = true;
            // 
            // s_16bit
            // 
            this.s_16bit.AutoSize = true;
            this.s_16bit.Location = new System.Drawing.Point(530, 94);
            this.s_16bit.Name = "s_16bit";
            this.s_16bit.Size = new System.Drawing.Size(98, 21);
            this.s_16bit.TabIndex = 11;
            this.s_16bit.TabStop = true;
            this.s_16bit.Text = "十六進位";
            this.s_16bit.UseVisualStyleBackColor = true;
            // 
            // tar_2bit
            // 
            this.tar_2bit.AutoSize = true;
            this.tar_2bit.Location = new System.Drawing.Point(109, 135);
            this.tar_2bit.Name = "tar_2bit";
            this.tar_2bit.Size = new System.Drawing.Size(81, 21);
            this.tar_2bit.TabIndex = 16;
            this.tar_2bit.Text = "二進位";
            this.tar_2bit.UseVisualStyleBackColor = true;
            // 
            // tar_8bit
            // 
            this.tar_8bit.AutoSize = true;
            this.tar_8bit.Location = new System.Drawing.Point(250, 135);
            this.tar_8bit.Name = "tar_8bit";
            this.tar_8bit.Size = new System.Drawing.Size(81, 21);
            this.tar_8bit.TabIndex = 16;
            this.tar_8bit.Text = "八進位";
            this.tar_8bit.UseVisualStyleBackColor = true;
            // 
            // tar_16bit
            // 
            this.tar_16bit.AutoSize = true;
            this.tar_16bit.Location = new System.Drawing.Point(530, 135);
            this.tar_16bit.Name = "tar_16bit";
            this.tar_16bit.Size = new System.Drawing.Size(99, 21);
            this.tar_16bit.TabIndex = 17;
            this.tar_16bit.Text = "十六進位";
            this.tar_16bit.UseVisualStyleBackColor = true;
            // 
            // tar_10bit
            // 
            this.tar_10bit.AutoSize = true;
            this.tar_10bit.Location = new System.Drawing.Point(389, 135);
            this.tar_10bit.Name = "tar_10bit";
            this.tar_10bit.Size = new System.Drawing.Size(81, 21);
            this.tar_10bit.TabIndex = 18;
            this.tar_10bit.Text = "十進位";
            this.tar_10bit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox o_uni;
        private System.Windows.Forms.Button convert_uni;
        private System.Windows.Forms.TextBox in_unit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ob;
        private System.Windows.Forms.RadioButton og;
        private System.Windows.Forms.RadioButton ok;
        private System.Windows.Forms.RadioButton om;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sb;
        private System.Windows.Forms.RadioButton sg;
        private System.Windows.Forms.RadioButton sk;
        private System.Windows.Forms.RadioButton sm;
        private System.Windows.Forms.CheckBox tar_16bit;
        private System.Windows.Forms.CheckBox tar_10bit;
        private System.Windows.Forms.CheckBox tar_8bit;
        private System.Windows.Forms.CheckBox tar_2bit;
        private System.Windows.Forms.RadioButton s_16bit;
        private System.Windows.Forms.RadioButton s_10bit;
        private System.Windows.Forms.RadioButton s_8bit;
        private System.Windows.Forms.RadioButton s_2bit;
        private System.Windows.Forms.Label o16b;
        private System.Windows.Forms.Label o10b;
        private System.Windows.Forms.Label o8b;
        private System.Windows.Forms.Label o2b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox in_base;
        private System.Windows.Forms.Button convert_but;
    }
}

