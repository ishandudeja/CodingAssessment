using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanGreenFieldsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCard playingCard = new PlayingCard();
            List<Card> deck = playingCard.CreateDeck();
            playingCard.Shuffle();
            List<Card> myCards = playingCard.GetYou3Cards();
            Console.WriteLine("Welcome to Card Game");
            bool result = true;

            do
            {

                Console.WriteLine("You have these cards");
                playingCard.ShowCards(myCards);
                Console.WriteLine("To Show you cards, Please enter card index");
                int cardIndex = Convert.ToInt32(Console.ReadLine());
                if (cardIndex <= myCards.Count && cardIndex > 0)
                {
                    result = playingCard.GetWinResult(myCards[cardIndex]);
                    myCards.RemoveAt(cardIndex - 1);
                }
            } while (result);
            Console.ReadKey();
        }
    }
}
