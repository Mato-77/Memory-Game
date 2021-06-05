using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Medium : Level
    {
        public Medium(int numBlocks): base(numBlocks,135) { }
        public override  void play(Form1 form)
        {
            form.changeResult(120);
            form.changeTimer(4);
        }

        public override void strategy()
        {
            List<string> temp = new List<string>(HiddenInformation);
            List<int> numeredBlocks = this.getNumeredBlocks();
            int direction = Random.Next(2);

            for (int i = 0; i < HiddenInformation.Count; i++)
            {
                string info = temp[Random.Next(temp.Count)];
                int first = numeredBlocks.ElementAt(Random.Next(numeredBlocks.Count));
                numeredBlocks.Remove(first);
                int second = numeredBlocks.ElementAt(Random.Next(numeredBlocks.Count));
                if (numeredBlocks.Contains(first + 3))
                    second = first + 3;
                else if (numeredBlocks.Contains(first + 2))
                    second = first + 2;
                else if (numeredBlocks.Contains(first - 2))
                    second = first - 2;
                else if (numeredBlocks.Contains(first - 1))
                    second = first - 1;
                
                numeredBlocks.Remove(second);
                Blocks[first].Information = info;
                Blocks[second].Information = info;
                temp.Remove(info);

            }
        }

        public override void timing(Form1 form)
        {
            form.maxTimePerLevel(10);
        }
    }
}
