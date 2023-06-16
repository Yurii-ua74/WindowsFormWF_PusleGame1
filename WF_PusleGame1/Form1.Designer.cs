namespace WF_PusleGame1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.horiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.game_modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox5 = new System.Windows.Forms.ToolStripComboBox();
            this.fifteenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox6 = new System.Windows.Forms.ToolStripComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(545, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.game_modeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(645, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem,
            this.horiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.ToolTipText = "Вибір картинок";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.verticalToolStripMenuItem.Text = "HorizontalWayImage";
            this.verticalToolStripMenuItem.ToolTipText = "горизотально розсташовані картинки";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "puzle1h.png",
            "puzle2h.png",
            "puzle3h.png",
            "puzle4h.png"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox3.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox3_SelectedIndexChanged);
            this.toolStripComboBox3.Click += new System.EventHandler(this.toolStripComboBox3_Click);
            // 
            // horiToolStripMenuItem
            // 
            this.horiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox4});
            this.horiToolStripMenuItem.Name = "horiToolStripMenuItem";
            this.horiToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.horiToolStripMenuItem.Text = "VerticalWayImage";
            this.horiToolStripMenuItem.ToolTipText = "вертикально розсташовані картинки";
            // 
            // toolStripComboBox4
            // 
            this.toolStripComboBox4.Items.AddRange(new object[] {
            "MonaLisaV.png",
            "puzle1v.png",
            "puzle2v.png"});
            this.toolStripComboBox4.Name = "toolStripComboBox4";
            this.toolStripComboBox4.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox4.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox4_SelectedIndexChanged);
            this.toolStripComboBox4.Click += new System.EventHandler(this.toolStripComboBox4_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.AutoToolTip = true;
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.ToolTipText = "кількість клітин";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.ToolTipText = "кількість клітин";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open1ToolStripMenuItem});
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.rulesToolStripMenuItem.Text = "Rules of the game";
            // 
            // open1ToolStripMenuItem
            // 
            this.open1ToolStripMenuItem.Name = "open1ToolStripMenuItem";
            this.open1ToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.open1ToolStripMenuItem.Text = "open";
            this.open1ToolStripMenuItem.ToolTipText = "коротко про гру";
            this.open1ToolStripMenuItem.Click += new System.EventHandler(this.open1ToolStripMenuItem_Click);
            // 
            // game_modeToolStripMenuItem
            // 
            this.game_modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puzleToolStripMenuItem,
            this.fifteenToolStripMenuItem});
            this.game_modeToolStripMenuItem.Name = "game_modeToolStripMenuItem";
            this.game_modeToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.game_modeToolStripMenuItem.Text = "Game mode";
            // 
            // puzleToolStripMenuItem
            // 
            this.puzleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox5});
            this.puzleToolStripMenuItem.Name = "puzleToolStripMenuItem";
            this.puzleToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.puzleToolStripMenuItem.Text = "Puzle";
            this.puzleToolStripMenuItem.ToolTipText = "підставляйте будь-яку клітину замість порожнтої";
            // 
            // toolStripComboBox5
            // 
            this.toolStripComboBox5.Items.AddRange(new object[] {
            "true"});
            this.toolStripComboBox5.Name = "toolStripComboBox5";
            this.toolStripComboBox5.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox5.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox5_SelectedIndexChanged);
            // 
            // fifteenToolStripMenuItem
            // 
            this.fifteenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox6});
            this.fifteenToolStripMenuItem.Name = "fifteenToolStripMenuItem";
            this.fifteenToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.fifteenToolStripMenuItem.Text = "Fifteen";
            this.fifteenToolStripMenuItem.ToolTipText = "пересувати дозволено лише сусідні з порожньою клітиною";
            // 
            // toolStripComboBox6
            // 
            this.toolStripComboBox6.Items.AddRange(new object[] {
            "true"});
            this.toolStripComboBox6.Name = "toolStripComboBox6";
            this.toolStripComboBox6.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox6.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox6_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Harlow Solid Italic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(440, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Game Begin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(405, 386);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Harlow Solid Italic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(440, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Game Over";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.OwnerDraw = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 649);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Harlow Solid Italic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Game start window";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem horiToolStripMenuItem;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private ToolStripMenuItem open1ToolStripMenuItem;
        private ToolStripMenuItem game_modeToolStripMenuItem;
        private ToolStripMenuItem puzleToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox3;
        private ToolStripComboBox toolStripComboBox4;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private ToolStripComboBox toolStripComboBox5;
        private ToolStripMenuItem fifteenToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox6;
        private ToolTip toolTip1;
        private ToolStripComboBox toolStripComboBox1;
    }
}