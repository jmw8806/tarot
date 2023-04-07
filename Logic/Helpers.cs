using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Helpers
    {
        private Random _random = new Random();
        public string shuffleID()
        {           
            return _random.Next(0, 78).ToString();          
        }

        public bool isReversed()
        {
            return _random.Next(2) == 1;
        }
    }

    
}
