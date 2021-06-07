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
        public int NumCards { get; set; } //број на картички

        public List<Card> Cards { get; set; } // репрезентација на картичките 

        public List<string> HiddenInformation { get; set; } // репрезентација на скриените броеви

        public List<Card> HittedCards { get; set; } //  репрезентација на отворени картички

        public Random Random { get; set; } // за случајно распоредување на броевите во картичките

        public int Timer { get; set; } // време на игра

        public int FirstOpened { get; set; } // прва отворена картичка

        public int SecondOpened { get; set; } // втора отворена картичка

        public int Points { get; set; } // поени

        public int Timing { get; set; } // време на стоперка за затварање на прва картичка

        public Level(int Cards, int Seconds)
        {
            this.NumCards = Cards;
            this.Random = new Random();
            this.HiddenInformation = new List<string>();
            this.Cards = new List<Card>();
            this.HittedCards = new List<Card>();
            this.Timer = Seconds;
            this.FirstOpened = -1;
            this.SecondOpened = -1;
            this.Points = 0;
            fillInformations();
            setCordinates();
            strategy();
        }
     
        // казна при промашок
        public abstract void punishment();

        // распоредување на играта
        public abstract void strategy();


      // проверка дали клик настанот се однесува на некоја од картичките и менување на состојбата на таа картичка
        public bool contains(Point point)
        {
            if (FirstOpened != -1 && SecondOpened != -1)
                return false;
            for (int i = 0; i < Cards.Count; i++)
            {
                if (Cards[i].contains(point))
                {
                    if (HittedCards.Contains(Cards[i]))
                        return false;
                    if (!Cards[i].Opened)
                    {
                        if (FirstOpened == -1)
                            FirstOpened = i;
                        else
                            SecondOpened = i;
                        
                        Cards[i].Opened = true;
                    }
                    else if (SecondOpened == -1)
                    {
                        Cards[i].Opened = false;
                        FirstOpened = -1;
                    }
                    return true;
                }
            }
            return false;
        }
        // проверка дали дветте картички содржат ист скриен број
        public bool checkInformations()
        {
            if (!Cards[FirstOpened].Information.Equals(Cards[SecondOpened].Information))
                return false;
            else
            {
                Points += 300;
                HittedCards.Add(Cards[FirstOpened]);
                HittedCards.Add(Cards[SecondOpened]);
                resetIndexes();
                return true;
            }
        }
        // означување дека нема селектирано картички
        public void resetIndexes()
        {
            FirstOpened = -1;
            SecondOpened = -1;
        }

        // затварање на претходен пар при промашок
        public void resetPropertiesOpened() {
             Cards[FirstOpened].Opened = false;
            Cards[SecondOpened].Opened = false;
            }
       
      
       // поставување на координати на картичките за цртање
        private void setCordinates()
        {
            for (int i = 1, j = 1,k=1; i <= NumCards; i++,j++)
            {
                if( NumCards == 36)
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
                Card Card = new Card(point);
                Cards.Add(Card);
            }
        }

        // поставување на броеви во картичките
        private void fillInformations()
        {
            for (int i = 1; i <= NumCards / 2; i++)
            {
                HiddenInformation.Add(i.ToString());
            }
        }

        // исцртување на картичките
        public void drawCards( Graphics g)
        {
            foreach (Card Card in Cards)
                Card.draw(g);
           
        }

        // генерирање на листа со скриените броеви
        public List<int> getNumeredCards()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < NumCards; i++)
                list.Add(i);
            return list;
        }

        // проверка за крај на играта
        public bool finish()
        {
            foreach(Card Card in Cards)
            {
                if (!Card.Opened)
                    return false;
            }
            return true;
        }
        
    }
}
