using DataObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CardManager
    {
        Deck _deck = new Deck();
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
