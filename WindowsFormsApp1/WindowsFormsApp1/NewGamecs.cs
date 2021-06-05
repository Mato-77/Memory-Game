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
    public partial class NewGame : Form
    {
        public Level Level { get; set; }
        public NewGame()
        {
            InitializeComponent();
        }

        private void NewGamecs_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbLevel.SelectedItem == "Easy")
                Level = new Easy(16);
            else if (cbLevel.SelectedItem == "Medium")
                Level = new Medium(20);
            else
                Level = new Hard(36);
            DialogResult = DialogResult.OK;
           
        }
    }
}
