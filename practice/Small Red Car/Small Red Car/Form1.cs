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
using System.Threading;

namespace Small_Red_Car
{
    public partial class Form1 : Form
    {
        int status = 0;
        int time = 0;
        Car[] cars = new Car[16];
        string filename;
        int count = 0;
        string filename2 = "";
        Button[] buttons;
        StreamReader sr;
        int block_sz = 55;
        int car_act;
        int[,] map = new int[6,6];
        int tar_car;
        public Form1()
        {
            InitializeComponent();
            filename = "test.map";
            Generate();
        }
        private void BTN_car_click(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            for(int i = 0; i < count; i++)
            {
                if(btn == buttons[i])
                {
                    car_act = i;
                }
            }

        }
        private void Generate()
        {
            time = 0;
            count = 0;
            string data;
            timer1.Start();
            LB_time.Text = "Used Time: " + time + " seconds";
            StreamReader sr = new StreamReader(filename);
            do
            {
                data = sr.ReadLine();
                if (data == null) break;
                Gnr_car(data);
                count++;
            } while (true);
            buttons = new Button[count];
            for(int i = 0; i < count; i++)
            {
                buttons[i] = new Button();
                groupBox1.Controls.Add(buttons[i]);
                buttons[i].Enabled = true;
                switch (cars[i].Color)
                {
                    case 0:
                        buttons[i].BackColor = Color.Yellow;
                        break;
                    case 1:
                        buttons[i].BackColor = Color.Red;
                        break;
                    case 2:
                        buttons[i].BackColor = Color.LightBlue;
                        break;
                }
                buttons[i].Click += BTN_car_click;
                buttons[i].Text = cars[i].ID.ToString();
                buttons[i].Location = new Point(5 + cars[i].get_pos.X * block_sz, 12 + cars[i].get_pos.Y * block_sz);
                if (cars[i].get_Dirc == 1)
                {
                    buttons[i].Size = new Size(cars[i].get_Length * block_sz, block_sz);
                }
                else
                {
                    buttons[i].Size = new Size(block_sz, cars[i].get_Length * block_sz);
                }
            }
            Update_map();

        }
        private void Update_map()
        {
            for (int a = 0; a < count; a++)
            {
                int i = cars[a].get_pos.X;
                int j = cars[a].get_pos.Y;
                if (cars[a].get_Dirc == 1)
                {
                    for (; i < cars[a].get_pos.X + cars[a].get_Length; i++)
                    {
                        map[i, j] = cars[a].ID;
                    }
                }
                else
                {
                    for (; j < cars[a].get_pos.Y + cars[a].get_Length; j++)
                    {
                        map[i, j] = cars[a].ID;
                    }
                }
            }
      //      prt();
        }


        private void Gnr_car(string data)
        {
            int[] num = new int[4];
            num[0] = (int)Char.GetNumericValue(data[0]) - 1;
            num[1] = (int)Char.GetNumericValue(data[4]);
            num[2] = (int)Char.GetNumericValue(data[6]);
            num[3] = (int)Char.GetNumericValue(data[8]);
            switch (data[2])
            {
                case 'R':
                    cars[num[0]] = new RedCar(num[1],num[0] + 1);
                    cars[tar_car = num[0]].set_pos(num[2], num[3]);
                    break;
                case 'B':
                    cars[num[0]] = new Bus(num[1], num[0] + 1);
                    cars[num[0]].set_pos(num[2], num[3]); break;
                case 'V':
                    cars[num[0]] = new Van(num[1], num[0] + 1);
                    cars[num[0]].set_pos(num[2], num[3]);
                    break;
            }
        }


        private void BTN_restart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 36; i++) map[i / 6, i % 6] = 0;
            time = 0;
            count = 0;
            string data;
            StreamReader sr = new StreamReader(filename);
            timer1.Start();
            do
            {
                data = sr.ReadLine();
                if (data == null) break;
                Gnr_car(data);
                count++;
            } while (true);
            for (int i = 0; i < count; i++)
            {

                buttons[i].Location = new Point(5 + cars[i].get_pos.X * block_sz, 12 + cars[i].get_pos.Y * block_sz);
                if (cars[i].get_Dirc == 1)
                {
                    buttons[i].Size = new Size(cars[i].get_Length * block_sz, block_sz);
                }
                else
                {
                    buttons[i].Size = new Size(block_sz, cars[i].get_Length * block_sz);
                }
            }
            Update_map();
        }

        private void BTN_import_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text(*.path)|*.path";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                timer2.Start();
                filename2 = openFileDialog1.FileName;
            }
            else return;
            sr = new StreamReader(filename2);
        }


        private void BTN_UP_Click(object sender, EventArgs e)
        {
            int x = cars[car_act].get_pos.X;
            int y = cars[car_act].get_pos.Y;
            int check = y - 1;
            if (y-1 >= 0 && map[x, y - 1] == 0)  {
                if (cars[car_act].move(2))
                {
                    map[x, y + cars[car_act].get_Length - 1] = 0;
                    buttons[car_act].Top -= block_sz;
                    Update_map();
                }
            }
            Check_fin();
        //    prt();

        }
        private void Check_fin()
        {
            int check = 0;
            int i = cars[tar_car].get_pos.X + cars[tar_car].get_Length;
            int j = cars[tar_car].get_pos.Y;
            for (; i < 6; i++)
            {
                check += map[i, j];
            }
            Console.WriteLine(check);
            if(check == 0)
            {
                LB_time.Text = "Used Time: " + time + " seconds";
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("DONE! Used " + time + " seconds");
            }
        }

        private void BTN_down_Click(object sender, EventArgs e)
        {
            int x = cars[car_act].get_pos.X;
            int y1 = cars[car_act].get_pos.Y;
            int y2 = y1;
            if (cars[car_act].get_Dirc == 0) y2 += cars[car_act].get_Length - 1;
            int check = y2 + 1;
            if (check < 6 && map[x, y2 + 1] == 0)
            {
                if (cars[car_act].move(3))
                {
                    map[x, y1] = 0;
                    buttons[car_act].Top += block_sz;
                    Update_map();
                }

            }
            Check_fin();
         //   prt();

        }


        private void BTN_right_Click(object sender, EventArgs e)
        {
            int x = cars[car_act].get_pos.X;
            int y = cars[car_act].get_pos.Y;
            if (cars[car_act].get_Dirc == 1) x += cars[car_act].get_Length - 1;
            int check = x + 1;
            if (check < 6 && map[x + 1, y] == 0)
            {
                if (cars[car_act].move(0))
                {
                    map[x - cars[car_act].get_Length + 1, y] = 0;
                    buttons[car_act].Left += block_sz;
                    Update_map();
                }
            }
            Check_fin();
        //    prt();
        }

        private void BTN_LEFT_Click(object sender, EventArgs e)
        {
            int x = cars[car_act].get_pos.X;
            int y = cars[car_act].get_pos.Y;
            int check = x - 1;
            if (check >= 0 && map[x - 1, y] == 0)
            {
                if (cars[car_act].move(1))
                {
                    map[x + cars[car_act].get_Length - 1, y] = 0;
                    buttons[car_act].Left -= block_sz;
                    Update_map();
                }
            }
            Check_fin();
         //   prt();

        }
        private void prt()
        {
            for(int i = 0; i < 36; i++)
            {
                Console.Write(map[i % 6, i / 6]);
                if(i%6==5)Console.Write("\r\n");
            }
            Console.Write("\r\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            LB_time.Text = "Used Time: " + time + " seconds";
            time++;
        }
        private void Auto_control(string data)
        {
            if (data == null) return;
            car_act = (int)Char.GetNumericValue(data[0]) - 1;
            switch (data[2])
            {
                case 'U':
                    BTN_UP.PerformClick();
                    break;
                case 'D':
                    BTN_down.PerformClick();
                    break;
                case 'L':
                    BTN_LEFT.PerformClick();
                    break;
                case 'R':
                    BTN_right.PerformClick();
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string data;
            data = sr.ReadLine();
            if (data != null)
            {
                Auto_control(data);
            }
        }
    }
}
