// using System;
// using System.Text;
// using System.Collections.Generic;

// namespace DeckCards
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Beep();
//             // string name1 = Console.ReadLine();
//             // string name2 = Console.ReadLine();
//             string name1 = "Mine";
//             string name2 = "Dany";
//             Player Player1 = new Player(name1);
//             Player Player2 = new Player(name2);
//             Deck juego = new Deck();
//             juego.Shuffle();

//             List<Card> handPlayer1 = new List<Card>();
//             List<Card> handPlayer2 = new List<Card>();

//             // Card myCard;

//             for (int i = 0; i < 7; i++)
//             {
//                 handPlayer1.Add(Player1.Draw(juego));
//                 // handPlayer1[0].image
//                 // Console.WriteLine("{0} - {1} ({2})", myCard.StringVal, (char)myCard.image, myCard.val);
//             }

//             for (int i = 0; i < 7; i++)
//             {
//                 handPlayer2.Add(Player1.Draw(juego));
//                 // Console.WriteLine("{0} - {1} ({2})", myCard.StringVal, (char)myCard.image, myCard.val);
//             }
                
//             PrintFirstPage(handPlayer1, handPlayer2, juego, Player1.Name, Player2.Name);

//         }
//         static void PrintFirstPage(List<Card> handPlayer1, List<Card> handPlayer2, Deck mydeck, string _player1, string _player2)
//         {
           
//             Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # ");
//             Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # ");
//             Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # ");
//             Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # ");
//             Console.WriteLine("                           BANK total cards:                                      ");
//             Console.WriteLine("                               {0}                                       ", mydeck.Count);
//             Console.WriteLine("                             = @@ =                            ");
//             Console.WriteLine("                         __________________        ");
//             Console.WriteLine("                 {0} {1,2:##}   |                 |  {2} {3,2:##}                 ", handPlayer1[0].image, handPlayer1[0].val, handPlayer2[0].image, handPlayer2[0].val);
//             Console.WriteLine("         = = =   {0} {1,2:##}   |                 |  {2} {3,2:##}   = = =          ", handPlayer1[1].image, handPlayer1[1].val, handPlayer2[1].image, handPlayer2[1].val);
//             Console.WriteLine("         @ |     {0} {1,2:##}   |                 |  {2} {3,2:##}     | @           ", handPlayer1[2].image, handPlayer1[2].val, handPlayer2[2].image, handPlayer2[2].val);
//             Console.WriteLine("         @ |     {0} {1,2:##}   |                 |  {2} {3,2:##}     | @           ", handPlayer1[3].image, handPlayer1[3].val, handPlayer2[3].image, handPlayer2[3].val);
//             Console.WriteLine("         = = =   {0} {1,2:##}   |                 |  {2} {3,2:##}   = = =          ", handPlayer1[4].image, handPlayer1[4].val, handPlayer2[4].image, handPlayer2[4].val);
//             Console.WriteLine("                 {0} {1,2:##}   |                 |  {2} {3,2:##}                 ", handPlayer1[5].image, handPlayer1[5].val, handPlayer2[5].image, handPlayer2[5].val);
//             Console.WriteLine("                 {0} {1,2:##}   |_________________|  {2} {3,2:##}                 ", handPlayer1[6].image, handPlayer1[6].val, handPlayer2[6].image, handPlayer2[6].val);
//             Console.WriteLine("        {0}                                         {1}           ", _player1, _player2);
//             Console.WriteLine("");
//             Console.WriteLine("");
//             Console.WriteLine("");
//             Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # ");
//             Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # ");
//             Console.WriteLine(" # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # ");

//         }
//     }
// }

// // using System;
// // using System.Text;

// // namespace DeckCards
// // {
// //     class Program
// //     {
// //         static void Main(string[] args)
// //         {

// //             Player Tony = new Player("Tony");
// //             Deck juego = new Deck();
// //             juego.Shuffle();

// //             Card myCard;

// //             for (int i = 0; i < 7; i++)
// //             {
// //                 myCard = Tony.Draw(juego);
// //                 Console.WriteLine("{0} - {1} ({2})", myCard.StringVal, (char)myCard.image, myCard.val);
// //             }
// //             Console.WriteLine((char)9824);
// //         }


// //     }
// // }
