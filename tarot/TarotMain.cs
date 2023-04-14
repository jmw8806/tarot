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
        string[] _card1;
        string[] _card2;
        string[] _card3;
        bool[] _isReversedList = new bool[3];
        public Tarot()
        {
            InitializeComponent();
        }

        private void Tarot_Load(object sender, EventArgs e)
        {

        }

        private void btnNewFortune_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            string[][] _newReading = _spread.newSpread(_helper.shuffleID(), _helper.shuffleID(), _helper.shuffleID());
           
            _card1 = _newReading[0];
            _card2 = _newReading[1];
            _card3 = _newReading[2];
          

            // Card 1
            var card1Img = (Image)_rm.GetObject(_card1[4]);
            bool reversed1 = _helper.isReversed();
            _isReversedList[0] = reversed1;
            lblCard1.Visible = true;
            lblCardDescription1.Visible = true;
            lblCard1.Text = _card1[1];
            if (reversed1)
            {
                lblCardDescription1.Text = _card1[3];
                card1Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox1.Image = card1Img;
            }
            else
            {
                lblCardDescription1.Text = _card1[2];
                pictureBox1.Image = (Image)_rm.GetObject(_card1[4]);
                lblReversed1.Visible = false;
            }
            lblReversed1.Visible = reversed1;


            //Card 2
            var card2Img = (Image)_rm.GetObject(_card2[4]);
            bool reversed2 = _helper.isReversed();
            _isReversedList[1] = reversed2;
            lblCard2.Visible = true;
            lblCardDescription2.Visible = true;
            lblCard2.Text = _card2[1];
            if (reversed2)
            {
                lblCardDescription2.Text = _card2[3];
                card2Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox2.Image = card2Img;
            }
            else
            {
                lblCardDescription2.Text = _card2[2];
                pictureBox2.Image = (Image)_rm.GetObject(_card2[4]);
            }

            lblReversed2.Visible = reversed2;

            //Card 3
            var card3Img = (Image)_rm.GetObject(_card3[4]);
            bool reversed3 = _helper.isReversed();
            _isReversedList[2] = reversed3;
            lblCard3.Visible = true;
            lblCardDescription3.Visible = true;
            lblCard3.Text = _card3[1];
            if (reversed3)
            {
                lblCardDescription3.Text = _card3[3];
                card3Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox3.Image = card3Img;
            }
            else
            {
                lblCardDescription3.Text = _card3[2];
                pictureBox3.Image = (Image)_rm.GetObject(_card3[4]);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal();
            journal.Show();
        }
    }
}
