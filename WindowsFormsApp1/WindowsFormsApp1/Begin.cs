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

        public State state { get; set; }
        public Begin()
        {
            InitializeComponent();
            state = new Initial();
        }

        private void Begin_Paint(object sender, PaintEventArgs e)
        {
          state.draw(e.Graphics,btnPlay,btnHelp,btnBack);



        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            state = new Help();
            Invalidate();
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            state = new Initial();
            Invalidate();
        }
    }
}
