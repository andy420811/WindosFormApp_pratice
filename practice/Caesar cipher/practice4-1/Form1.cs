using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice4_1
{
    public partial class Form1 : Form
    {
        public const int Encode = 0; // 加密
        public const int Decode = 1; // 解密
        public const int Encode_Decode = 2; // 加密後解密
        public const int MainMenu = 3; // 回到首頁
        public int status; // 表示現在功能

        public string record_string; // 歷史紀錄字串
        public Form1()
        {
            InitializeComponent();
            Encode_button.Visible = true; // 加密按紐
            Decode_button.Visible = true; // 解密按紐
            Encode_Decode_button.Visible = true; // 加密後再解密按紐
            record_button.Visible = true; // 歷史紀錄按紐
            OK_button.Visible = false; // OK按紐
            title_label.Visible = false; // 標題 Label
            output_text.Visible = false;
            encode_shift.Visible = false;
            encode_label.Visible = false;
            string_label.Visible = false; // 加解密字串 Label
            decode_label.Visible = false; // 位移 Label
            string_textBox.Visible = false; // 加解密字串 textBox
            decode_shift.Visible = false; // 位移 textBox

            /*在這裡加入還需要的Label、Textbox*/



            /**********************************/
        }

        private void Encode_button_Click(object sender, EventArgs e)
        {
            //按 加密按紐
            title_label.Text = "加密";
            Encode_button.Visible = false;
            Decode_button.Visible = false;
            Encode_Decode_button.Visible = false;
            record_button.Visible = false;
            OK_button.Visible = true;
            title_label.Visible = true;
            string_label.Visible = true;
            encode_shift.Visible = true;
            string_textBox.Visible = true;
            encode_label.Visible = true;
            status = Encode;
        }

        private void Decode_button_Click(object sender, EventArgs e)
        {
            //按 解密按紐
            title_label.Text = "解密";
            Encode_button.Visible = false;
            Decode_button.Visible = false;
            Encode_Decode_button.Visible = false;
            record_button.Visible = false;
            OK_button.Visible = true;
            title_label.Visible = true;
            string_label.Visible = true;
            decode_label.Visible = true;
            string_textBox.Visible = true;
            decode_shift.Visible = true;
            status = Decode;
        }

        private void Encode_Decode_button_Click(object sender, EventArgs e)
        {
            title_label.Text = "加解密";
            Encode_button.Visible = false;
            Decode_button.Visible = false;
            Encode_Decode_button.Visible = false;
            record_button.Visible = false;
            encode_label.Visible = true;
            OK_button.Visible = true;
            title_label.Visible = true;
            string_label.Visible = true;
            decode_label.Visible = true;
            string_textBox.Visible = true;
            decode_shift.Visible = true;
            encode_shift.Visible = true;
            //按 加密後再解密按紐
            status = Encode_Decode;

        }

        private void record_button_Click(object sender, EventArgs e)
        {
            Encode_button.Visible = false;
            Decode_button.Visible = false;
            Encode_Decode_button.Visible = false;
            record_button.Visible = false;
            OK_button.Visible = true;
            title_label.Visible = true;
            string_label.Visible = true;
            string_label.Visible = false;
            decode_label.Visible = false;
            string_textBox.Visible = false;
            decode_shift.Visible = false;
            encode_shift.Visible = false;
            output_text.Visible = true;
            output_text.Text = record_string;
            //按 歷史紀錄按紐
            status = MainMenu;
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case Encode:
                    //顯示加密後字串
                    status = MainMenu; // 更改狀態為 回到主頁面
                    encode_label.Visible = false;
                    encode_shift.Visible = false;
                    output_text.Visible = true;
                    string_label.Visible = string_textBox.Visible = false;
                    output_text.Text = Ceasar_Encode_Cipher(string_textBox.Text, int.Parse(encode_shift.Text)); // 取得加密後字串
                    record_string += "***加密***\r\n"+"原字串:"+ string_textBox.Text + "\r\n新字串:"+ output_text.Text + "\r\n***********\r\n"; // 加入歷史紀錄
                    break;
                case Decode:
                    string_label.Visible = string_textBox.Visible = false;
                    output_text.Visible = true;
                    decode_label.Visible = decode_shift.Visible = false;
                    output_text.Text = Ceasar_Decode_Cipher(string_textBox.Text, int.Parse(decode_shift.Text));
                    record_string += "***解密***\r\n" + "原字串:" + string_textBox.Text + "\r\n新字串:" + output_text.Text + "\r\n***********\r\n"; // 加入歷史紀錄
                    //顯示解密後字串
                    status = MainMenu;
                    break;
                case Encode_Decode:
                    string_label.Visible = string_textBox.Visible = false;
                    decode_label.Visible = decode_shift.Visible = false;
                    output_text.Visible = true;
                    encode_shift.Visible = encode_label.Visible = false;
                    string temp = "";
                    string temp2 = "";
                    output_text.Text = "解密後為: ";
                    temp = Ceasar_Decode_Cipher(string_textBox.Text, int.Parse(decode_shift.Text));
                    output_text.Text += temp;
                    output_text.Text += "\r\n再加密後為: ";
                    temp2 = Ceasar_Encode_Cipher(temp, int.Parse(encode_shift.Text));
                    output_text.Text += temp2;
                    output_text.Text += "\r\n";
                    record_string += "***解加密***\r\n" + "原字串:" + string_textBox.Text + "\r\n解密後: "+temp + "\r\n新字串:" + temp2 + "\r\n***********\r\n"; // 加入歷史紀錄
                    //顯示解密與再加密字串
                    status = MainMenu;
                    break;
                case MainMenu:
                    Form1_Load(sender,e);
                    //回到主頁面
                    break;
            }
        }
        public string Ceasar_Encode_Cipher(string input, int shift) // 凱薩密碼加密 輸入字串與位移
        {
            int k;
            string output = ""; // 輸出字串
            /*這裡是凱薩密碼加密演算法*/
            for(int i = 0;i < input.Length; i++)
            {
                if((int)input[i] > 64 && (int)input[i] < 91)
                {
                    k = (int)(input[i] + shift - 65);
                    output += (char)(k < 0 ? (k % 26) + 91 : k + 65);
                }
                else
                {
                    k = (int)(input[i] + shift - 97);
                    output += (char)(k < 0 ? (k % 26) + 123 : k + 97);
                }
            }
            /******************************/

            return output;
        }
        public string Ceasar_Decode_Cipher(string input, int shift) // 凱薩密碼加密 輸入字串與位移
        {
            int k;
            string output = ""; // 輸出字串
            /*這裡是凱薩密碼解密演算法*/
            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] > 64 && (int)input[i] < 91)
                {
                    k = (int)(input[i] - shift - 65);
                    output += (char)(k < 0 ? (k % 26) + 91 : k + 65);
                }
                else {
                    k = (int)(input[i] - shift - 97);
                    output += (char)(k < 0 ? (k % 26) + 123 : k + 97);
                }
            }
            /******************************/

            return output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decode_shift.Text = encode_shift.Text = output_text.Text = string_textBox.Text = "";
            Encode_button.Visible = true; // 加密按紐
            Decode_button.Visible = true; // 解密按紐
            Encode_Decode_button.Visible = true; // 加密後再解密按紐
            record_button.Visible = true; // 歷史紀錄按紐
            OK_button.Visible = false; // OK按紐
            title_label.Visible = false; // 標題 Label
            output_text.Visible = false;
            encode_shift.Visible = false;
            encode_label.Visible = false;
            string_label.Visible = false; // 加解密字串 Label
            decode_label.Visible = false; // 位移 Label
            string_textBox.Visible = false; // 加解密字串 textBox
            decode_shift.Visible = false; // 位移 textBox
        }
    }
}
