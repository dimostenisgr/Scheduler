using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            time1.Text = DateTime.Now.ToLongTimeString();
            date1.Text = DateTime.Now.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Tue su = new Tue();
            MainPanel.Controls.Add(su);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Fri su = new Fri();
            MainPanel.Controls.Add(su);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Alert_form1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Mon su = new Mon();
            MainPanel.Controls.Add(su);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(TimePanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Wed su = new Wed();
            MainPanel.Controls.Add(su);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Thu su = new Thu();
            MainPanel.Controls.Add(su);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Sut su = new Sut();
            MainPanel.Controls.Add(su);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Sun su = new Sun();
            MainPanel.Controls.Add(su);
        }

        private void TimePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
