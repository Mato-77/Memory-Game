using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Hard :Level
    {
        public Hard(int numCards): base(numCards,360) {
            Timing = 1800;
        }

        public override void strategy()
        {
            List<string> temp = new List<string>(HiddenInformation);
            List<int> numeredCards = this.getNumeredCards();

            for (int i = 0; i < HiddenInformation.Count; i++)
            {
                string info = temp[Random.Next(temp.Count)];
                int first = numeredCards.ElementAt(Random.Next(numeredCards.Count));
                numeredCards.Remove(first);
                int second = numeredCards.ElementAt(Random.Next(numeredCards.Count));
                numeredCards.Remove(second);
                Cards[first].Information = info;
                Cards[second].Information = info;
                temp.Remove(info);

            }
        }

        public override void punishment()
        {

            Timer -= 5;
           
            Points -= 200;
            foreach (Card Card in Cards)
                Card.Opened = false;
            HittedCards.Clear();
            resetIndexes();
            
        }
    }
}
