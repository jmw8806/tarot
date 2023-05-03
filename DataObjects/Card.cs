using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    // Reperesents each tarot card
    public class Card
    {
        private string _id;
        private string _name;
        private string _upright_description;
        private string _reversed_description;
        private string _image;
        

        public Card(string id, string name, string upright_description, string reversed_description, string image)
        {
            _id = id;
            _name = name;
            _upright_description = upright_description;
            _reversed_description = reversed_description;
            _image = image;          
        }

        public string getCardName()
        {
            return _name;
        }

        public string getCardId()
        {
            return _id;
        }
        public string getCardUprightDescription()
        {
            return _upright_description.ToLower();
        }

        public string getCardReversedDescription()
        {
            return _reversed_description.ToLower();
        }

        public string getCardImage()
        {
            return _image;
        }
    }
}
