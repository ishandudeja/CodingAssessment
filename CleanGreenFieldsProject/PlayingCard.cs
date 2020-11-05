using System;
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

        public void ShowCards(List<Card> Cards)
        {
            int index = 1;
            foreach (Card card in Cards)
            {
                Console.WriteLine("Index {2} :{0} of {1} ", card.CardFace.ToString(), card.Suit.ToString(), index);
                index++;
            }
        }

        public List<Card> GetYou3Cards()
        {
            _CompCards = _Deck.Take(3).ToList();
            return _Deck.Skip(_cardPick).Take(3).ToList();

        }

        public bool GetWinResult(Card card)
        {
            bool result = true;

            foreach (Card compCard in _CompCards)
            {
                if (compCard.Value > card.Value)
                {
                    Console.WriteLine("You lose Camputer has {0} of {1}", compCard.CardFace.ToString(), compCard.Suit.ToString());
                    result = false;
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine("You Win");
            }

            return result;

        }
    }
}
