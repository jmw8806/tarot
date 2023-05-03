using DataAccess;
using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    // Compiles a list of all Card objects.
    public class DeckManager
    {
        private List<Card> _deck;
        public DeckManager()
        {
            string[] card = new string[5];

            try
            {
                if (_deck == null)
                {
                    DataAccessor dataAccess = new DataAccessor();
                    List<Card> cards = dataAccess.BuildCards();
                    _deck = cards;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Data not available", ex);
            }
        }

        public List<Card> newDeck()
        {
            return _deck;
        }
    }
}
