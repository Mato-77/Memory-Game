using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public class Card
    {
        
        public string Information { get; set; } 

        public Point Point { get; set; } 

       
        public bool Opened { get; set; } // не е искористен State шаблон за состојба, поради полесна манипулација на булова променлива 


        public static Image image;


        public Card(Point Point)
        {
           
            this.Point = Point;

        }
        public static void setImage()
        {
            
            image = Image.FromFile(
                                     Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                                    @"Resources\game-card.png"));
        }
        
        public Card(Point Point, string Information)
        {
            this.Point = Point;
            this.Information = Information;
        }

        public void draw(Graphics g)
        {
            if (!Opened)
            {
                Rectangle rec = new Rectangle(Point.X - 20, Point.Y - 20, 2 * 30, 2 * 45);
                g.DrawImage(image, rec);
                
            }
            else
            {
                Pen p = new Pen(Color.White,3.5f);
               
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                g.DrawRectangle(p, Point.X - 20, Point.Y - 20, 2 * 30, 2 * 45);
                Brush b = new SolidBrush(Color.Brown);
                Font font = new Font("Arial", 20);
                g.DrawString(Information, font, b, Point.X - 5, Point.Y + 5);
                p.Dispose();
                b.Dispose();
            }
        }
        

        public bool contains(System.Drawing.Point point)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(Point.X - 20, Point.Y - 20, 2 * 30, 2 * 45);
            return rectangle.Contains(point);
        }
 
    }
}
