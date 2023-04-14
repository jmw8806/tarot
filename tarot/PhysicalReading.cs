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
        }

        private void checkBoxReversed1_CheckedChanged(object sender, EventArgs e)
        {
            var card1Img = (Image)_rm.GetObject(_card1[4]);
            if (checkBoxReversed1.Checked)
            {
                textDescription1.Text = _card1[3];
                card1Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                imgCard1.Image = card1Img;
            }
            else
            {
                textDescription1.Text = _card1[2];
                imgCard1.Image = (Image)_rm.GetObject(_card1[4]);
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
        }

        private void checkBoxReversed2_CheckedChanged(object sender, EventArgs e)
        {
            var card2Img = (Image)_rm.GetObject(_card2[4]);
            if (checkBoxReversed2.Checked)
            {
                textDescription2.Text = _card2[3];
                card2Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                imgCard2.Image = card2Img;
            }
            else
            {
                textDescription2.Text = _card2[2];
                imgCard2.Image = (Image)_rm.GetObject(_card2[4]);
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

        }

        private void checkBoxReversed3_CheckedChanged(object sender, EventArgs e)
        {
            var card3Img = (Image)_rm.GetObject(_card3[4]);
            if (checkBoxReversed3.Checked)
            {
                textDescription3.Text = _card3[3];
                card3Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                imgCard3.Image = card3Img;
            }
            else
            {
                textDescription3.Text = _card3[2];
                imgCard3.Image = (Image)_rm.GetObject(_card3[4]);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
