using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace DeckCards
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            string name1 = "Cody";
            string name2 = "Bryanna";
            Console.Write("Player 1:  ");
            name1 = Console.ReadLine();
            Console.Write("Player 2:  ");
            name2 = Console.ReadLine();

            Player Player1;
            Player Player2;

            bool keepPlaying = true;

            while (keepPlaying)
            {
                Player1 = new Player(name1);
                Player2 = new Player(name2);
                Deck juego = new Deck();

                play(Player1, Player2, juego);
                Console.Write("Play again: (Y/N)");
                if (Console.ReadLine().ToLower() != "y")
                {
                    keepPlaying = false;
                }

            }
            Console.ResetColor();
            Console.Clear();
        }
        static void play(Player Player1, Player Player2, Deck juego)
        {
            juego.Reset();
            juego.Shuffle();
            Console.Clear();
            List<Card> handPlayer1 = new List<Card>();
            List<Card> handPlayer2 = new List<Card>();

            for (int i = 0; i < 7; i++)
            {
                handPlayer1.Add(Player1.Draw(juego));
                handPlayer2.Add(Player2.Draw(juego));
            }

            int p1 = 0;
            int p2 = 0;
            foreach (Card x in Player1.Hand)
            {
                p1 += x.val;
            }
            foreach (Card x in Player2.Hand)
            {
                p2 += x.val;
            }
            string whowon = "";
            if (p1 > p2)
            {
                whowon = Player1.Name;
            }
            else if (p1 < p2)
            {
                whowon = Player2.Name;
            }
            PrintFirstPage(handPlayer1, handPlayer2, juego, Player1.Name, Player2.Name, whowon);
            Console.WriteLine("{0}:  {1},  {2}:  {3}  ", Player1.Name, p1, Player2.Name, p2);

        }

        static void PrintFirstPage(List<Card> handPlayer1, List<Card> handPlayer2, Deck mydeck, string _player1, string _player2, string whowon)
        {
            Console.BackgroundColor = System.ConsoleColor.Gray;
            Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #");
            Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #");
            Console.WriteLine(" # # # # # # # # # # #  CASINO ROYALE  # # # # # # # # # # # # # # # # # #");
            Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #");
            Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #");
            Console.WriteLine("");
            Console.WriteLine("                           Bank- total cards:   {0}                                   ", mydeck.Count);
            Console.WriteLine("    (▀̿̿Ĺ̯̿▀̿ ̿)                                                    (▀̿̿Ĺ̯̿▀̿ ̿)     ");
            Console.WriteLine("                                   ლ(✿◠‿◠)ლ                          ");
            Console.WriteLine("                          __________________        ");
            Console.WriteLine("                 [{0} {1,2:##}]   |                 |  [{2} {3,2:##}]            ", handPlayer1[0].image, handPlayer1[0].val, handPlayer2[0].image, handPlayer2[0].val);
            Console.WriteLine("                 [{0} {1,2:##}]   |                 |  [{2} {3,2:##}]            ", handPlayer1[1].image, handPlayer1[1].val, handPlayer2[1].image, handPlayer2[1].val);
            Console.WriteLine("       ()()      [{0} {1,2:##}]   |                 |  [{2} {3,2:##}]            ", handPlayer1[2].image, handPlayer1[2].val, handPlayer2[2].image, handPlayer2[2].val);
            Console.WriteLine("       (^o^)     [{0} {1,2:##}]   |                 |  [{2} {3,2:##}]   (｡◕‿◕｡) ", handPlayer1[3].image, handPlayer1[3].val, handPlayer2[3].image, handPlayer2[3].val);
            Console.WriteLine("       ('')('')  [{0} {1,2:##}]   |                 |  [{2} {3,2:##}]             ", handPlayer1[4].image, handPlayer1[4].val, handPlayer2[4].image, handPlayer2[4].val);
            Console.WriteLine("                 [{0} {1,2:##}]   |                 |  [{2} {3,2:##}]             ", handPlayer1[5].image, handPlayer1[5].val, handPlayer2[5].image, handPlayer2[5].val);
            Console.WriteLine("                 [{0} {1,2:##}]   |_________________|  [{2} {3,2:##}]             ", handPlayer1[6].image, handPlayer1[6].val, handPlayer2[6].image, handPlayer2[6].val);
            Console.WriteLine("        {0}                                         {1}           ", _player1, _player2);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #");
            Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #");
            Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #");

            Console.Write("And the winner is.....");


            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
                Console.Write(">");
            }
            Console.BackgroundColor = System.ConsoleColor.Yellow;
            Console.ForegroundColor = System.ConsoleColor.Black;
            Console.WriteLine("     {0}      ", whowon);
            Console.BackgroundColor = System.ConsoleColor.Gray;
            Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # ");
            Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # ");
            Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # ");


        }

    }
}

