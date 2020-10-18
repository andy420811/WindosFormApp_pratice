using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_small_RPG
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Monster mon = new Monster();
        Hero hero = new Hero();
        private int level = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            Menu_show();
        }
        public void Menu_show()
        {
            LB_select.Visible = true;
            BTN_car_rider.Visible = BTN_car_tank.Visible = BTN_car_war.Visible = true;
            LB_war_name.Visible = LB_war_hp.Visible = LB_war_atk.Visible = LB_war_mp.Visible = false;
            LB_mon_name.Visible = LB_mon_hp.Visible = LB_mon_atk.Visible = LB_mon_mp.Visible = false;
            BTN_cont.Visible = BTN_skl.Visible = BTN_atk.Visible = false;
            LB_level.Visible = TX_out.Visible = false;
        }

        private void BTN_cont_Click(object sender, EventArgs e)
        {
            if (hero.get_HP > 0)
            {
                start();
            }
            else
            {
                Menu_show();
            }
        }

        private void BTN_atk_Click(object sender, EventArgs e)
        {
            TX_out.Text += "玩家攻擊\r\n";
            int damage = hero.Atk(mon);
            TX_out.Text += "敵人受到了" + damage + "點傷害\r\n";
            Battle_from_mon();
        }

        private void BTN_skl_Click(object sender, EventArgs e)
        {
            TX_out.Text += "玩家使用技能";
            if(hero.Skill(mon)){
                switch (hero.career)
                {
                    case 0:
                        TX_out.Text += "，造成及吸取了" + hero.get_ATK + "點傷害\r\n";
                        break;
                    case 1:
                        TX_out.Text += "，舉起了盾牌\r\n";
                        break;
                    case 2:
                        TX_out.Text += "，造成了" + hero.get_ATK * 2 + "點傷害\r\n";
                        break;
                }
            }
            else
            {
                TX_out.Text += "，但MP已經不夠了";
            }
            Battle_from_mon();
        }
        private void start()
        {
            TX_out.Text = "";
            mon = new Monster();
            LB_select.Visible = false;
            BTN_car_rider.Visible = BTN_car_tank.Visible = BTN_car_war.Visible = false;
            LB_war_name.Visible = LB_war_hp.Visible = LB_war_atk.Visible = LB_war_mp.Visible = true;
            LB_mon_name.Visible = LB_mon_hp.Visible = LB_mon_atk.Visible = LB_mon_mp.Visible = true;
            BTN_cont.Visible = BTN_skl.Visible = BTN_atk.Visible = true;
            LB_level.Visible = TX_out.Visible = true;
            BTN_cont.Enabled = false;
            BTN_atk.Enabled = BTN_skl.Enabled = true;
            TX_out.Text += "敵人出現了\r\n";
            Update_Show();
        }
        private void Win()
        {
            Update_Show();
            TX_out.Text += "你贏了，獲得生命和魔力，按下繼續進入下一關\r\n";
            level++;
            hero.Recover(30, 10);
            BTN_atk.Enabled = false;
            BTN_skl.Enabled = false;
            BTN_cont.Enabled = true;
        }
        private void Lose()
        {
            TX_out.Text += "你葛屁了，按下繼續重置遊戲\r\n";
            level = 1;
            BTN_atk.Enabled = false;
            BTN_skl.Enabled = false;
            BTN_cont.Enabled = true;
        }
        private void Battle_from_mon()
        {
            if (mon.get_HP <= 0)
            {
                Win();
            }
            else
            {
                TX_out.Text += "敵人攻擊\r\n";
                switch (mon.Attack(hero))
                {
                    case 0:
                        if (hero.get_Shield)
                        {
                            hero.Recover(mon.get_ATK * 2, 0);
                            TX_out.Text += "玩家舉起盾牌吸收了" + Convert.ToString(mon.get_ATK) + "傷害\r\n";
                            hero.get_Shield = false;
                        }
                        else
                        {
                            TX_out.Text += "玩家受到了" + mon.get_ATK + "點傷害\r\n";
                        }
                        break;
                    case 1:
                        TX_out.Text += "敵人使用技能，強化自己\r\n";
                        break;
                    case 2:
                        TX_out.Text += "敵人使用技能，但魔力不夠，效果並不顯著\r\n";
                        break;
                }

                Update_Show();
                if (hero.get_HP <= 0)
                {
                    Lose();
                }
                else if (mon.get_HP <= 0)
                {
                    Win();
                }
            }
        }
        private void Update_Show()
        {
            TX_out.Text += "\r\n";
            LB_level.Text = "關卡:" + Convert.ToString(level);
            LB_mon_name.Text = "魔物";
            LB_war_hp.Text = "HP:" + Convert.ToString(hero.get_HP);
            LB_war_mp.Text = "MP:" + Convert.ToString(hero.get_MP);
            LB_war_atk.Text = "ATK:" + Convert.ToString(hero.get_ATK);
            LB_mon_hp.Text = "HP:" + Convert.ToString(mon.get_HP);
            LB_mon_mp.Text = "MP:" + Convert.ToString(mon.get_MP);
            LB_mon_atk.Text = "ATK:" + Convert.ToString(mon.get_ATK);
        }
        private void BTN_car_war_Click(object sender, EventArgs e)
        {
            hero = new Hero(0);
            LB_war_name.Text = "戰士";
            start();
        }

        private void BTN_car_tank_Click(object sender, EventArgs e)
        {
            hero = new Hero(1);
            LB_war_name.Text = "坦克";
            start();
        }

        private void BTN_car_rider_Click(object sender, EventArgs e)
        {
            hero = new Hero(2);
            LB_war_name.Text = "遊俠";
            start();
        }
    }
}
