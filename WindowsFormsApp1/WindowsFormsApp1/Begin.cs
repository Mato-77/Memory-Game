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
    public partial class Begin : Form
    {

        public State State { get; set; }

        public string TypeOfGame { get; set; }
        public bool FirstTime { get; set; }

        public Level Level { get; set; }
        public Begin()
        {
            InitializeComponent();
            State = new Initial();
            
        }

        private void Begin_Paint(object sender, PaintEventArgs e)
        {
          State.draw(e.Graphics,btnPlay,btnHelp,btnBack);



        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!FirstTime)
            {
                NewGame game = new NewGame();
                if (game.ShowDialog() == DialogResult.OK)
                {
                    Level = game.Level;
                    TypeOfGame = game.LevelType;
                    FirstTime = true;
                    DialogResult = DialogResult.OK;
                }
            }
            else
                DialogResult = DialogResult.OK;

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            State = new Help();
            Invalidate();
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            State = new Initial();
            Invalidate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;           
        }
    }
}
