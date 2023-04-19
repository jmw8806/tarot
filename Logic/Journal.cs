﻿using DataAccess;
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


        public static string[][] getJournalEntry()
        {
            return _journalEntry;
        }

        public static List<Reading> getAllEntries()
        {
            
            List<Reading> allReadings = _data.LoadReadings();
            return allReadings;
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
    }
}