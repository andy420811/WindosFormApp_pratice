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
        }
        Button [] btn = new Button[5];
        double time = 0;
        bool status;
        int act_btn;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Livetime.Text = "生存時間: " + (time += 0.1).ToString("0.00");
            Drop();
            
        }
        private void Drop()
        {
            for(int i = 0; i < act_btn; i++)
            {
                btn[i].Top += 10;
            }
            for(int i = 0; i < act_btn; i++)
            {
                if(btn[i].Bottom >= bound.Top)
                {
                    timer1.Stop();
                    status = false;
                    break;
                }
            }
            if (!status)
            {
                MessageBox.Show("生存時間: " + time.ToString("0.00"));
                Disable_btn();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            btn[0] = Q_btn; btn[1] = W_btn; btn[2] = E_btn;
            btn[3] = R_btn; btn[4] = T_btn;
            for(int i = 0; i < 5; i++)
            {
                btn[i].KeyPress += Q_btn_KeyPress;
                btn[i].Visible = false;
            }
            Livetime.Text = "生存時間: " + time;
        }


        private void Start_btn_Click(object sender, EventArgs e)
        {
            Reset();
            Activate_btn();
            timer1.Start();
        }
        private void Reset()
        {
            status = false;
            comboBox1.Enabled = true;
            Start_btn.Enabled = true;
            Q_btn.Location = new Point(48, 186);
            W_btn.Location = new Point(152, 109);
            E_btn.Location = new Point(252, 186);
            R_btn.Location = new Point(352, 109);
            T_btn.Location = new Point(452, 186);
            time = 0;
            Livetime.Text = "生存時間: " + time;
        }
        private void Disable_btn()
        {
            for (int i = 0; i < act_btn; i++)
            {
                btn[i].Visible = false;
            }
            comboBox1.Enabled = true;
            Start_btn.Enabled = true;
            status = false;
        }
        private void Activate_btn()
        {
            act_btn = Int32.Parse(comboBox1.Text);
            for(int i = 0; i < act_btn; i++)
            {
                btn[i].Visible = true;
            }
            comboBox1.Enabled = false;
            Start_btn.Enabled = false;
            status = true;
        }

        private void Q_btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            int S = 20;
            if (status)
            {
                switch (e.KeyChar)
                {
                    case 'q':
                    case 'Q':
                        Q_btn.Top -= S;
                        break;
                    case 'w':
                    case 'W':
                        W_btn.Top -= S;
                        break;
                    case 'e':
                    case 'E':
                        E_btn.Top -= S;
                        break;
                    case 'r':
                    case 'R':
                        R_btn.Top -= S;
                        break;
                    case 't':
                    case 'T':
                        T_btn.Top -= S;
                        break;
                }
            }
        }
    }
}
