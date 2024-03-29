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
    public partial class NewGame : Form
    {
        public Level Level { get; set; }
        public String LevelType { get; set; }
        public NewGame()
        {
            InitializeComponent();
            cbLevel.SelectedIndex = 0;

        }

     
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbLevel.SelectedItem == null)
                return;
            if (cbLevel.SelectedItem.Equals("Лесно"))
            {
                Level = new Easy(16);
            }
            else if (cbLevel.SelectedItem.Equals("Средно"))
            {
                Level = new Medium(20);

            }
            else {
                Level = new Hard(36);

            }
            LevelType = cbLevel.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void NewGame_Load(object sender, EventArgs e)
        {

        }
    }
}
