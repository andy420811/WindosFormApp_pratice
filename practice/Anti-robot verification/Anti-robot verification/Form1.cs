using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anti_robot_verification
{
    public partial class Form1 : Form
    {
        int time = 0;
        int[] Locat_fin = new int [8];
        Point init_pos = new Point();
        int BTN_act = 1;
        int[] pos_now = { 0, 0, 1, 0, 2, 0, 3, 0 };
        int shift;
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {

            Random rd = new Random();
            int[] seq = { 0, 1, 2, 3 };
            for(int i = 0; i < 4; i++)
            {
                int j;
                int temp = seq[i];
                seq[i] = seq[j = rd.Next(0, 4)];
                seq[j] = temp;
            }
            
            LB_Q.Location = new Point(LB_Q.Location.X + 15 * (Locat_fin[0] = seq[0]), LB_Q.Location.Y + 20 * (Locat_fin[1] = rd.Next(0, 2)));
            LB_W.Location = new Point(LB_W.Location.X + 15 * (Locat_fin[2] = seq[1]), LB_W.Location.Y + 20 * (Locat_fin[3] = rd.Next(0, 2)));
            LB_E.Location = new Point(LB_E.Location.X + 15 * (Locat_fin[4] = seq[2]), LB_E.Location.Y + 20 * (Locat_fin[5] = rd.Next(0, 2)));
            LB_R.Location = new Point(LB_R.Location.X + 15 * (Locat_fin[6] = seq[3]), LB_R.Location.Y + 20 * (Locat_fin[7] = rd.Next(0, 2)));
            LB_time.Text = "Used ";
            init_pos = new Point(BTN_Q.Location.X, BTN_Q.Location.Y);
            shift = BTN_W.Location.X - BTN_Q.Location.X;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LB_time.Text = "Used " + time + " sec";
            time += 1;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            switch (BTN_act) {
                case 1:
                    BTN_Q.Location = new Point(BTN_Q.Location.X, init_pos.Y + shift * vScrollBar1.Value);
                    pos_now[1] = vScrollBar1.Value;
                    break;
                case 2:
                    BTN_W.Location = new Point(BTN_W.Location.X, init_pos.Y + shift * vScrollBar1.Value);
                    pos_now[3] = vScrollBar1.Value;
                    break;
                case 3:
                    BTN_E.Location = new Point(BTN_E.Location.X, init_pos.Y + shift * vScrollBar1.Value);
                    pos_now[5] = vScrollBar1.Value;
                    break;
                case 4:
                    BTN_R.Location = new Point(BTN_R.Location.X, init_pos.Y + shift * vScrollBar1.Value);
                    pos_now[7] = vScrollBar1.Value;
                    break;
            }
            Check_fin();
        }
        public void Check_fin()
        {
            if(Locat_fin.SequenceEqual(pos_now))
            {
                MessageBox.Show("Done! Used " + time + " Second");
                timer1.Stop();
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            switch (BTN_act)
            {
                case 1:
                    BTN_Q.Location = new Point(init_pos.X + shift * hScrollBar1.Value, BTN_Q.Location.Y);
                    pos_now[0] = hScrollBar1.Value;
                    break;
                case 2:
                    BTN_W.Location = new Point(init_pos.X + shift * hScrollBar1.Value, BTN_W.Location.Y);
                    pos_now[2] = hScrollBar1.Value;
                    break;
                case 3:
                    BTN_E.Location = new Point(init_pos.X + shift * hScrollBar1.Value, BTN_E.Location.Y);
                    pos_now[4] = hScrollBar1.Value;
                    break;
                case 4:
                    BTN_R.Location = new Point(init_pos.X + shift * hScrollBar1.Value, BTN_R.Location.Y);
                    pos_now[6] = hScrollBar1.Value;
                    break;
            }
            Check_fin();
        }

        private void BTN_Q_Click(object sender, EventArgs e)
        {
            BTN_act = 1;
            BTN_Q.BringToFront();
            hScrollBar1.Value = pos_now[0];
            vScrollBar1.Value = pos_now[1];
        }

        private void BTN_W_Click(object sender, EventArgs e)
        {
            BTN_act = 2;
            BTN_W.BringToFront();
            hScrollBar1.Value = pos_now[2];
            vScrollBar1.Value = pos_now[3];
        }

        private void BTN_E_Click(object sender, EventArgs e)
        {
            BTN_act = 3;
            BTN_E.BringToFront();
            hScrollBar1.Value = pos_now[4];
            vScrollBar1.Value = pos_now[5];
        }

        private void BTN_R_Click(object sender, EventArgs e)
        {
            BTN_act = 4;
            BTN_R.BringToFront();
            hScrollBar1.Value = pos_now[6];
            vScrollBar1.Value = pos_now[7];
        }
    }
}
