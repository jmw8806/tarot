using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataObjects;

namespace Logic
{
    public class Spread
    {
        private Deck _deck = new Deck();
        private string[][] _currentSpread = new string[3][]; 
        private Helpers _helper = new Helpers();
        private static string[][] _spread = new string[3][];
        
        public string[][] newSpread(string id1, string id2, string id3)
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

        public string[][] newSpread()
        {
            return _spread;
        }

        public void setSpread(string[][] spread)
        {
            _currentSpread = spread;
        }

        public void setSpread(string[] card1, string[] card2, string[] card3, bool[] isReversed)
        {
            string[] cards1 = new string[6];
            for(int i = 0; i < card1.Length; i++)
            {
                cards1[i] = card1[i];
            }
            cards1[5] = isReversed[0].ToString();
            _currentSpread[0] = cards1;

            string[] cards2 = new string[6];
            for (int i = 0; i < card2.Length; i++)
            {
                cards2[i] = card2[i];
            }
            cards2[5] = isReversed[1].ToString();
            _currentSpread[1] = cards2;

            string[] cards3 = new string[6];
            for (int i = 0; i < card3.Length; i++)
            {
                cards3[i] = card3[i];
            }
            cards3[5] = isReversed[2].ToString();
            _currentSpread[2] = cards3;

        }

        public string[][] getSpread()
        {
            return _currentSpread;
        }
        
        public string[] findCardByID(string cardID)
        {
            List<Card> cards = _deck.newDeck();
            string[] cardByID = new string[5];
            foreach(Card card in cards)
            {
                if (card.getCardId() == cardID)
                {
                    cardByID = new string[] { card.getCardId(), card.getCardName(), card.getCardUprightDescription(), card.getCardReversedDescription(), card.getCardImage() };
                }

            }
            return cardByID;
        }

    }
}
