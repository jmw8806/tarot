
namespace tarot
{
    partial class PhysicalReading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhysicalReading));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imgCard1 = new System.Windows.Forms.PictureBox();
            this.imgCard2 = new System.Windows.Forms.PictureBox();
            this.imgCard3 = new System.Windows.Forms.PictureBox();
            this.listName1 = new System.Windows.Forms.ComboBox();
            this.listName2 = new System.Windows.Forms.ComboBox();
            this.listName3 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textDescription1 = new System.Windows.Forms.TextBox();
            this.textDescription2 = new System.Windows.Forms.TextBox();
            this.textDescription3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCard3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.36719F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.63281F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.Controls.Add(this.textDescription3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textDescription2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBox3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listName3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.imgCard3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgCard2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imgCard1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listName1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textDescription1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.listName2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(97, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imgCard1
            // 
            this.imgCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCard1.Image = global::tarot.Resource.back;
            this.imgCard1.Location = new System.Drawing.Point(43, 24);
            this.imgCard1.Name = "imgCard1";
            this.imgCard1.Size = new System.Drawing.Size(170, 302);
            this.imgCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCard1.TabIndex = 0;
            this.imgCard1.TabStop = false;
            // 
            // imgCard2
            // 
            this.imgCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCard2.Image = global::tarot.Resource.back;
            this.imgCard2.Location = new System.Drawing.Point(292, 24);
            this.imgCard2.Name = "imgCard2";
            this.imgCard2.Size = new System.Drawing.Size(170, 302);
            this.imgCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCard2.TabIndex = 1;
            this.imgCard2.TabStop = false;
            // 
            // imgCard3
            // 
            this.imgCard3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCard3.Image = global::tarot.Resource.back;
            this.imgCard3.Location = new System.Drawing.Point(545, 24);
            this.imgCard3.Name = "imgCard3";
            this.imgCard3.Size = new System.Drawing.Size(170, 302);
            this.imgCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCard3.TabIndex = 2;
            this.imgCard3.TabStop = false;
            // 
            // listName1
            // 
            this.listName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listName1.FormattingEnabled = true;
            this.listName1.Items.AddRange(new object[] {
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
            this.listName1.Location = new System.Drawing.Point(5, 361);
            this.listName1.Name = "listName1";
            this.listName1.Size = new System.Drawing.Size(245, 21);
            this.listName1.TabIndex = 3;
            // 
            // listName2
            // 
            this.listName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listName2.FormattingEnabled = true;
            this.listName2.Items.AddRange(new object[] {
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
            this.listName2.Location = new System.Drawing.Point(259, 361);
            this.listName2.Name = "listName2";
            this.listName2.Size = new System.Drawing.Size(236, 21);
            this.listName2.TabIndex = 4;
            // 
            // listName3
            // 
            this.listName3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listName3.FormattingEnabled = true;
            this.listName3.Items.AddRange(new object[] {
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
            this.listName3.Location = new System.Drawing.Point(508, 361);
            this.listName3.Name = "listName3";
            this.listName3.Size = new System.Drawing.Size(245, 21);
            this.listName3.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(92, 398);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Reversed";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(341, 398);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Reversed";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(594, 398);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Reversed";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textDescription1
            // 
            this.textDescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDescription1.Location = new System.Drawing.Point(3, 423);
            this.textDescription1.Multiline = true;
            this.textDescription1.Name = "textDescription1";
            this.textDescription1.ReadOnly = true;
            this.textDescription1.Size = new System.Drawing.Size(250, 87);
            this.textDescription1.TabIndex = 9;
            // 
            // textDescription2
            // 
            this.textDescription2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDescription2.Location = new System.Drawing.Point(259, 423);
            this.textDescription2.Multiline = true;
            this.textDescription2.Name = "textDescription2";
            this.textDescription2.ReadOnly = true;
            this.textDescription2.Size = new System.Drawing.Size(236, 87);
            this.textDescription2.TabIndex = 10;
            // 
            // textDescription3
            // 
            this.textDescription3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDescription3.Location = new System.Drawing.Point(501, 423);
            this.textDescription3.Multiline = true;
            this.textDescription3.Name = "textDescription3";
            this.textDescription3.ReadOnly = true;
            this.textDescription3.Size = new System.Drawing.Size(259, 87);
            this.textDescription3.TabIndex = 11;
            // 
            // LookUpReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tarot.Resource.aibackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(979, 668);
            this.MinimumSize = new System.Drawing.Size(979, 668);
            this.Name = "LookUpReading";
            this.Text = "Look Up A Reading";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCard3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox imgCard3;
        private System.Windows.Forms.PictureBox imgCard2;
        private System.Windows.Forms.PictureBox imgCard1;
        private System.Windows.Forms.ComboBox listName1;
        private System.Windows.Forms.TextBox textDescription3;
        private System.Windows.Forms.TextBox textDescription2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox listName3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textDescription1;
        private System.Windows.Forms.ComboBox listName2;
    }
}