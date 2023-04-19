﻿using DataAccess;
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
    public partial class JournalEntry : Form
    {
        ResourceManager _rm = new ResourceManager("Tarot.Resource", Assembly.GetExecutingAssembly());
        string[][] _reading = new string[3][];
        DateTime _date;
        string _card1Id;
        string _card2Id;
        string _card3Id;
        string _isReverse1;
        string _isReverse2;
        string _isReverse3;
        string _journal_entry = "";
        Reading _saveReading = null;
        List<Reading> _readings = null;

        public JournalEntry()
        {
            InitializeComponent();
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            
            _readings = Journal.getAllEntries();
            _reading = Journal.getJournalEntry();
            foreach(Reading item in _readings)
            {
                listFileList.Items.Add(item.getDate());
            }
            if (_reading[0] != null || _reading[1] != null || _reading[2] != null)
            {
                string[] reading1 = _reading[0];
                string[] reading2 = _reading[1];
                string[] reading3 = _reading[2];
                _isReverse1 = reading1[5];
                 _isReverse2 = reading2[5];
                 _isReverse3 = reading3[5];
               _card1Id = reading1[0];
               _card2Id = reading2[0];
               _card3Id = reading3[0];
                var reading1Img = (Image)_rm.GetObject(reading1[4]);
                var reading2Img = (Image)_rm.GetObject(reading2[4]);
                var reading3Img = (Image)_rm.GetObject(reading3[4]);

                //reading 1
                lblName1.Text = reading1[1];
                imgCard1.Image = reading1Img;
                lblReverse1.Text = _isReverse1;
                txtDescription1.Text = reading1[2];
                if (_isReverse1 == "Reversed")
                {
                    txtDescription1.Text = reading1[3];
                    reading1Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                    imgCard1.Image = reading1Img;
                }


                //reading 2
                lblName2.Text = reading2[1];
                imgCard2.Image = reading2Img;
                lblReverse2.Text = _isReverse2;
                txtDescription2.Text = reading2[2];
                if (_isReverse2 == "Reversed")
                {
                    txtDescription2.Text = reading2[3];
                    reading2Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                    imgCard2.Image = reading2Img;
                }

                //reading 3
                lblName3.Text = reading3[1];
                imgCard3.Image = reading3Img;
                lblReverse3.Text = _isReverse3;
                txtDescription3.Text = reading3[2];
                if (_isReverse3 == "Reversed")
                {
                    txtDescription3.Text = reading3[3];
                    reading3Img.RotateFlip(RotateFlipType.Rotate180FlipX);
                    imgCard3.Image = reading3Img;
                }
            } 
            else
            {
                var cardBack = (Image)_rm.GetObject("back.jpg");
                imgCard1.Image = cardBack; 
                imgCard2.Image = cardBack;
                imgCard3.Image = cardBack;
            }

        }

        private void txtJournalEntry_Enter(object sender, EventArgs e)
        {
            if (txtJournalEntry.Text == "Enter your reflections here...")
            {
                txtJournalEntry.Text = "";
                
            }
            else
            {
                _journal_entry = txtJournalEntry.Text;
            }
        }

        private void txtJournalEntry_Leave(object sender, EventArgs e)
        {
            if (txtJournalEntry.Text == "")
            {
                txtJournalEntry.Text = "Use this area to journal your intention and thoughts on your reading.";
            } 
            else
            {
                _journal_entry = txtJournalEntry.Text;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _date = DateTime.UtcNow.Date;
            _saveReading = new Reading(_date.ToString("MM/dd/yyyy"), _card1Id, _card2Id, _card3Id, _isReverse1, _isReverse2, _isReverse3, _journal_entry);
            _readings.Add(_saveReading);
            try
            {
                Journal.saveToJournal(_readings);
                MessageBox.Show("Your entry was saved");
                foreach (Reading item in _readings)
                {
                    listFileList.Items.Add(item.getDate());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not save at this time", ex);
            }

        }
    }
}