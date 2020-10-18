using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start();
        }
        public void start()
        {
            Random rnd = new Random();
            int check_num = rnd.Next(1000, 10000);
            check_num_label.Text = Convert.ToString(check_num);
            Button[] key = new Button[10];
            enter_num.Text = "";
            /*for (int i = 0; i < 10; i++)
            {
                key[i] = new Button();
                key[i].SetBounds(70 + i%3 * 50, 155 + i/3 * 50, 45, 45);
                key[i].Text = "" + Convert.ToString(i);
                Controls.Add(key[i]);
            }
            */
        }
        private void buttom_swap(ref Button a)
        {
            for(int i = 0; i < 10;i++)
            {

            }
        }
        
        private void check_buttom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Form1_Load(sender,e);
            int check_num = rnd.Next(1000, 10000);
            check_num_label.Text = Convert.ToString(check_num);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enter_num.Text += "2";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            enter_num.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enter_num.Text += "3";
        }
        int count = 0;
        private void enter_num_TextChanged(object sender, EventArgs e)
        {
            if(enter_num.Text.Length == 4)
            {
                if(check_num_label.Text == enter_num.Text){
                    MessageBox.Show("驗證碼正確");
                    Application.Exit();
                }else{
                    count++;
                    MessageBox.Show("驗證碼錯誤" + count + "次!");
                    if(count == 3)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enter_num.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enter_num.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            enter_num.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            enter_num.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            enter_num.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            enter_num.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            enter_num.Text += "0";
        }

        private void enter_num_Click(object sender, EventArgs e)
        {

        }
    }
}
