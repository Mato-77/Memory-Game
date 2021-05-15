using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Hard :Level
    {
        public Hard(int numBlocks): base(numBlocks) { }

        public override void strategy()
        {
            List<string> temp = new List<string>(HiddenInformation);
            List<int> numeredBlocks = this.getNumeredBlocks();

            for (int i = 0; i < HiddenInformation.Count; i++)
            {
                string info = temp[Random.Next(temp.Count)];
                int first = numeredBlocks.ElementAt(Random.Next(numeredBlocks.Count));
                numeredBlocks.Remove(first);
                int second = numeredBlocks.ElementAt(Random.Next(numeredBlocks.Count));
                numeredBlocks.Remove(second);
                Blocks[first].Information = info;
                Blocks[second].Information = info;
                temp.Remove(info);

            }
        }

        public override void play( Form1 form)
        {
            form.changeResult(350);
            form.Invalidate();
        }

        public override void timing(Form1 form)
        {
            form.maxTimePerLevel(5);
        }
    }
}
