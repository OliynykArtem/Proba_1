using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiktok
{
    public partial class Form1 : Form
    {
        int main_count_1 = 0;
        int main_count_2 = 0;

        int count_1 = 0;
        int count_2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pb_tiktok_Click(object sender, EventArgs e)
        {
            count_1 += 50;
            label_1.Text = Convert.ToString(count_1);
            level_up();
        }

        private void pb_mikrophon_Click(object sender, EventArgs e)
        {
            count_1 += 250;
            label_1.Text = Convert.ToString(count_1);
            level_up();
        }

        private void pb_gamepad_Click(object sender, EventArgs e)
        {
            count_1 += 1000;
            label_1.Text = Convert.ToString(count_1);
            level_up();
        }

        private void pb_ganteli_Click(object sender, EventArgs e)
        {
            count_2 += 50;
            label_2.Text = Convert.ToString(count_2);
            level_up();
        }

        private void pb_shchelchok_Click(object sender, EventArgs e)
        {
            count_2 += 250;
            label_2.Text = Convert.ToString(count_2);
            level_up();
        }

        private void pb_ledenets_Click(object sender, EventArgs e)
        {
            count_2 += 1000;
            label_2.Text = Convert.ToString(count_2);
            level_up();
        }

        private void level_up()
        {
            if (count_1 >= 10000)
            {
                main_count_1 += 1;
                l_Main_counter.Text = Convert.ToString(main_count_1) + " : " + Convert.ToString(main_count_2);
                count_1 = 0;
                count_2 = 0;
                label_1.Text = Convert.ToString(count_1);
                label_2.Text = Convert.ToString(count_2);
            }

            if (count_2 >= 10000)
            {
                main_count_2 += 1;
                l_Main_counter.Text = Convert.ToString(main_count_1) + " : " + Convert.ToString(main_count_2);
                count_1 = 0;
                count_2 = 0;
                label_1.Text = Convert.ToString(count_1);
                label_2.Text = Convert.ToString(count_2);
            }
        }

        private void label_1_Click(object sender, EventArgs e)
        {
            count_1 += 1;
            label_1.Text = Convert.ToString(count_1);
        }

        private void label_2_Click(object sender, EventArgs e)
        {
            count_2 += 1;
            label_2.Text = Convert.ToString(count_2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count_1 += Convert.ToInt32(textBox1.Text);
            label_1.Text = Convert.ToString(count_1);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count_2 += Convert.ToInt32(textBox2.Text);
            label_2.Text = Convert.ToString(count_2);
            textBox2.Text = "";
        }

    }
}
