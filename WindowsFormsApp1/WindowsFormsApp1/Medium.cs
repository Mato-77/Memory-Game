using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Medium : Level
    {
        public Medium(int numCards): base(numCards,180) {
            Timing = 2500;
        }
        public override  void punishment()

        {
            Points -= 150;
            Timer -= 2;
            resetPropertiesOpened();
            resetIndexes();
        }

        public override void strategy()
        {
            List<string> temp = new List<string>(HiddenInformation);
            List<int> numeredCards = this.getNumeredCards();
            int direction = Random.Next(2);

            for (int i = 0; i < HiddenInformation.Count; i++)
            {
                string info = temp[Random.Next(temp.Count)];
                int first = numeredCards.ElementAt(Random.Next(numeredCards.Count));
                numeredCards.Remove(first);
                int second = numeredCards.ElementAt(Random.Next(numeredCards.Count));
                int offset = Random.Next(1, 5);
                if (numeredCards.Contains(first +offset))
                    second = first + offset;
         
                
                numeredCards.Remove(second);
                Cards[first].Information = info;
                Cards[second].Information = info;
                temp.Remove(info);

            }
        }

     
    }
}
