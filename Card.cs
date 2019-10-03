using System;

namespace DeckCards
{
    public class Card
    {

        // * Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). 
        //  This "val" should be a string.
        // * Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds).
        // * Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers.

        // properties
        public string StringVal { get; set; }
        public string suit { get; set; }
        public int val { get; set; }

        public char image { get; set; }

        /// <summary>
        /// Constructor: Overload 1
        /// </summary>
        public Card()
        {

        }

        /// <summary>
        /// Constructor: Overload 2
        /// </summary>
        /// <param name="_stringVal"></param>
        /// <param name="_suit"></param>
        /// <param name="_val"></param>
        public Card(string _stringVal, string _suit, int _val)
        {
            this.StringVal = _stringVal;
            this.suit = _suit;
            this.val = _val;
            switch (_suit.ToLower())  {
                case "clubs":
                    this.image = '\u2663';
                    break;
                case "spades":
                    this.image = '\u2660';
                    break;
                case "diamonds":
                    this.image = '\u2666';
                    break;
                case "hearts":
                    this.image = '\u2665';
                    break;
            }
        }


    }
}