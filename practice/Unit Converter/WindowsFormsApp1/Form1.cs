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
            o_uni.ReadOnly = true;
            o2b.Visible = o8b.Visible = o10b.Visible = o16b.Visible = false;
        }

        private void convert_uni_Click(object sender, EventArgs e)
        {
            double num = 0;
            try
            {
                num = Int32.Parse(in_unit.Text);
                int shift = Unit_case();
                num *= Math.Pow(1024, shift);
                o_uni.Text = Convert.ToString(num);
            }
            catch
            {
                MessageBox.Show("輸入含不只數字", "錯誤");
            }
  
        }
        
        private int Unit_case()
        {
            int uc = -1;
            if (sb.Checked) uc = 1;
            if (sk.Checked) uc = 2;
            if (sm.Checked) uc = 3;
            if (sg.Checked) uc = 4;
            if (ob.Checked) uc -= 1;
            if (ok.Checked) uc -= 2;
            if (om.Checked) uc -= 3;
            if (og.Checked) uc -= 4;
            return uc;
        }

        private void convert_but_Click(object sender, EventArgs e)
        {
            string[] output = new string[4];
            try {
                Base_conv(ref output);
            }
            catch
            {
                MessageBox.Show("來源不符合進位制規則", "錯誤");
            }
            o2b.Text = output[0];
            o8b.Text = output[1];
            o10b.Text = output[2];
            o16b.Text = output[3];
        }
        private int Base_case()
        {
            int uc = 0;
            if (s_2bit.Checked) uc = Convert.ToInt32(in_base.Text, 2);
            if (s_8bit.Checked) uc = Convert.ToInt32(in_base.Text, 8);
            if (s_10bit.Checked) uc = Convert.ToInt32(in_base.Text, 10);
            if (s_16bit.Checked) uc = Convert.ToInt32(in_base.Text, 16);

            return uc;
        }
        private void Base_conv(ref string[] oupt)
        {
            int og = Base_case();
            if (tar_2bit.Checked)
            {
                o2b.Visible = true;
                oupt[0] = "二進位  =" + Convert.ToString(og, 2);
            }
            if (tar_8bit.Checked)
            {
                o8b.Visible = true;
                oupt[1] = "八進位  =" + Convert.ToString(og, 8);
            }
            if (tar_10bit.Checked)
            {
                o10b.Visible = true;
                oupt[2] = "十進位  =" + Convert.ToString(og, 10);
            }
            if (tar_16bit.Checked)
            {
                o16b.Visible = true;
                oupt[3] = "十六進位=" + Convert.ToString(og, 16).ToUpper();
            }
        } 
        
    }
}
