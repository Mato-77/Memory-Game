using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Initial : State
    {
        public override void draw(Graphics g,Button button1, Button button2, Button button3)
        {

            String caption = "Меморија";

            Font font = new Font("Arial", 18);
            Brush b = new SolidBrush(Color.White);
            g.DrawString(caption, font, b, 225, 50);

            Image image = Image.FromFile(
                                     Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                                    @"Resources\game-card.png"));
            g.RotateTransform(15);
            Rectangle rec = new Rectangle(50, 40, 2 * 30, 2 * 45);
            g.DrawImage(image, rec);
            rec = new Rectangle(500, 40, 2 * 30, 2 * 45);
            g.DrawImage(image, rec);
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
        }
    }
}
