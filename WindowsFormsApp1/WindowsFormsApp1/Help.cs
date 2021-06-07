using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Help : State
    {
        public override void draw(Graphics g, Button buton1, Button button2, Button button3)
        {
            String text = "Играта се состои од картички кои содржат броеви.";
            Font font = new Font("Arial", 18);
            Brush b = new SolidBrush(Color.White);
            String caption = "Појаснувања и правила на играта ";
            g.DrawString(caption, font, b, 75, 50);
            font = new Font("Arial", 12);
            g.DrawString(text, font, b, 10, 85);
            text = "Целта на играта е отварање на сите картички,\n притоа отварајќи ги картичките со ист број последователно.";
            g.DrawString(text, font, b, 10, 100);
            text = "Точно два блока содржат ист број.";
            g.DrawString(text, font, b, 10, 132);
            b.Dispose();
            buton1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;

        }
    }
}
