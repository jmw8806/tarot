using Logic;
using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace tarot
{
    public partial class PhysicalReading : Form
    {
        Spread _spread = new Spread();
        ResourceManager _rm = new ResourceManager("Tarot.Resource", Assembly.GetExecutingAssembly());
        string[] _card1 = new string[5];
        string[] _card2 = new string[5];
        string[] _card3 = new string[5];
        bool[] _isReversedList = { false, false, false };
        

        public PhysicalReading()
        {
            InitializeComponent();
        }

        private void listName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listName1.SelectedIndex;
            checkBoxReversed1.Enabled = true;
            checkBoxReversed1.Checked = false;
            _card1 = _spread.findCardByID(selectedIndex.ToString());
            textDescription1.Text = _card1[2];
            imgCard1.Image = (Image)_rm.GetObject(_card1[4]);
            if(_card1[2] != null && _card2[2] != null && _card3[3] != null)
                {
                btnSave.Enabled = true;
                }
        }

        private void checkBoxReversed1_CheckedChanged(object sender, EventArgs e)
        {
            var card1Img = (Image)_rm.GetObject(_card1[4]);
            if (checkBoxReversed1.Checked)
            {
                textDescription1.Text = _card1[3];
                card1Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                imgCard1.Image = card1Img;
                _isReversedList[0] = true;
            }
            else
            {
                textDescription1.Text = _card1[2];
                imgCard1.Image = (Image)_rm.GetObject(_card1[4]);
                _isReversedList[0] = false;
            }
           
        }

        private void listName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listName2.SelectedIndex;
            checkBoxReversed2.Enabled = true;
            checkBoxReversed2.Checked = false;
            _card2 = _spread.findCardByID(selectedIndex.ToString());
            textDescription2.Text = _card2[2];
            imgCard2.Image = (Image)_rm.GetObject(_card2[4]);
            if (_card1[2] != null && _card2[2] != null && _card3[3] != null)
            {
                btnSave.Enabled = true;
            }
        }

        private void checkBoxReversed2_CheckedChanged(object sender, EventArgs e)
        {
            var card2Img = (Image)_rm.GetObject(_card2[4]);
            if (checkBoxReversed2.Checked)
            {
                textDescription2.Text = _card2[3];
                card2Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                imgCard2.Image = card2Img;
                _isReversedList[1] = true;
            }
            else
            {
                textDescription2.Text = _card2[2];
                imgCard2.Image = (Image)_rm.GetObject(_card2[4]);
                _isReversedList[1] = false;
            }
        }

        private void listName3_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = listName3.SelectedIndex;
            checkBoxReversed3.Enabled = true;
            checkBoxReversed3.Checked = false;
            _card3 = _spread.findCardByID(selectedIndex.ToString());
            textDescription3.Text = _card3[2];
            imgCard3.Image = (Image)_rm.GetObject(_card3[4]);
            if (_card1[2] != null && _card2[2] != null && _card3[3] != null)
            {
                btnSave.Enabled = true;
            }

        }

        private void checkBoxReversed3_CheckedChanged(object sender, EventArgs e)
        {
            var card3Img = (Image)_rm.GetObject(_card3[4]);
            if (checkBoxReversed3.Checked)
            {
                textDescription3.Text = _card3[3];
                card3Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                imgCard3.Image = card3Img;
                _isReversedList[2] = true;
            }
            else
            {
                textDescription3.Text = _card3[2];
                imgCard3.Image = (Image)_rm.GetObject(_card3[4]);
                _isReversedList[2] = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Journal.setJournalEntry(_card1[0], _card2[0], _card3[0], _isReversedList);
            JournalEntry journal = new JournalEntry();
            journal.Show();
        }
    }
}
