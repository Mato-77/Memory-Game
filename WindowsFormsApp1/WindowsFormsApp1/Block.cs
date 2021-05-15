using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Block
    {
        public string Information { get; set; }

        public Point Point { get; set; }

        public Block( Point Point)
        {
           
            this.Point = Point;
        }
        public void draw(Graphics g)
        {
            Pen pen = new Pen(Color.Red, 4);
            Rectangle rectangle = new Rectangle(Point.X - 35, Point.Y - 50, 2 * 35, 2 * 50);
            
            g.DrawRectangle(pen, rectangle);
            
            pen.Dispose();
        }
        public override string ToString()
        {
            return String.Format("X: {0} , Y: {1}  - Information: {2}", Point.X, Point.Y, Information);
        }

    }
}
