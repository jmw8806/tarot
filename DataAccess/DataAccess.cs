using DataObjects;
using System;
using System.Collections.Generic;
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

        public void SaveSpread(string[][] cards)
        {
            try
            {
                string line = "";
                StreamWriter fileWriter = new StreamWriter(AppData.DataPath + "\\save_data.txt");
                for(int i = 0; i < cards.Length; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        line += j.ToString() + "\t";
                    }
                    line += cards[i][4].ToString() + "\n";                   
                }

                fileWriter.WriteLine(line);
            }
            catch (Exception)
            {
                throw;
            }
        }
          
    }
}
