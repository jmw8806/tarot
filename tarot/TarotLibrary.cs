using DataObjects;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarot
{
    public partial class TarotLibrary : Form
    {
        ResourceManager _rm = new ResourceManager("Tarot.Resource", Assembly.GetExecutingAssembly());
        Deck _deck = new Deck();
        
        public TarotLibrary()
        {
            InitializeComponent();
        }

        private void listLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Card> deck = _deck.newDeck();
            int selectedIndex = listLibrary.SelectedIndex;
            string[] card = CardManager.getCardById(deck, selectedIndex.ToString());
            lblCardName.Visible = true;
            lblCardName.Text = card[1];
            lblUprightDescription.Visible = true;
            lblUprightDescription.Text = card[2];
            lblReversedDescription.Visible = true;
            lblReversedDescription.Text = card[3];
            imgCardLibrary.Image = (Image)_rm.GetObject(card[4]);
        }
    }
}
