﻿using System;
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
        private string[][] _spread = new string[3][];
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

        public string[][] getSpread()
        {
            return _currentSpread;
        }
    }
}