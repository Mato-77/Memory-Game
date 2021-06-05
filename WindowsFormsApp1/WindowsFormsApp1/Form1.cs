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
            Invalidate();


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

                tbTimer.Text = String.Format("{0}:{1}", (Level.Timer / 60).ToString("00"), (Level.Timer % 60).ToString("00"));
                progressBarTime.Maximum = Level.Timer;
                progressBarTime.Value = Level.Timer;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Level.Timer -= 1;
            tbTimer.Text = String.Format("{0}:{1}", (Level.Timer / 60).ToString("00"), (Level.Timer % 60).ToString("00"));
            progressBarTime.Value = Level.Timer;
            if(Level.Timer == 0)
            {
                timer1.Stop();
                if (MessageBox.Show("Времето истече! Дали сакате нова игра?", "Играта заврши", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    newGameToolStripMenuItem_Click(null, null);
                else
                    this.Close(); ;
            }

        }
    
    }
}
