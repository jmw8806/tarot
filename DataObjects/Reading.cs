using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Reading
    {
        private string _date;
        private string _card1Id;
        private string _card2Id;
        private string _card3Id;
        private string _isReverse1;
        private string _isReverse2;
        private string _isReverse3;
        private string _reflection;
        public Reading(string date, string card1Id, string card2Id, string card3Id, string isReverse1, string isReverse2, string isReverse3, string reflection = "")
        {
            _date = date;
            _card1Id = card1Id;
            _card2Id = card2Id;
            _card3Id = card3Id;
            _isReverse1 = isReverse1;
            _isReverse2 = isReverse2;
            _isReverse3 = isReverse3;
            _reflection = reflection;
        }

        public string[] getReading()
        {
            string[] reading = { _date, _card1Id, _card2Id, _card3Id, _isReverse1, _isReverse2, _isReverse3, _reflection };
            return reading;
        }

        public string getDate()
        {
            return _date;
        }

        public string getCard1Id()
        {
            return _card1Id;
        }
        public string getCard2Id()
        {
            return _card2Id;
        }
        public string getCard3Id()
        {
            return _card3Id;
        }
        public string isReverse1()
        {
            return _isReverse1;
        }
        public string isReverse2()
        {
            return _isReverse2;
        }
        public string isReverse3()
        {
            return _isReverse3;
        }
        public string getReflection()
        {
            return _reflection; ;
        }
    }
}
