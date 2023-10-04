using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Timer timer=new Timer();
        bool isBaku=false;

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Zoom;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string bakuTime=DateTime.Now.ToLongTimeString();
            string londonTime=DateTime.Now.AddHours(4).ToLongTimeString();
            if(isBaku)
            {
                lblTime.Text = bakuTime;
            }
            else
            {
                lblTime.Text = londonTime;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.bakuimage;
            isBaku = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.londonimage4;
            isBaku = false;
        }
    }
}
