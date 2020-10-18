namespace practice4_1
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
            this.Encode_button = new System.Windows.Forms.Button();
            this.Decode_button = new System.Windows.Forms.Button();
            this.Encode_Decode_button = new System.Windows.Forms.Button();
            this.record_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.string_label = new System.Windows.Forms.Label();
            this.decode_label = new System.Windows.Forms.Label();
            this.string_textBox = new System.Windows.Forms.TextBox();
            this.decode_shift = new System.Windows.Forms.TextBox();
            this.output_text = new System.Windows.Forms.TextBox();
            this.encode_label = new System.Windows.Forms.Label();
            this.encode_shift = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Encode_button
            // 
            this.Encode_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Encode_button.Location = new System.Drawing.Point(415, 92);
            this.Encode_button.Name = "Encode_button";
            this.Encode_button.Size = new System.Drawing.Size(232, 59);
            this.Encode_button.TabIndex = 0;
            this.Encode_button.Text = "加密";
            this.Encode_button.UseVisualStyleBackColor = true;
            this.Encode_button.Click += new System.EventHandler(this.Encode_button_Click);
            // 
            // Decode_button
            // 
            this.Decode_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Decode_button.Location = new System.Drawing.Point(415, 167);
            this.Decode_button.Name = "Decode_button";
            this.Decode_button.Size = new System.Drawing.Size(232, 59);
            this.Decode_button.TabIndex = 1;
            this.Decode_button.Text = "解密";
            this.Decode_button.UseVisualStyleBackColor = true;
            this.Decode_button.Click += new System.EventHandler(this.Decode_button_Click);
            // 
            // Encode_Decode_button
            // 
            this.Encode_Decode_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.Encode_Decode_button.Location = new System.Drawing.Point(415, 245);
            this.Encode_Decode_button.Name = "Encode_Decode_button";
            this.Encode_Decode_button.Size = new System.Drawing.Size(232, 59);
            this.Encode_Decode_button.TabIndex = 2;
            this.Encode_Decode_button.Text = "解密後再加密";
            this.Encode_Decode_button.UseVisualStyleBackColor = true;
            this.Encode_Decode_button.Click += new System.EventHandler(this.Encode_Decode_button_Click);
            // 
            // record_button
            // 
            this.record_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.record_button.Location = new System.Drawing.Point(415, 323);
            this.record_button.Name = "record_button";
            this.record_button.Size = new System.Drawing.Size(232, 59);
            this.record_button.TabIndex = 3;
            this.record_button.Text = "歷史紀錄";
            this.record_button.UseVisualStyleBackColor = true;
            this.record_button.Click += new System.EventHandler(this.record_button_Click);
            // 
            // OK_button
            // 
            this.OK_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.OK_button.Location = new System.Drawing.Point(24, 323);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(232, 59);
            this.OK_button.TabIndex = 4;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title_label.Location = new System.Drawing.Point(18, 17);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(69, 34);
            this.title_label.TabIndex = 5;
            this.title_label.Text = "標題";
            // 
            // string_label
            // 
            this.string_label.AutoSize = true;
            this.string_label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.string_label.Location = new System.Drawing.Point(18, 92);
            this.string_label.Name = "string_label";
            this.string_label.Size = new System.Drawing.Size(168, 34);
            this.string_label.TabIndex = 6;
            this.string_label.Text = "加(解)密字串";
            // 
            // decode_label
            // 
            this.decode_label.AutoSize = true;
            this.decode_label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.decode_label.Location = new System.Drawing.Point(59, 245);
            this.decode_label.Name = "decode_label";
            this.decode_label.Size = new System.Drawing.Size(141, 34);
            this.decode_label.TabIndex = 7;
            this.decode_label.Text = "位移(解密)";
            // 
            // string_textBox
            // 
            this.string_textBox.Font = new System.Drawing.Font("新細明體", 11F);
            this.string_textBox.Location = new System.Drawing.Point(222, 92);
            this.string_textBox.Name = "string_textBox";
            this.string_textBox.Size = new System.Drawing.Size(188, 27);
            this.string_textBox.TabIndex = 8;
            // 
            // decode_shift
            // 
            this.decode_shift.Font = new System.Drawing.Font("新細明體", 11F);
            this.decode_shift.Location = new System.Drawing.Point(222, 245);
            this.decode_shift.Name = "decode_shift";
            this.decode_shift.Size = new System.Drawing.Size(188, 27);
            this.decode_shift.TabIndex = 9;
            // 
            // output_text
            // 
            this.output_text.Font = new System.Drawing.Font("新細明體", 11F);
            this.output_text.Location = new System.Drawing.Point(24, 66);
            this.output_text.Multiline = true;
            this.output_text.Name = "output_text";
            this.output_text.Size = new System.Drawing.Size(386, 237);
            this.output_text.TabIndex = 10;
            // 
            // encode_label
            // 
            this.encode_label.AutoSize = true;
            this.encode_label.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.encode_label.Location = new System.Drawing.Point(59, 167);
            this.encode_label.Name = "encode_label";
            this.encode_label.Size = new System.Drawing.Size(141, 34);
            this.encode_label.TabIndex = 11;
            this.encode_label.Text = "位移(加密)";
            // 
            // encode_shift
            // 
            this.encode_shift.Font = new System.Drawing.Font("新細明體", 11F);
            this.encode_shift.Location = new System.Drawing.Point(222, 167);
            this.encode_shift.Name = "encode_shift";
            this.encode_shift.Size = new System.Drawing.Size(188, 27);
            this.encode_shift.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 420);
            this.Controls.Add(this.encode_shift);
            this.Controls.Add(this.encode_label);
            this.Controls.Add(this.decode_shift);
            this.Controls.Add(this.string_textBox);
            this.Controls.Add(this.decode_label);
            this.Controls.Add(this.string_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.record_button);
            this.Controls.Add(this.Encode_Decode_button);
            this.Controls.Add(this.Decode_button);
            this.Controls.Add(this.Encode_button);
            this.Controls.Add(this.output_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encode_button;
        private System.Windows.Forms.Button Decode_button;
        private System.Windows.Forms.Button Encode_Decode_button;
        private System.Windows.Forms.Button record_button;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label string_label;
        private System.Windows.Forms.Label decode_label;
        private System.Windows.Forms.TextBox string_textBox;
        private System.Windows.Forms.TextBox decode_shift;
        private System.Windows.Forms.TextBox output_text;
        private System.Windows.Forms.Label encode_label;
        private System.Windows.Forms.TextBox encode_shift;
    }
}

