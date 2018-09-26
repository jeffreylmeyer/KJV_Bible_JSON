namespace Bible_Search_1
{
    partial class MainWin
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configMNU = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMNU = new System.Windows.Forms.ToolStripMenuItem();
            this.bookComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultList = new System.Windows.Forms.ListBox();
            this.selectViewGroup = new System.Windows.Forms.GroupBox();
            this.chapterRB = new System.Windows.Forms.RadioButton();
            this.verseRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullSearchBTN = new System.Windows.Forms.Button();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.rtb1ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.slabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.selectViewGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.rtb1ContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.AboutMNU,
            this.bookComboBox});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(830, 27);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 23);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.configMNU});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fontToolStripMenuItem.Text = "&Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // configMNU
            // 
            this.configMNU.Name = "configMNU";
            this.configMNU.Size = new System.Drawing.Size(157, 22);
            this.configMNU.Text = "&Configuration...";
            this.configMNU.Click += new System.EventHandler(this.configMNU_Click);
            // 
            // AboutMNU
            // 
            this.AboutMNU.Name = "AboutMNU";
            this.AboutMNU.Size = new System.Drawing.Size(52, 23);
            this.AboutMNU.Text = "&About";
            this.AboutMNU.Click += new System.EventHandler(this.AboutMNU_Click);
            // 
            // bookComboBox
            // 
            this.bookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(121, 23);
            this.bookComboBox.SelectedIndexChanged += new System.EventHandler(this.bookComboBox_SelectedIndexChanged);
            
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RTB1);
            this.splitContainer1.Size = new System.Drawing.Size(830, 440);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.selectViewGroup);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result List";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 286);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // resultList
            // 
            this.resultList.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultList.FormattingEnabled = true;
            this.resultList.Location = new System.Drawing.Point(3, 16);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(192, 186);
            this.resultList.TabIndex = 0;
            this.resultList.SelectedIndexChanged += new System.EventHandler(this.resultList_SelectedIndexChanged);
            // 
            // selectViewGroup
            // 
            this.selectViewGroup.Controls.Add(this.chapterRB);
            this.selectViewGroup.Controls.Add(this.verseRB);
            this.selectViewGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectViewGroup.Location = new System.Drawing.Point(3, 16);
            this.selectViewGroup.Name = "selectViewGroup";
            this.selectViewGroup.Size = new System.Drawing.Size(198, 47);
            this.selectViewGroup.TabIndex = 1;
            this.selectViewGroup.TabStop = false;
            this.selectViewGroup.Text = "Select View";
            // 
            // chapterRB
            // 
            this.chapterRB.AutoSize = true;
            this.chapterRB.Location = new System.Drawing.Point(100, 20);
            this.chapterRB.Name = "chapterRB";
            this.chapterRB.Size = new System.Drawing.Size(69, 17);
            this.chapterRB.TabIndex = 1;
            this.chapterRB.Text = "Full Book";
            this.chapterRB.UseVisualStyleBackColor = true;
            this.chapterRB.CheckedChanged += new System.EventHandler(this.chapterRB_CheckedChanged);
            // 
            // verseRB
            // 
            this.verseRB.AutoSize = true;
            this.verseRB.Checked = true;
            this.verseRB.Location = new System.Drawing.Point(17, 20);
            this.verseRB.Name = "verseRB";
            this.verseRB.Size = new System.Drawing.Size(76, 17);
            this.verseRB.TabIndex = 0;
            this.verseRB.TabStop = true;
            this.verseRB.Text = "Verse Only";
            this.verseRB.UseVisualStyleBackColor = true;
            this.verseRB.CheckedChanged += new System.EventHandler(this.verseRB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullSearchBTN);
            this.groupBox1.Controls.Add(this.searchBTN);
            this.groupBox1.Controls.Add(this.searchText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // fullSearchBTN
            // 
            this.fullSearchBTN.Location = new System.Drawing.Point(44, 72);
            this.fullSearchBTN.Name = "fullSearchBTN";
            this.fullSearchBTN.Size = new System.Drawing.Size(129, 23);
            this.fullSearchBTN.TabIndex = 2;
            this.fullSearchBTN.Text = "Search Entire Bible";
            this.fullSearchBTN.UseVisualStyleBackColor = true;
            this.fullSearchBTN.Click += new System.EventHandler(this.fullSearchBTN_Click);
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(44, 43);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(129, 23);
            this.searchBTN.TabIndex = 1;
            this.searchBTN.Text = "&Search Current Book";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchText
            // 
            this.searchText.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchText.Location = new System.Drawing.Point(3, 16);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(198, 20);
            this.searchText.TabIndex = 0;
            // 
            // RTB1
            // 
            this.RTB1.ContextMenuStrip = this.rtb1ContextMenu;
            this.RTB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB1.Location = new System.Drawing.Point(0, 0);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(614, 436);
            this.RTB1.TabIndex = 0;
            this.RTB1.Text = "";
            // 
            // rtb1ContextMenu
            // 
            this.rtb1ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.rtb1ContextMenu.Name = "rtb1ContextMenu";
            this.rtb1ContextMenu.Size = new System.Drawing.Size(145, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // slabel1
            // 
            this.slabel1.Name = "slabel1";
            this.slabel1.Size = new System.Drawing.Size(39, 17);
            this.slabel1.Text = "Ready";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 492);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWin";
            this.Text = "Bible Search";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.selectViewGroup.ResumeLayout(false);
            this.selectViewGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rtb1ContextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox bookComboBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button fullSearchBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox selectViewGroup;
        private System.Windows.Forms.RadioButton chapterRB;
        private System.Windows.Forms.RadioButton verseRB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox resultList;
        private System.Windows.Forms.ToolStripStatusLabel slabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip rtb1ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configMNU;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem AboutMNU;
    }
}

