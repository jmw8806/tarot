﻿using DataObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataAccessor
    {
        // Accesses tarot_info.txt and returns a list of card objects that represent the tarot deck
        public List<Card> BuildCards()
        {
            List<Card> cards = new List<Card>();
           try
            {
         
                StreamReader fileReader = new StreamReader(AppData.DataPath + "\\tarot_info.txt");
                
                char[] separator = { '\t' };
                while (fileReader.EndOfStream == false)
                {
                    string line = fileReader.ReadLine();
                    string[] parts;
                    if(line.Length > 4)
                    {
                        parts = line.Split(separator);
                        if (parts.Count() == 5)
                        {
                            Card card = new Card(parts[0], parts[1], parts[2], parts[3], parts[4]);
                            cards.Add(card);
                        }
                    }
                }
                fileReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return cards;

        }

        // accesses the save_data.txt file and returns a list of Reading objects to be used to load saved journal entries.
        public List<Reading> LoadReadings()
        {
            List<Reading> readings = new List<Reading>();
            try
            {
                StreamReader fileReader = new StreamReader(AppData.DataPath + "\\save_data.txt");
                while (fileReader.EndOfStream == false)
                {
                    string line = fileReader.ReadLine();
                    string[] parts;
                    if(line.Length > 4)
                    {
                        parts = line.Split('\t');
                        
                        Reading reading = new Reading(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]);
                        readings.Add(reading);
                    }
                }
                fileReader.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return readings;
        }

        // access the save_data.txt file to write data from the program to it. Specifically used for journal entries to be saved
        public void SaveSpread(List<Reading> readings)
        {
            StreamWriter fileWriter = null;
            try
            {

                string line = "";
                fileWriter = new StreamWriter(AppData.DataPath + "\\save_data.txt");
                
                foreach (Reading reading in readings)
                {
                    line += reading.getDate() + "\t" + reading.getCard1Id() + "\t" + reading.getCard2Id() + "\t" + reading.getCard3Id() + "\t" +
                    reading.isReverse1() + "\t" + reading.isReverse2() + "\t" + reading.isReverse3() + "\t" + reading.getReflection() + "\n";

  
                }
                fileWriter.WriteLine(line);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                fileWriter.Close();
            }
        }

        // accesses the tarotReaderHelp.pdf "Help" file. This is the help documentation for the user.
        public static void openHelper()
        {
            Process fileopener = new Process();

            fileopener.StartInfo.FileName = AppData.DataPath + "\\tarotReaderHelp.pdf\\";
            fileopener.StartInfo.Arguments = "\\tarotReaderHelp.pdf\\";
            fileopener.Start();
        }

    }
}
