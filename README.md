# VP---Project - 193113 Мартин Николов
**1.Опис на проектот**<br/>
    Проектот претставува имплементација на играта меморија. Играта се состои од картички со скриена информација и играчот е потребно сите да ги отвори, пред да истече времето
    и притоа отварајќи ги последователно картичките со иста информација. Скриената информација претставува број и истиот број се содржи точно во две картички. 
    
 **2. Упатство на користење** <br/> <br/>
 **2.1 Почетен прозорец** <br/>
    На почетниот прозорец е прикажано опција за започнување на игра, опција за прегледување на правилата и опција за излез од играта. Опцијата за започнување на играта му овозможува на играчот да одбере  едно од нивоата за тежина  и да започне со играта, додека другата опција го запознава играчот со правилата.
   Постојат 3 нивоа на тежина на играта и тоа лесно, средно и тешко ниво и секое ниво има казна за погрешен погодок, како и соодветно време за кое доколку е отворена само првата картичка од парот, истата се затвара. 
   
   слика 1
   
   слика 2
   
   слика 3
**2.2 Прозорец со игра** <br/>
 Откако играчот ќе го одбере соодветното ниво на тежина, се појавува нов прозорец со картичките и опции за назад кон почетниот прозорец, избор на нова игра и опција за излез од играта. Исто така, се прикажани и поените, како и преостанатото време.  Играчот со клик на картичките ги отвара и затвара истите во согласност со правилата подолу. Доколку играчот се наврати на почетниот прозорец, опцијата за играње го продолжува од тековната игра. Времето се стопира при избор на нова игра или при навигација кон почетокот.
 
 слика 3
 4
 
   
**2.3 Правила на игра**</br>
        - Играчот е потребно да ги отвори сите картички пред истекот на времето <br/>
        - Дозволено е отварање и затварање на првата картичка од парот, доколку е само таа отворена од парот <br/>
        - За секој непогоден пар следува казна во зависност од избраното ниво <br/>

 **3. Репрезентација проблемот**<br/> <br/>
      **3.1 Картичка** <br/>
 За картичката е искористена класата Card што содржи својства за дали е отворена истата, сликата за приказ на затворена, скриениот број, како и методите за исцртување и проверка дали некоја точка се наоѓа во полето на картичката.

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


    
   **3.2 Ниво** <br/>
   За репрезентација на нивоата е искористен Factory шаблонот преку апстрактната класа Level и трите изведени класи Easy, Medium и Hard. Овие 3 класи се разликуваат во стратегијата на распоредување на скриените информации и казните при промашок односно преку методите strategy() и punishment(). Класата Level ги чува картичките во листа,  погодените парови во листа и скриените броеви во листа. Искористен е и шаблонот Observer со тоа што класата Level ја содржи колекцијата на картички и при соодветен отворен пар на картички, ги отвара или затвара останатите картички односно им ги менува состојбите преку методот checkInformations(), а истите се регистрирани преку методот setCoordinates(). Во кодот за класата Level е дадено појаснување за секоја функција и својство.
   
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
 <br/>  Искористена е и State шаблонот преку апстрактната класа State и импементациите Initial и Help кои имаат само цел да ја исцртуваат почетната форма во зависност од тоа дали е играчот се наоѓа во делот за правила или на почетното мени
    
     public class Initial : State
    {
        public override void draw(Graphics g,Button button1, Button button2, Button button3)
        {

            String caption = "Меморија";

            Font font = new Font("Arial", 18);
            Brush b = new SolidBrush(Color.White);
            g.DrawString(caption, font, b, 225, 50);

            Image image = Image.FromFile(
                                     Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                                    @"Resources\game-card.png"));
            g.RotateTransform(15);
            Rectangle rec = new Rectangle(50, 40, 2 * 30, 2 * 45);
            g.DrawImage(image, rec);
            rec = new Rectangle(500, 40, 2 * 30, 2 * 45);
            g.DrawImage(image, rec);
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
        }
    }

    public class Help : State
    {
        public override void draw(Graphics g, Button buton1, Button button2, Button button3)
        {
            String text = "Играта се состои од картички кои содржат броеви.";
            Font font = new Font("Arial", 18);
            Brush b = new SolidBrush(Color.White);
            String caption = "Појаснувања и правила на играта ";
            g.DrawString(caption, font, b, 75, 50);
            font = new Font("Arial", 12);
            g.DrawString(text, font, b, 10, 85);
            text = "Целта на играта е отварање на сите картички пред истекот на времето\nпритоа отварајќи ги картичките во парови по 2\nшто содржат ист број.";
            g.DrawString(text, font, b, 10, 100);
            text = "Точно двe картички содржат ист број.";
            g.DrawString(text, font, b, 10, 150);
            text = "Постојат три нивоа на тежина: лесно, средно и тешко ниво.";
            g.DrawString(text, font, b, 10, 165);
            text = "За секое ниво постои соодветна казна при погрешно отворени 2 картички!";
            g.DrawString(text, font, b, 10, 180);
            text = "Дозволено е отварање и затварање на првата картичка од парот во секое ниво!";
            g.DrawString(text, font, b, 10, 195);

            b.Dispose();
            buton1.Visible = false;
            button2.Visible = false;
            button3.Visible = true; 
        }
    }
**3.4 Методи** <br/>
    Дел од методите веќе беа спомнати и објаснети, овде се издвоени најважните <br/>
    **3.4.1 contains(Point point)** од класата Level се повикува при секој клик на играчот, со цел да се провери, дали кликната точка пратена преку аргумент е дел од
    некоја картичка. Доколку припаѓа на некоја картичка и  истата не е дел од паровите што се погодени,  се означува за првоотворена или второотворена. <br/>
    **3.4.2 setCoordinates()** од класата Level ги означува центрите на картичките и соодветно доколку станува збор за ниво лесно и средно ги поставува по 4 картички со иста Х координата, а при ниво тешко по 7 и истите ги регистрира во класата.<br/>
    **3.4.3  checkInformations()** од класата Level проверува дали отворениот пар на картички имаат ист број и доколку да, го наградува играчот, доколку не,
    истиот е казнет со казната за соодветно ниво на тежина. <br/>
    **3.4.4  draw(Graphics g)** од класата Card ја исцртува картичката или ја исцртува информацијата на картичката заедно со границата во зависност на состојбата

    
    
    
    
