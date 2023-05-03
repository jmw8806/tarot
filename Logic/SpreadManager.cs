using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataObjects;

namespace Logic
{
    // Class that handles the "spread" of cards dealt to the user.
    public class SpreadManager
    {
        private DeckManager _deck = new DeckManager();
        private Helpers _helper = new Helpers();
        private static string[][] _spread = new string[3][];
        
        // Takes three cards ids as arguments, while loop continues until 3 unique cards are returned
        public string[][] newSpread(string id1, string id2, string id3)
        {
            try
            {
                List<Card> deck = _deck.newDeck();
                _spread[0] = CardManager.getCardById(deck, id1);
                _spread[1] = CardManager.getCardById(deck, id2);
                _spread[2] = CardManager.getCardById(deck, id3);
                while (_spread[0][0] == _spread[1][0] || _spread[0][0] == _spread[2][0] || _spread[1][0] == _spread[2][0])
                {
                    _spread[1] = CardManager.getCardById(deck, _helper.shuffleID());
                    _spread[2] = CardManager.getCardById(deck, _helper.shuffleID());
                }
                return _spread;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error accessing deck data", ex);
            }
        }

        // takes card ID as argument, returns the card with that ID.
        public string[] findCardByID(string cardID)
        {
            try
            {
                List<Card> cards = _deck.newDeck();
                string[] cardByID = new string[5];
                foreach (Card card in cards)
                {
                    if (card.getCardId() == cardID)
                    {
                        cardByID = new string[] { card.getCardId(), card.getCardName(), card.getCardUprightDescription(), card.getCardReversedDescription(), card.getCardImage() };
                    }

                }
                return cardByID;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Could not access card data", ex);
            }
        }

    }
}
