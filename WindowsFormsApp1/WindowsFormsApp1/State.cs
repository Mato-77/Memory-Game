using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public abstract class State
    {

        public abstract void draw(Graphics g,Button button1, Button button2,Button button3);
    }
}
