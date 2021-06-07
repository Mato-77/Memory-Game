using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Easy : Level
    {
        public Easy(int NumCards) : base(NumCards,120) {
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
            List<int> numeredCards = this.getNumeredCards();
            
            for(int i = 0; i < HiddenInformation.Count; i++)
            {
                string info = temp[Random.Next(temp.Count)];
                int first =  numeredCards.ElementAt(Random.Next(numeredCards.Count));
                numeredCards.Remove(first);
                int second = 0;
                if (numeredCards.Contains(first + 1))
                    second = first + 1;
            
                else
                    second = numeredCards.ElementAt(Random.Next(numeredCards.Count));
                numeredCards.Remove(second);
                Cards[first].Information = info;
                Cards[second].Information = info;
                temp.Remove(info);

            }            
        }

   
    }
}
