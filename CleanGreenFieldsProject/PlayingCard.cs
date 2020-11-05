﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanGreenFieldsProject
{
  public class PlayingCard
    {
        private List<Card> _Deck;
        public PlayingCard()
        {
            _Deck = new List<Card>();
        }
        public List<Card> CreateDeck()
        {
            foreach (CardFace cardFace in Enum.GetValues(typeof(CardFace)))
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    _Deck.Add(new Card(cardFace, suit));
                }
            }

            return _Deck;
        }


        public void Shuffle()
        {

            Random rand = new Random();

            for (int i = 0; i < _Deck.Count; i++)
            {
                // Random for remaining positions. 
                int r = i + rand.Next(_Deck.Count - i);

                //swapping the elements 
                Card temp = _Deck[r];
                _Deck[r] = _Deck[i];
                _Deck[i] = temp;

            }
        }
    }
}