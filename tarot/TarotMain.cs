using Logic;
using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace tarot
{
    public partial class Tarot : Form
    {
        ResourceManager _rm = new ResourceManager("Tarot.Resource", Assembly.GetExecutingAssembly());
        Helpers _helper = new Helpers();
        Spread _spread = new Spread();
        string[][] _reading = new string[3][];
        public Tarot()
        {
            InitializeComponent();
        }

        private void Tarot_Load(object sender, EventArgs e)
        {

        }

        private void btnNewFortune_Click(object sender, EventArgs e)
        {
            btnJournal.Visible = true;
            string[][] _reading = _spread.newSpread(_helper.shuffleID(), _helper.shuffleID(), _helper.shuffleID());
            _spread.setSpread(_reading);
            string[] card1 = _reading[0];
            string[] card2 = _reading[1];
            string[] card3 = _reading[2];

            // Card 1
            var card1Img = (Image)_rm.GetObject(card1[4]);
            bool reversed1 = _helper.isReversed();
            lblCard1.Visible = true;
            lblCardDescription1.Visible = true;
            lblCard1.Text = card1[1];
            if (reversed1)
            {
                lblCardDescription1.Text = card1[3];
                card1Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox1.Image = card1Img;
            }
            else
            {
                lblCardDescription1.Text = card1[2];
                pictureBox1.Image = (Image)_rm.GetObject(card1[4]);
                lblReversed1.Visible = false;
            }
            lblReversed1.Visible = reversed1;


            //Card 2
            var card2Img = (Image)_rm.GetObject(card2[4]);
            bool reversed2 = _helper.isReversed();
            lblCard2.Visible = true;
            lblCardDescription2.Visible = true;
            lblCard2.Text = card2[1];
            if (reversed2)
            {
                lblCardDescription2.Text = card2[3];
                card2Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox2.Image = card2Img;
            }
            else
            {
                lblCardDescription2.Text = card2[2];
                pictureBox2.Image = (Image)_rm.GetObject(card2[4]);
            }

            lblReversed2.Visible = reversed2;

            //Card 3
            var card3Img = (Image)_rm.GetObject(card3[4]);
            bool reversed3 = _helper.isReversed();
            lblCard3.Visible = true;
            lblCardDescription3.Visible = true;
            lblCard3.Text = card3[1];
            if (reversed3)
            {
                lblCardDescription3.Text = card3[3];
                card3Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox3.Image = card3Img;
            }
            else
            {
                lblCardDescription3.Text = card3[2];
                pictureBox3.Image = (Image)_rm.GetObject(card3[4]);
            }
            lblReversed3.Visible = reversed3;
        }



        private void menuLibrary_Click(object sender, EventArgs e)
        {
            TarotLibrary tarotLibrary = new TarotLibrary();
            tarotLibrary.Show();
        }

        private void physicalReadingMenus_Click(object sender, EventArgs e)
        {
            PhysicalReading physicalReading = new PhysicalReading();
            physicalReading.Show();
        }
    }
}
