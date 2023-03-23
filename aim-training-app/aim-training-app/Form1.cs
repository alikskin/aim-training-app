using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aim_training_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        int süre = 60;
        int skor = 0;
        int can = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            label4.Text = süre.ToString();

            if (süre == 0)
            {
                timer1.Stop();
                DialogResult res = MessageBox.Show($"Süreniz Bitti! Skorunuz : {skor}", "Yeniden Başlamak İster misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (res == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            panel1.Enabled = true;
            Random random = new Random();

            skor++;
            label2.Text = skor.ToString();

            int nokta_x;
            nokta_x = random.Next(50, 700);
            pictureBox1.Location = new Point(nokta_x, pictureBox1.Location.Y);

            int nokta_y;
            nokta_y = random.Next(70, 400);
            pictureBox1.Location = new Point(pictureBox1.Location.X, nokta_y);
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            can--;
            label6.Text = can.ToString();

            if (can == 0)
            {
                timer1.Stop();
                DialogResult res = MessageBox.Show($"Hakkınız Bitti! Skorunuz : {skor} ", "Yeniden Başlamak İster misiniz?", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
                if (res == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
