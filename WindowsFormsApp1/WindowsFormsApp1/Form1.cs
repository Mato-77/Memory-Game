﻿using System;
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
        public Begin Begin { get; set; }

        public Form1()
        {
            InitializeComponent();
            Card.setImage();
            Begin = new Begin();
            openBeginForm();


        }
        private void init()
        {
            DoubleBuffered = true;
            setTime();
            timer1.Interval = 1000;
            timer2.Interval = 800;
            timer3.Interval = Level.Timing;
            timer1.Start();
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Level.drawCards(e.Graphics);
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
                else if (Level.FirstOpened != -1 && Level.Cards[Level.FirstOpened].Opened)
                    timer3.Start();
                else
                    timer3.Stop();
                Invalidate();



            }

        }


        private void setTime()
        {
            if (Level.Timer > 0)
                btnStyleTime.Text = String.Format("{0}:{1}", (Level.Timer / 60).ToString("00"), (Level.Timer % 60).ToString("00"));
            else
                btnStyleTime.Text = "00:00";


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Level.Timer -= 1;
            setTime();
            btnStylePoints.Text = Level.Points.ToString();
            if (Level.Timer <= 0)
            {
                endGame("Изгубивте!");
            }
            if (Level.finish())
            {
                endGame("Победивте!");
            }

        }
        private void endGame(String message)
        {
            timer1.Stop();
            if (MessageBox.Show(message + " Дали сакате нова игра?", "Играта заврши", MessageBoxButtons.YesNo) == DialogResult.Yes)
                btnNewGame_Click(null, null);
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
            Level.Cards[Level.FirstOpened].Opened = false;
            Level.FirstOpened = -1;
            Invalidate();
        }

      

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

     



        private void openBeginForm()
        {
            DialogResult dialog = Begin.ShowDialog();
            if (dialog== DialogResult.OK)
            {
                
                    Level = Begin.Level;
                    btnLevel.Text = Begin.TypeOfGame;
                    init();
                    Invalidate();
            }
            else
            {
                this.Close();
            }

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            NewGame game = new NewGame();
            if (game.ShowDialog() == DialogResult.OK)
            {
                Level = game.Level;
                btnLevel.Text = game.LevelType;
                Begin.Level = game.Level;
                Begin.TypeOfGame = game.LevelType;
                game.Close();
                init();
                Invalidate();
            }
            else
            {
                timer1.Start();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            timer1.Stop();
         
            openBeginForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
