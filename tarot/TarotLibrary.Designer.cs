
namespace tarot
{
    partial class TarotLibrary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listLibrary = new System.Windows.Forms.ListBox();
            this.imgCardLibrary = new System.Windows.Forms.PictureBox();
            this.lblUpright = new System.Windows.Forms.Label();
            this.lblReversed = new System.Windows.Forms.Label();
            this.lblReferenceTitle = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReversedDescription = new System.Windows.Forms.TextBox();
            this.lblUprightDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCardLibrary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listLibrary
            // 
            this.listLibrary.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listLibrary.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLibrary.ForeColor = System.Drawing.Color.Coral;
            this.listLibrary.FormattingEnabled = true;
            this.listLibrary.ItemHeight = 27;
            this.listLibrary.Items.AddRange(new object[] {
            "The Fool",
            "The Magician",
            "The High Priestess ",
            "The Emperor",
            "The Hierophant",
            "The Lovers",
            "The Chariot",
            "Strength",
            "The Hermit",
            "Wheel of Fortune",
            "Justice",
            "The Hanged Man",
            "Death",
            "Temperance",
            "The Devil",
            "The Tower",
            "The Star",
            "The Moon",
            "The Sun",
            "Judgement",
            "The World",
            "High Priestess",
            "Justice",
            "Ace of Wands",
            "Two of Wands",
            "Three of Wands",
            "Four of Wands",
            "Five of Wands",
            "Six of Wands",
            "Seven of Wands",
            "Eight of Wands",
            "Nine of Wands",
            "Ten of Wands",
            "Page of Wands",
            "Knight of Wands",
            "Queen of Wands",
            "King of Wands",
            "Ace of Cups",
            "Two of Cups",
            "Three of Cups",
            "Four of Cups",
            "Five of Cups",
            "Six of Cups",
            "Seven of Cups",
            "Eight of Cups",
            "Nine of Cups",
            "Ten of Cups",
            "Page of Cups",
            "Knight of Cups",
            "Queen of Cups",
            "King of Cups",
            "Ace of Swords",
            "Two of Swords",
            "Three of Swords",
            "Four of Swords",
            "Five of Swords",
            "Six of Swords",
            "Seven of Swords",
            "Eight of Swords",
            "Nine of Swords",
            "Ten of Swords",
            "Page of Swords",
            "Knight of Swords",
            "Queen of Swords",
            "King of Swords",
            "Ace of Pentacles",
            "Two of Pentacles",
            "Three of Pentacles",
            "Four of Pentacles",
            "Five of Pentacles",
            "Six of Pentacles",
            "Seven of Pentacles",
            "Eight of Pentacles",
            "Nine of Pentacles",
            "Ten of Pentacles",
            "Page of Pentacles",
            "Knight of Pentacles",
            "Queen of Pentacles",
            "King of Pentacles"});
            this.listLibrary.Location = new System.Drawing.Point(64, 112);
            this.listLibrary.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listLibrary.Name = "listLibrary";
            this.listLibrary.Size = new System.Drawing.Size(160, 353);
            this.listLibrary.TabIndex = 0;
            this.listLibrary.SelectedIndexChanged += new System.EventHandler(this.listLibrary_SelectedIndexChanged);
            // 
            // imgCardLibrary
            // 
            this.imgCardLibrary.BackColor = System.Drawing.Color.Coral;
            this.imgCardLibrary.Location = new System.Drawing.Point(208, 79);
            this.imgCardLibrary.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.imgCardLibrary.Name = "imgCardLibrary";
            this.imgCardLibrary.Size = new System.Drawing.Size(183, 368);
            this.imgCardLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCardLibrary.TabIndex = 1;
            this.imgCardLibrary.TabStop = false;
            // 
            // lblUpright
            // 
            this.lblUpright.AutoSize = true;
            this.lblUpright.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblUpright.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpright.ForeColor = System.Drawing.Color.MistyRose;
            this.lblUpright.Location = new System.Drawing.Point(428, 116);
            this.lblUpright.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUpright.Name = "lblUpright";
            this.lblUpright.Size = new System.Drawing.Size(144, 20);
            this.lblUpright.TabIndex = 2;
            this.lblUpright.Text = "Upright Description:";
            // 
            // lblReversed
            // 
            this.lblReversed.AutoSize = true;
            this.lblReversed.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblReversed.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReversed.ForeColor = System.Drawing.Color.MistyRose;
            this.lblReversed.Location = new System.Drawing.Point(428, 282);
            this.lblReversed.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblReversed.Name = "lblReversed";
            this.lblReversed.Size = new System.Drawing.Size(151, 20);
            this.lblReversed.TabIndex = 4;
            this.lblReversed.Text = "Reversed Description:";
            // 
            // lblReferenceTitle
            // 
            this.lblReferenceTitle.AutoSize = true;
            this.lblReferenceTitle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblReferenceTitle.Font = new System.Drawing.Font("Harlow Solid Italic", 20F, System.Drawing.FontStyle.Italic);
            this.lblReferenceTitle.ForeColor = System.Drawing.Color.Coral;
            this.lblReferenceTitle.Location = new System.Drawing.Point(17, 23);
            this.lblReferenceTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblReferenceTitle.Name = "lblReferenceTitle";
            this.lblReferenceTitle.Size = new System.Drawing.Size(258, 34);
            this.lblReferenceTitle.TabIndex = 6;
            this.lblReferenceTitle.Text = "Tarot Card Reference";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCardName.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.ForeColor = System.Drawing.Color.Coral;
            this.lblCardName.Location = new System.Drawing.Point(429, 70);
            this.lblCardName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(90, 40);
            this.lblCardName.TabIndex = 7;
            this.lblCardName.Text = "Name";
            this.lblCardName.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Controls.Add(this.lblUpright);
            this.groupBox1.Controls.Add(this.lblCardName);
            this.groupBox1.Controls.Add(this.lblReversedDescription);
            this.groupBox1.Controls.Add(this.lblUprightDescription);
            this.groupBox1.Controls.Add(this.imgCardLibrary);
            this.groupBox1.Controls.Add(this.lblReferenceTitle);
            this.groupBox1.Controls.Add(this.lblReversed);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(40, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.MinimumSize = new System.Drawing.Size(602, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(789, 500);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblReversedDescription
            // 
            this.lblReversedDescription.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblReversedDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblReversedDescription.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.lblReversedDescription.ForeColor = System.Drawing.Color.Coral;
            this.lblReversedDescription.Location = new System.Drawing.Point(435, 314);
            this.lblReversedDescription.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lblReversedDescription.Multiline = true;
            this.lblReversedDescription.Name = "lblReversedDescription";
            this.lblReversedDescription.Size = new System.Drawing.Size(322, 133);
            this.lblReversedDescription.TabIndex = 8;
            this.lblReversedDescription.Visible = false;
            // 
            // lblUprightDescription
            // 
            this.lblUprightDescription.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblUprightDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblUprightDescription.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold);
            this.lblUprightDescription.ForeColor = System.Drawing.Color.Coral;
            this.lblUprightDescription.Location = new System.Drawing.Point(431, 146);
            this.lblUprightDescription.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lblUprightDescription.Multiline = true;
            this.lblUprightDescription.Name = "lblUprightDescription";
            this.lblUprightDescription.Size = new System.Drawing.Size(326, 129);
            this.lblUprightDescription.TabIndex = 7;
            this.lblUprightDescription.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::tarot.Resource.aibackground;
            this.ClientSize = new System.Drawing.Size(860, 570);
            this.Controls.Add(this.listLibrary);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximumSize = new System.Drawing.Size(884, 630);
            this.MinimumSize = new System.Drawing.Size(876, 609);
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarot Reference";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imgCardLibrary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLibrary;
        private System.Windows.Forms.PictureBox imgCardLibrary;
        private System.Windows.Forms.Label lblUpright;
        private System.Windows.Forms.Label lblReversed;
        private System.Windows.Forms.Label lblReferenceTitle;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lblReversedDescription;
        private System.Windows.Forms.TextBox lblUprightDescription;
    }
}