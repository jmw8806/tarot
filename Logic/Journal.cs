using DataAccess;
using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class  Journal
    {
        private static string[][] _journalEntry = new string[3][];
        private static DataAccessor _data = new DataAccessor();
        public static void setJournalEntry(string id1, string id2, string id3, bool[] isReversed)
        {
            try
            {
                Spread spread = new Spread();

                string[] card1 = spread.findCardByID(id1);
                string[] card2 = spread.findCardByID(id2);
                string[] card3 = spread.findCardByID(id3);

                string[] reading1 = new string[6];
                for (int i = 0; i < card1.Length; i++)
                {
                    reading1[i] = card1[i];
                }
                if (isReversed[0])
                {
                    reading1[5] = "Reversed";
                }
                else
                {
                    reading1[5] = "";
                }
                _journalEntry[0] = reading1;

                string[] reading2 = new string[6];
                for (int i = 0; i < card2.Length; i++)
                {
                    reading2[i] = card2[i];
                }
                if (isReversed[1])
                {
                    reading2[5] = "Reversed";
                }
                else
                {
                    reading2[5] = "";
                }
                _journalEntry[1] = reading2;

                string[] reading3 = new string[6];
                for (int i = 0; i < card3.Length; i++)
                {
                    reading3[i] = card3[i];
                }
                if (isReversed[2])
                {
                    reading3[5] = "Reversed";
                }
                else
                {
                    reading3[5] = "";
                }
                _journalEntry[2] = reading3;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Journal data not accessible at this time", ex);
            }

        }


        public static string[][] getJournalEntry()
        {
            return _journalEntry;
        }

        public static List<Reading> getAllEntries()
        {
            try
            {
                List<Reading> allReadings = _data.LoadReadings();
                return allReadings;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Readings are not accessible at this time", ex);
            }
        }

        public static void saveToJournal(List<Reading> readings)
        {
            try
            {
                _data.SaveSpread(readings);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static string[][] loadJournalEntry(List<Reading> readings, int index)
        {
            try
            {
                Deck deckObject = new Deck();

                List<Card> deck = deckObject.newDeck();
                Reading reading = readings[index];
                string[] card1 = new string[7];
                string[] card2 = new string[7];
                string[] card3 = new string[7];
                string[] tempcard1 = CardManager.getCardById(deck, reading.getCard1Id());
                string[] tempcard2 = CardManager.getCardById(deck, reading.getCard2Id());
                string[] tempcard3 = CardManager.getCardById(deck, reading.getCard3Id());

                for (int i = 0; i < 5; i++)
                {
                    card1[i] = tempcard1[i];
                    card2[i] = tempcard2[i];
                    card3[i] = tempcard3[i];
                }

                card1[5] = reading.isReverse1();
                card1[6] = reading.getReflection();

                card2[5] = reading.isReverse2();
                card2[6] = reading.getReflection();

                card3[5] = reading.isReverse3();
                card3[6] = reading.getReflection();

                string[][] journalEntry = { card1, card2, card3 };
                return journalEntry;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Data not available", ex);
            }
        }
    }
}
