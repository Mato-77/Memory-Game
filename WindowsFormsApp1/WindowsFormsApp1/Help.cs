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
            g.DrawString(text, font, b, 10, 90);
            text = "Целта на играта е отварање на сите картички пред истекот на времето\nпритоа отварајќи ги картичките во парови по 2 што содржат ист број.";
            g.DrawString(text, font, b, 10, 110);
            text = "Точно двe картички содржат ист број.";
            g.DrawString(text, font, b, 10, 150);
            text = "Постојат три нивоа на тежина: лесно, средно и тешко ниво.";
            g.DrawString(text, font, b, 10, 170);
            text = "За секое ниво постои соодветна казна при погрешно отворени 2 картички!";
            g.DrawString(text, font, b, 10, 190);
            text = "Дозволено е отварање и затварање на првата картичка од парот во секое ниво!";
            g.DrawString(text, font, b, 10, 210);

            b.Dispose();
            buton1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;

        }
    }
}
