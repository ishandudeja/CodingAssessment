using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanGreenFieldsProject
{
    public enum CardFace
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14

    }


    public enum Suit
    {
        Spades = 10,
        Clubes = 20,
        Hearts = 30,
        Diamonds = 40

    }

    public class Card
    {
        public CardFace CardFace { get; private set; }
        public Suit Suit { get; private set; }
        public int Value { get; private set; }

        public Card(CardFace cardFace, Suit suit)
        {
            CardFace = cardFace;
            Suit = suit;
            Value = Convert.ToInt32(cardFace) + Convert.ToInt32(suit);
        }

    }
}
