
namespace tarot
{
    partial class Tarot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarot));
            this.btnNewFortune = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPast = new System.Windows.Forms.Label();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblFuture = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtBoxCard3 = new System.Windows.Forms.RichTextBox();
            this.txtBoxCard1 = new System.Windows.Forms.RichTextBox();
            this.txtBoxCard2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLibraray = new System.Windows.Forms.ToolStripMenuItem();
            this.physicalReadingMenus = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCard1 = new System.Windows.Forms.Label();
            this.lblCard2 = new System.Windows.Forms.Label();
            this.lblCard3 = new System.Windows.Forms.Label();
            this.lblReversed1 = new System.Windows.Forms.Label();
            this.lblReversed2 = new System.Windows.Forms.Label();
            this.lblReversed3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.lblCardDescription3 = new System.Windows.Forms.Label();
            this.lblCardDescription2 = new System.Windows.Forms.Label();
            this.lblCardDescription1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewFortune
            // 
            this.btnNewFortune.BackColor = System.Drawing.Color.Coral;
            this.btnNewFortune.FlatAppearance.BorderSize = 0;
            this.btnNewFortune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFortune.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic);
            this.btnNewFortune.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNewFortune.Location = new System.Drawing.Point(318, 1423);
            this.btnNewFortune.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewFortune.Name = "btnNewFortune";
            this.btnNewFortune.Size = new System.Drawing.Size(389, 112);
            this.btnNewFortune.TabIndex = 0;
            this.btnNewFortune.Text = "New Fortune";
            this.btnNewFortune.UseVisualStyleBackColor = false;
            this.btnNewFortune.Click += new System.EventHandler(this.btnNewFortune_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Plum;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 206);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 643);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblPast
            // 
            this.lblPast.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPast.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic);
            this.lblPast.ForeColor = System.Drawing.Color.Coral;
            this.lblPast.Location = new System.Drawing.Point(190, 126);
            this.lblPast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPast.Name = "lblPast";
            this.lblPast.Padding = new System.Windows.Forms.Padding(6);
            this.lblPast.Size = new System.Drawing.Size(651, 78);
            this.lblPast.TabIndex = 5;
            this.lblPast.Text = "Past";
            this.lblPast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPresent
            // 
            this.lblPresent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPresent.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic);
            this.lblPresent.ForeColor = System.Drawing.Color.Coral;
            this.lblPresent.Location = new System.Drawing.Point(913, 126);
            this.lblPresent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Padding = new System.Windows.Forms.Padding(6);
            this.lblPresent.Size = new System.Drawing.Size(656, 72);
            this.lblPresent.TabIndex = 6;
            this.lblPresent.Text = "Present";
            this.lblPresent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuture
            // 
            this.lblFuture.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblFuture.Font = new System.Drawing.Font("Harlow Solid Italic", 16F, System.Drawing.FontStyle.Italic);
            this.lblFuture.ForeColor = System.Drawing.Color.Coral;
            this.lblFuture.Location = new System.Drawing.Point(1650, 126);
            this.lblFuture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuture.Name = "lblFuture";
            this.lblFuture.Padding = new System.Windows.Forms.Padding(6);
            this.lblFuture.Size = new System.Drawing.Size(637, 78);
            this.lblFuture.TabIndex = 7;
            this.lblFuture.Text = "Future";
            this.lblFuture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Plum;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(1054, 217);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 643);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Plum;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1780, 217);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(389, 643);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // txtBoxCard3
            // 
            this.txtBoxCard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxCard3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtBoxCard3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCard3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxCard3.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCard3.ForeColor = System.Drawing.Color.Coral;
            this.txtBoxCard3.Location = new System.Drawing.Point(1156, 1753);
            this.txtBoxCard3.Margin = new System.Windows.Forms.Padding(8);
            this.txtBoxCard3.Name = "txtBoxCard3";
            this.txtBoxCard3.ReadOnly = true;
            this.txtBoxCard3.Size = new System.Drawing.Size(418, 220);
            this.txtBoxCard3.TabIndex = 12;
            this.txtBoxCard3.Text = "";
            // 
            // txtBoxCard1
            // 
            this.txtBoxCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxCard1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtBoxCard1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxCard1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCard1.ForeColor = System.Drawing.Color.Coral;
            this.txtBoxCard1.Location = new System.Drawing.Point(156, 1753);
            this.txtBoxCard1.Margin = new System.Windows.Forms.Padding(8);
            this.txtBoxCard1.Name = "txtBoxCard1";
            this.txtBoxCard1.ReadOnly = true;
            this.txtBoxCard1.Size = new System.Drawing.Size(418, 220);
            this.txtBoxCard1.TabIndex = 10;
            this.txtBoxCard1.Text = "";
            // 
            // txtBoxCard2
            // 
            this.txtBoxCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxCard2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtBoxCard2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCard2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxCard2.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCard2.ForeColor = System.Drawing.Color.Coral;
            this.txtBoxCard2.Location = new System.Drawing.Point(660, 1753);
            this.txtBoxCard2.Margin = new System.Windows.Forms.Padding(8);
            this.txtBoxCard2.Name = "txtBoxCard2";
            this.txtBoxCard2.ReadOnly = true;
            this.txtBoxCard2.Size = new System.Drawing.Size(418, 220);
            this.txtBoxCard2.TabIndex = 11;
            this.txtBoxCard2.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2495, 40);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 38);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLibraray,
            this.physicalReadingMenus});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(90, 38);
            this.aboutToolStripMenuItem.Text = "Tools";
            // 
            // menuLibraray
            // 
            this.menuLibraray.Name = "menuLibraray";
            this.menuLibraray.Size = new System.Drawing.Size(326, 44);
            this.menuLibraray.Text = "Library";
            this.menuLibraray.Click += new System.EventHandler(this.menuLibrary_Click);
            // 
            // physicalReadingMenus
            // 
            this.physicalReadingMenus.Name = "physicalReadingMenus";
            this.physicalReadingMenus.Size = new System.Drawing.Size(326, 44);
            this.physicalReadingMenus.Text = "Physical Reading";
            this.physicalReadingMenus.Click += new System.EventHandler(this.physicalReadingMenus_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(199, 44);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // lblCard1
            // 
            this.lblCard1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCard1.Font = new System.Drawing.Font("Ink Free", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard1.ForeColor = System.Drawing.Color.Coral;
            this.lblCard1.Location = new System.Drawing.Point(191, 883);
            this.lblCard1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCard1.Name = "lblCard1";
            this.lblCard1.Padding = new System.Windows.Forms.Padding(6);
            this.lblCard1.Size = new System.Drawing.Size(651, 68);
            this.lblCard1.TabIndex = 17;
            this.lblCard1.Text = "Card 1 Name";
            this.lblCard1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCard1.Visible = false;
            // 
            // lblCard2
            // 
            this.lblCard2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCard2.Font = new System.Drawing.Font("Ink Free", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard2.ForeColor = System.Drawing.Color.Coral;
            this.lblCard2.Location = new System.Drawing.Point(913, 883);
            this.lblCard2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCard2.Name = "lblCard2";
            this.lblCard2.Padding = new System.Windows.Forms.Padding(6);
            this.lblCard2.Size = new System.Drawing.Size(656, 68);
            this.lblCard2.TabIndex = 18;
            this.lblCard2.Text = "Card 2 Name";
            this.lblCard2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCard2.Visible = false;
            // 
            // lblCard3
            // 
            this.lblCard3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCard3.Font = new System.Drawing.Font("Ink Free", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard3.ForeColor = System.Drawing.Color.Coral;
            this.lblCard3.Location = new System.Drawing.Point(1650, 883);
            this.lblCard3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCard3.Name = "lblCard3";
            this.lblCard3.Padding = new System.Windows.Forms.Padding(6);
            this.lblCard3.Size = new System.Drawing.Size(637, 68);
            this.lblCard3.TabIndex = 19;
            this.lblCard3.Text = "Card 3 Name";
            this.lblCard3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCard3.Visible = false;
            // 
            // lblReversed1
            // 
            this.lblReversed1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblReversed1.Font = new System.Drawing.Font("Harlow Solid Italic", 14F, System.Drawing.FontStyle.Italic);
            this.lblReversed1.ForeColor = System.Drawing.Color.Gold;
            this.lblReversed1.Location = new System.Drawing.Point(190, 951);
            this.lblReversed1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReversed1.Name = "lblReversed1";
            this.lblReversed1.Padding = new System.Windows.Forms.Padding(6);
            this.lblReversed1.Size = new System.Drawing.Size(651, 72);
            this.lblReversed1.TabIndex = 20;
            this.lblReversed1.Text = "Reversed";
            this.lblReversed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReversed1.Visible = false;
            // 
            // lblReversed2
            // 
            this.lblReversed2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblReversed2.Font = new System.Drawing.Font("Harlow Solid Italic", 14F, System.Drawing.FontStyle.Italic);
            this.lblReversed2.ForeColor = System.Drawing.Color.Gold;
            this.lblReversed2.Location = new System.Drawing.Point(909, 951);
            this.lblReversed2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReversed2.Name = "lblReversed2";
            this.lblReversed2.Padding = new System.Windows.Forms.Padding(6);
            this.lblReversed2.Size = new System.Drawing.Size(660, 72);
            this.lblReversed2.TabIndex = 21;
            this.lblReversed2.Text = "Reversed";
            this.lblReversed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReversed2.Visible = false;
            // 
            // lblReversed3
            // 
            this.lblReversed3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblReversed3.Font = new System.Drawing.Font("Harlow Solid Italic", 14F, System.Drawing.FontStyle.Italic);
            this.lblReversed3.ForeColor = System.Drawing.Color.Gold;
            this.lblReversed3.Location = new System.Drawing.Point(1650, 951);
            this.lblReversed3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReversed3.Name = "lblReversed3";
            this.lblReversed3.Padding = new System.Windows.Forms.Padding(6);
            this.lblReversed3.Size = new System.Drawing.Size(637, 72);
            this.lblReversed3.TabIndex = 22;
            this.lblReversed3.Text = "Reversed";
            this.lblReversed3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReversed3.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(913, 126);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(656, 1207);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox2.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.richTextBox2.HideSelection = false;
            this.richTextBox2.Location = new System.Drawing.Point(1650, 126);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(8);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(637, 1201);
            this.richTextBox2.TabIndex = 24;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox3.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.richTextBox3.HideSelection = false;
            this.richTextBox3.Location = new System.Drawing.Point(190, 126);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(8);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(651, 1207);
            this.richTextBox3.TabIndex = 25;
            this.richTextBox3.Text = "";
            // 
            // lblCardDescription3
            // 
            this.lblCardDescription3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCardDescription3.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardDescription3.ForeColor = System.Drawing.Color.Coral;
            this.lblCardDescription3.Location = new System.Drawing.Point(1650, 1023);
            this.lblCardDescription3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardDescription3.Name = "lblCardDescription3";
            this.lblCardDescription3.Padding = new System.Windows.Forms.Padding(6);
            this.lblCardDescription3.Size = new System.Drawing.Size(640, 304);
            this.lblCardDescription3.TabIndex = 28;
            this.lblCardDescription3.Text = "Card 3 Description";
            this.lblCardDescription3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCardDescription3.Visible = false;
            // 
            // lblCardDescription2
            // 
            this.lblCardDescription2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCardDescription2.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardDescription2.ForeColor = System.Drawing.Color.Coral;
            this.lblCardDescription2.Location = new System.Drawing.Point(913, 1023);
            this.lblCardDescription2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardDescription2.Name = "lblCardDescription2";
            this.lblCardDescription2.Padding = new System.Windows.Forms.Padding(6);
            this.lblCardDescription2.Size = new System.Drawing.Size(656, 310);
            this.lblCardDescription2.TabIndex = 27;
            this.lblCardDescription2.Text = "Card 2 Description";
            this.lblCardDescription2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCardDescription2.Visible = false;
            // 
            // lblCardDescription1
            // 
            this.lblCardDescription1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCardDescription1.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardDescription1.ForeColor = System.Drawing.Color.Coral;
            this.lblCardDescription1.Location = new System.Drawing.Point(190, 1023);
            this.lblCardDescription1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardDescription1.Name = "lblCardDescription1";
            this.lblCardDescription1.Padding = new System.Windows.Forms.Padding(6);
            this.lblCardDescription1.Size = new System.Drawing.Size(651, 310);
            this.lblCardDescription1.TabIndex = 26;
            this.lblCardDescription1.Text = "Card 1 Description";
            this.lblCardDescription1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCardDescription1.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Coral;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic);
            this.btnSave.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSave.Location = new System.Drawing.Point(1054, 1423);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(389, 112);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Coral;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic);
            this.btnExit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExit.Location = new System.Drawing.Point(1780, 1423);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(389, 112);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(359, 44);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // Tarot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImage = global::tarot.Resource.aibackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(2495, 1579);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCardDescription3);
            this.Controls.Add(this.lblCardDescription2);
            this.Controls.Add(this.lblCardDescription1);
            this.Controls.Add(this.lblCard3);
            this.Controls.Add(this.lblCard2);
            this.Controls.Add(this.lblCard1);
            this.Controls.Add(this.lblReversed3);
            this.Controls.Add(this.lblReversed2);
            this.Controls.Add(this.lblReversed1);
            this.Controls.Add(this.txtBoxCard3);
            this.Controls.Add(this.txtBoxCard2);
            this.Controls.Add(this.txtBoxCard1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblFuture);
            this.Controls.Add(this.lblPresent);
            this.Controls.Add(this.lblPast);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewFortune);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2521, 1650);
            this.MinimumSize = new System.Drawing.Size(2521, 1650);
            this.Name = "Tarot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tarot Reader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tarot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewFortune;
        private System.Windows.Forms.Label lblPast;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblFuture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox txtBoxCard3;
        private System.Windows.Forms.RichTextBox txtBoxCard1;
        private System.Windows.Forms.RichTextBox txtBoxCard2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLibraray;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Label lblCard1;
        private System.Windows.Forms.Label lblCard2;
        private System.Windows.Forms.Label lblCard3;
        private System.Windows.Forms.Label lblReversed1;
        private System.Windows.Forms.Label lblReversed2;
        private System.Windows.Forms.Label lblReversed3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label lblCardDescription3;
        private System.Windows.Forms.Label lblCardDescription2;
        private System.Windows.Forms.Label lblCardDescription1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem physicalReadingMenus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
    }
}

