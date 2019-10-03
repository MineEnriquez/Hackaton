/// <summary>
/// CLASS: 
/// </summary>
using System;
using System.Collections.Generic;

namespace DeckCards
{
    class Deck
    {
        List<Card> Cards;
        public int Count=0;
        public Deck()
        {
            GenerateDeck();
        }

        // * Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
        /// <summary>
        /// Method: Deal
        /// Selects the "top-most" card, 
        /// REMOVES it from the list of cards, 
        /// and returns the Card.
        /// </summary>
        /// <returns>Object Card</returns>
        public Card Deal()
        {
            Card topmost = Cards[0]; //?????
            Cards.RemoveAt(0);
            this.Count--;
            return topmost;
        }


        // * Give the Deck a reset method that resets the cards property to contain the original 52 cards.
        public void Reset()
        {
            GenerateDeck();
        }

        // * Give the Deck a shuffle method that randomly reorders the deck's cards.
        public void Shuffle()
        {
            Random r = new Random();
            for (int n = 52 - 1; n > 0; --n)
            {
                int newPos = r.Next(n + 1);
                Card temp = this.Cards[n];
                Cards[n] = Cards[newPos];
                Cards[newPos] = temp;
            }
        }

        private void GenerateDeck()
        {
            Cards = new List<Card>();
            string[] stringVals = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = new string[] { "Clubs", "Spades", "Hearts", "Diamonds" };

            foreach (string s in suits)
            {
                int v = 1;
                foreach (string sv in stringVals)
                {
                    this.Cards.Add(new Card(sv, s, v));
                    v++;
                }
            }
            this.Count = 52;
        }

    }
}