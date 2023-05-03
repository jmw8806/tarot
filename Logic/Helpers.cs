using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    // Helpful methods 
    public class Helpers
    {
        // Returns a random number between 0 and 78. Helpful for getting random cards for readings
        private Random _random = new Random();
        public string shuffleID()
        {           
            return _random.Next(0, 78).ToString();          
        }

        // Returns random true or false value. Helpful to determine if a card is "drawn" as reversed.
        public bool isReversed()
        {
            return _random.Next(2) == 1;
        }

        // Access to the tarotReaderHelp.pdf. Used for all help sections in the program.
        public void openHelper()
        {
            try
            {
                DataAccess.DataAccessor.openHelper();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Help is not available", ex);
            }
        }
    }

    
}
