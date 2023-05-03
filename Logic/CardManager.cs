using DataObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class CardManager
    {
        // method takes a list of Card objects representing a deck and a card's ID and returns the data about that given card.
        public static string[] getCardById(List<Card> deck, string cardId) {

            string[] cardById = new string[5];
            foreach (Card card in deck)
            {   
                if (card.getCardId() == cardId)
                {
                    cardById = new string[] { card.getCardId(), card.getCardName(), card.getCardUprightDescription(), card.getCardReversedDescription(), card.getCardImage() };
                }
            }
            return cardById;
        }

    }
}
