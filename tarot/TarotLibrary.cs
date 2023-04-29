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
        Spread _spread = new Spread();
        Helpers _helper = new Helpers();
        
        public TarotLibrary()
        {
            InitializeComponent();
            
        }

        private void listLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listLibrary.SelectedIndex;
            try
            {
                string[] card = _spread.findCardByID(selectedIndex.ToString());
                lblCardName.Visible = true;
                lblCardName.Text = card[1];
                lblUprightDescription.Visible = true;
                lblUprightDescription.Text = card[2];
                lblReversedDescription.Visible = true;
                lblReversedDescription.Text = card[3];
                imgCardLibrary.Image = (Image)_rm.GetObject(card[4]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            try
            {
                _helper.openHelper();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
