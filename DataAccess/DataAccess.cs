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
                var filePath = @"C:\\Users\\jmw66\\source\repos\\tarot\\tarot\\bin\\Debug\\data\\tarot_info.txt";
                StreamReader fileReader = new StreamReader(filePath);

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
          
    }
}
