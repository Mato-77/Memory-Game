using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Block
    {
        public string Information { get; set; }

        public Point Point { get; set; }

        public bool Opened { get; set; }



        public Block( Point Point)
        {
           
            this.Point = Point;
        }
        public Block(Point Point, string Information)
        {
            this.Point = Point;
            this.Information = Information;
        }

        public void draw(Graphics g)
        {
            if (!Opened)
            {
                Brush b = new SolidBrush(Color.Green);
                g.FillRectangle(b, Point.X - 20, Point.Y - 20, 2 * 30, 2 * 45);
                b.Dispose();
            }
            else
            {
                Pen p = new Pen(Color.White);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                g.DrawRectangle(p, Point.X - 20, Point.Y - 20, 2 * 30, 2 * 45);
                Brush b = new SolidBrush(Color.Green);
                Font font = new Font("Arial", 25);
                g.DrawString(Information, font, b, Point.X, Point.Y);
                p.Dispose();
                b.Dispose();
                    
               
            }
        }
        

        public bool contains(Point point)
        {
            Rectangle rectangle = new Rectangle(Point.X - 20, Point.Y - 20, 2 * 30, 2 * 45);
            return rectangle.Contains(point);
        }
       

    
      



        public override string ToString()
        {
            return String.Format("X: {0} , Y: {1}  - Information: {2}", Point.X, Point.Y, Information);
        }
 
    }
}
