using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 聊天機器人
{
    public partial class Form1 : Form
    {
        string enter;
        string filename;
        double time = 0;
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            sw = new StreamWriter("score.txt");
            //   IsMdiContainer = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LB_TIME.Text = "Used " + time + "sec";
            time += 1;
        }

        private void 開啟聊天機器人ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 結束程式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 字體ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            TX_out.Font = fontDialog1.Font;
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            TX_out.ForeColor = colorDialog1.Color;
        }

        private void BTN_UPPIC_Click(object sender, EventArgs e)
        {
            DialogResult = openFileDialog1.ShowDialog();
            openFileDialog1.Filter= ("JPG|*.jpg");
            filename = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filename);
        }

        private void BTN_ETR_Click(object sender, EventArgs e)
        {
            enter = tx_in.Text;
            if (enter != "")
            {
                reply();
            }
        }


        private void TX_out_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                enter = tx_in.Text;
                if (enter != "")
                {
                   reply();
                }
            }
            
        }
        private void reply()
        {
            sw.WriteLine("Me: " + enter+"\r\n");
            sw.WriteLine(("Machine:你好" + "\r\n"));
            TX_out.Text += ("Me: " + enter + "\r\n");
            TX_out.Text += ("Machine:你好" + "\r\n");
            tx_in.Text = "";
            sw.Flush();
        }
        
    }
}
