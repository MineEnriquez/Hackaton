using System;
using System.Collections.Generic;

namespace DeckCards{
    class Player{
        public string Name {get; set;}
        public List<Card> Hand = new List<Card>();
        /// <summary>
        /// Constructor: Take no parameters
        /// </summary>
        public Player(string _name)
        {
            this.Name = _name;
        }

        public Card Draw(Deck _deck){
            Card _card = new Card();
            _card = _deck.Deal();
            this.Hand.Add(_card);
            return _card;
        }

        public Card Discard(int _index){
            Card _card = new Card();
            if (_index > this.Hand.Count-1 || _index < 0){
                return null;
            }
            else {
                _card = this.Hand[_index];
                this.Hand.RemoveAt(_index);
            }
            return _card;
        }
    }
}