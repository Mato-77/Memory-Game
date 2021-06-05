using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract class Level
    {
        public int NumBlocks { get; set; }

        public List<Block> Blocks { get; set; }

        public List<string> HiddenInformation { get; set; }

        public Random Random { get; set; }

        public int Timer { get; set; }

        public int FirstOpened { get; set; }

        public int SecondOpened { get; set; }

        public int Points { get; set; }

        public Level(int Blocks,int Seconds)
        {
            this.NumBlocks = Blocks;
            this.Random = new Random();
            this.HiddenInformation = new List<string>();
            this.Blocks = new List<Block>();
            this.Timer = Seconds;
            this.FirstOpened = -1;
            this.SecondOpened = -1;
            this.Points = 0;
            fillInformations();
            setCordinates();
            strategy();
        }
        // punishment za soodvetna kazna pri pogresen odgovor  za sekoe nivo razlicna
        public abstract void punishment();
        // strategy e za rasporeduvanje na igrata
        public abstract void strategy();
        // razlicno vreme na dozvoleno otvaranje na eden blok pred toj da bide zatvoren
        public abstract void timing(Form1 form);

     

        public void contains(Point point)
        {
            if (FirstOpened != -1 && SecondOpened != -1)
                return;
            for (int i = 0; i < Blocks.Count; i++)
            {
                if (Blocks[i].contains(point))
                {
                    if (!Blocks[i].Opened)
                    {
                        if (FirstOpened == -1)
                        {
                            FirstOpened = i;
                        }
                        else
                        {
                            SecondOpened = i;
                        }
                        Blocks[i].Opened = true;
                    }
                    else if(SecondOpened ==-1)
                    {
                        Blocks[i].Opened = false;
                        FirstOpened = -1;

                    }

                }
            }
        }
        public  bool checkInformations()
        {
            if (FirstOpened != -1 && SecondOpened != -1)
            {

                if (!Blocks[FirstOpened].Information.Equals(Blocks[SecondOpened].Information))
                {

                    return false;

                }
                else
                {
                    Points += 100;
                    FirstOpened = -1;
                    SecondOpened = -1;
                    return true;
                }
               
            }
            return true;
           
            
        }
        public void close()
        {
            FirstOpened = -1;
            SecondOpened = -1;
        }
       
      
       
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
            
                else if(j == 5)
                {
                    j = 1;
                    k++;
                }
                Point point = new Point(70 * j,105*k);
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
        public void drawBlocks( Graphics g)
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
        public bool finish()
        {
            foreach(Block block in Blocks)
            {
                if (!block.Opened)
                    return false;
            }
            return true;
        }
        
    }
}
