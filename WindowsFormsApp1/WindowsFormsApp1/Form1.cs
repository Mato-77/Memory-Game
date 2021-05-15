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
        public Level Level { get; set; }

     
        public Form1()
        {
            Level = new Easy(18);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

         


             Level.drawBlocks(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        public void changeResult(int value)
        {
           
            tbPoints.Text = (Convert.ToDecimal(tbPoints.Text) - value).ToString();
        }
        public void changeTimer(int value)
        {
            tbTimer.Text = (Convert.ToDecimal(tbTimer.Text) - value).ToString();
            progressBarTime.Value = progressBarTime.Value - value;
            // call function for end game

        }
        public void maxTimePerLevel(int value)
        {

        }
    }
}
