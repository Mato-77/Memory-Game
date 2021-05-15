using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Level
    {
        public int NumBlocks { get; set; }

        public List<Block> Blocks { get; set; }

        public List<string> HiddenInformation { get; set; }

        public Random Random { get; set; }

        public Level(int Blocks)
        {
            this.NumBlocks = Blocks;
            this.Random = new Random();
            this.HiddenInformation = new List<string>();
            this.Blocks = new List<Block>();
            fillInformations();
            setCordinates();
            strategy();
        }
        public abstract void play(Form1 form);

        public abstract void strategy();

        public abstract void timing(Form1 form);


        private void setCordinates()
        {
            for (int i = 1, j = 1,k=1; i <= NumBlocks; i++,j++)
            {
                if( NumBlocks == 36)
                {
                    if (j == 7)
                    {
                        j = 1;
                        k++;
                    }
                }
                else if(j == 5 && NumBlocks  == 16)
                {
                    j = 1;
                    k++;
                }
                Point point = new Point(100 * j,110*k);
                Block block = new Block(point);
                Blocks.Add(block);
            }
        }

        private void fillInformations()
        {
            for (int i = 1; i <= NumBlocks / 2; i++)
            {
                HiddenInformation.Add(i.ToString());
            }
        }
        public void drawBlocks(Graphics g)
        {
            foreach (Block block in Blocks)
                block.draw(g);
           
        }
        public List<int> getNumeredBlocks()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < NumBlocks; i++)
                list.Add(i);
            return list;
        }
        
    }
}
