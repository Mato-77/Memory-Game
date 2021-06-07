using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Easy : Level
    {
        public Easy(int NumBlocks) : base(NumBlocks,120) {
            Timing = 3500;
        }

        public override void punishment()
        {
            Points -= 50;
            resetPropertiesOpened();
            resetIndexes();
        }
     

        public override void strategy()
        {
            List<string> temp = new List<string>(HiddenInformation);
            List<int> numeredBlocks = this.getNumeredBlocks();
            
            for(int i = 0; i < HiddenInformation.Count; i++)
            {
                string info = temp[Random.Next(temp.Count)];
                int first =  numeredBlocks.ElementAt(Random.Next(numeredBlocks.Count));
                numeredBlocks.Remove(first);
                int second = 0;
                if (numeredBlocks.Contains(first + 1))
                    second = first + 1;
            
                else
                    second = numeredBlocks.ElementAt(Random.Next(numeredBlocks.Count));
                numeredBlocks.Remove(second);
                Blocks[first].Information = info;
                Blocks[second].Information = info;
                temp.Remove(info);

            }            
        }

   
    }
}
