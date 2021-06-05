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
            timer3.Interval = Level.Timing;
            

        }

 

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
         
            Level.drawBlocks(e.Graphics);
        }
      
       
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if (Level.contains(e.Location))
            {
                if (Level.SecondOpened != -1)
                {
                    bool result = Level.checkInformations();
                    if (!result)
                        timer2.Start();
                    timer3.Stop();

                }
                else if (Level.FirstOpened != -1 && Level.Blocks[Level.FirstOpened].Opened)
                    timer3.Start();
                else
                    timer3.Stop();
                Invalidate();

            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            NewGame game = new NewGame();
            if (game.ShowDialog() == DialogResult.OK)
            {

                Level = game.Level;
           
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
                endGame("Изгубивте!");
            }
            if (Level.finish())
            {
                endGame("Победивте!");
            }
            progressBarTime.Value = Level.Timer;

        }
        private void endGame(String message)
        {
            timer1.Stop();
            if (MessageBox.Show(message + " Дали сакате нова игра?", "Играта заврши", MessageBoxButtons.YesNo) == DialogResult.Yes)
                newGameToolStripMenuItem_Click(null, null);
            else
                this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Level.punishment();
            Invalidate();
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            Level.Blocks[Level.FirstOpened].Opened = false;
            Level.FirstOpened = -1;
            Invalidate();
        }
    }
}
