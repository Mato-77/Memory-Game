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
            
            InitializeComponent();
            newGameToolStripMenuItem_Click(null,null);
            tbPoints.Text = "0.00";
            DoubleBuffered = true;
            timer2.Interval = 800;
            

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
          
                Level.contains(e.Location);
                bool result = Level.checkInformations();
                Invalidate();
                if (!result) 
                    timer2.Start();
        }







        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            NewGame game = new NewGame();
            if (game.ShowDialog() == DialogResult.OK)
            {

                Level = game.Level;
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i].GetType() == typeof(PictureBox))
                    {
                        Controls.RemoveAt(i);
                        i--;
                    }

                }
                Invalidate();

                progressBarTime.Maximum = Level.Timer;
                progressBarTime.Value = Level.Timer;

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Level.Timer -= 1;
            tbTimer.Text = String.Format("{0}:{1}", (Level.Timer / 60).ToString("00"), (Level.Timer % 60).ToString("00"));
            tbPoints.Text = Level.Points.ToString();
            if (Level.Timer <= 0)
            {
                timer1.Stop();
                if (MessageBox.Show("Времето истече! Дали сакате нова игра?", "Играта заврши", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    newGameToolStripMenuItem_Click(null, null);
                else
                    this.Close(); 
            }
            if (Level.finish())
            {
                timer1.Stop();
                if (MessageBox.Show("Победивте! Дали сакате нова игра?", "Играта заврши", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    newGameToolStripMenuItem_Click(null, null);
                else
                    this.Close();
            }
            progressBarTime.Value = Level.Timer;
         

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Level.punishment();
            Invalidate();
            timer2.Stop();
        }
    }
}
