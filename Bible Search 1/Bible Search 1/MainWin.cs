/******************************************************************
 * Bible Search 
 * Created: 20-SEP-2018 by Jeffrey L Meyer
 * https://github.com/jeffreylmeyer
 * 
 * Copyright © 2018 Jeffrey L Meyer
 * 
 *****************************************************************
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BibleController;


namespace Bible_Search_1
{
    public partial class MainWin : Form
    {
        private int mainWinMinHeight = 300;
        private int mainWinMinWidth = 500;
        private string selectedItem = "";
        private string currentBook = "";
        private bool isHighlighted = false;
        private string JSONBIBLEPATH = "";

        _Controller controller;
        private List<BookText> texts = new List<BookText>();
        private string bookTitle;
       
        public MainWin()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            JSONBIBLEPATH = "C:\\BibleFiles\\JSONBible\\";
            if (Properties.Settings.Default.firstRun)
            {
                try
                {
                    FolderBrowserDialog fd = new FolderBrowserDialog();
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        fd.SelectedPath = JSONBIBLEPATH;
                        fd.Description = "Select the \\BibleFiles\\JSONBible folder where you unzipped the JSON Bible files.";
                        JSONBIBLEPATH = fd.SelectedPath + "\\";
                    }
                    Properties.Settings.Default.firstRun = false;
                    Properties.Settings.Default.JSONBiblePath = JSONBIBLEPATH;
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            if (!"".Equals(Properties.Settings.Default.JSONBiblePath))
            {
                controller = new _Controller(Properties.Settings.Default.JSONBiblePath);
            }
            else
            {
                SetJSONPath();
                controller = new _Controller(JSONBIBLEPATH);
                Properties.Settings.Default.JSONBiblePath = JSONBIBLEPATH;
                Properties.Settings.Default.Save();
            }

            LoadBooks();

            if (Properties.Settings.Default.font != null)
            {
                RTB1.Font = Properties.Settings.Default.font;
            }
           
            if(this.Height < mainWinMinHeight)
            {
                this.Height = mainWinMinHeight;
            }
            if(this.Width < mainWinMinWidth)
            {
                this.Width = mainWinMinWidth;
            }
            
        }

        private void LoadBooks()
        {
            try
            {
                List<BibleBooks> books = controller.GetBookList();
                if (books.Count > 0)
                {
                    foreach (BibleBooks book in books)
                    {
                        bookComboBox.Items.Add(book.bibleBook.BookName);
                    }
                    bookComboBox.Text = "<Select a book>";
                    resultList.Top = selectViewGroup.Bottom + 10;
                    resultList.Height = groupBox3.Height - 30;
                    groupBox3.Height = splitContainer1.Height - 170;
                    groupBox3.Update();
                }else
                {
                    SetJSONPath();
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Check JSONBible Path",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetJSONPath();
            }
        }

        private void SetJSONPath()
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.SelectedPath = JSONBIBLEPATH;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                JSONBIBLEPATH = fd.SelectedPath + "\\";
                Properties.Settings.Default.JSONBiblePath = JSONBIBLEPATH;
                Properties.Settings.Default.Save();
                controller = new _Controller(JSONBIBLEPATH);
                LoadBooks();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            resultList.Height = groupBox3.Height - 30;
            groupBox3.Height = splitContainer1.Height - 170;
            if (this.Height < mainWinMinHeight)
            {
                this.Height = mainWinMinHeight;
            }
            if (this.Width < mainWinMinWidth)
            {
                this.Width = mainWinMinWidth;
            }
            splitContainer1.Height = this.Height - 90;
            base.OnResize(e);
            groupBox3.Update();

        }
        // Load chapters for selected book
     
        private void bookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                int idx = bookComboBox.SelectedIndex;
                string bookName = bookComboBox.SelectedItem.ToString();
                string bookPath = Properties.Settings.Default.JSONBiblePath; 
                bookPath += controller.GetBookPath(bookName);
                bookTitle = bookName;
                LoadChapters(bookPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // load and format chapter text
        private void LoadChapters(string bookPath)
        {
            RTB1.Clear();
            if (Properties.Settings.Default.font != null)
            {
                RTB1.Font = Properties.Settings.Default.font;
              
            }
            int chapter;
            int oldchapter=0;
            try
            {
                // load chapters from {book}.json file
                texts = controller.GetChapters(bookPath);
                RTB1.SelectionFont = new Font(RTB1.Font.FontFamily, 14, FontStyle.Bold);
                RTB1.AppendText("Book: " + controller.GetBookTitle(bookTitle) + Environment.NewLine + Environment.NewLine);

                foreach (BookText text in texts)
                {
                    chapter = text.chapter;
                    if(chapter > oldchapter)
                    {
                        RTB1.SelectionFont = new Font(RTB1.Font.FontFamily, 14, FontStyle.Bold);
                        RTB1.AppendText("Chapter: " + text.chapter.ToString() + Environment.NewLine);
                        RTB1.AppendText("______________________________________" + Environment.NewLine);                        
                    }

                    RTB1.SelectionFont = new Font(RTB1.Font.FontFamily, RTB1.Font.Size, FontStyle.Bold);
                    RTB1.AppendText(text.chapter.ToString() + ":" + text.verse.ToString());
                    RTB1.SelectionFont = new Font(RTB1.Font.FontFamily, RTB1.Font.Size, FontStyle.Regular);
                    RTB1.AppendText("\t" + text.text + Environment.NewLine + Environment.NewLine);
                    oldchapter = text.chapter;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(bookPath + Environment.NewLine + ex.Message,bookTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // change RichTextBox font
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = RTB1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // set new font
                RTB1.Font = fontDialog1.Font;
                Properties.Settings.Default.font = RTB1.Font;
                Properties.Settings.Default.Save();
                bookComboBox.PerformClick();
                RTB1.Update();
                itemChanged();
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            RTB1.SelectAll();
            RTB1.SelectionBackColor = Color.White;
            RTB1.DeselectAll();
            RTB1.Update();
            string srcText = searchText.Text.Trim();
            if (!"".Equals(srcText)){
                HighlightWords(srcText);
            }
        }

        private void HighlightWords(string words)
        {
            StatusWin swin = new StatusWin();
            swin.setLabel("Locating");
            swin.Show();
            swin.setVal(0);
            Application.DoEvents();

            RTB1.SelectionStart = 0;
            RTB1.SelectionLength = 0;
            RTB1.ScrollToCaret();

            int startSearch = 0;
       //     bool first = true;
            int index = -1;
            int incr = 0;
            int matches = 0;
            // Search text in RichTextBox and highlight them with color. 
                while ((index = RTB1.Find(words, startSearch, RichTextBoxFinds.None)) > -1)
                {
                matches++;
                slabel1.Text = "Matches = " + matches.ToString();
                        
                    RTB1.SelectionBackColor = Color.GreenYellow;

                    // Continue after the one we searched 
                    startSearch = index + 1;
                incr += 1;
                    swin.setVal(incr);

                    Application.DoEvents();
            }
            swin.Close();
        }

        private void fullSearchBTN_Click(object sender, EventArgs e)
        {
            // search all books and make list of books/chapters found
            string srcText = searchText.Text.Trim();
            if (!"".Equals(srcText))
            {
                List<string> fList = controller.FindTexts(srcText);
                if(fList.Count > 0)
                {
                    resultList.DataSource = fList;
                }

            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // make sure stays at minimum width for panel1
            if(e.SplitX < 220)
            {
                splitContainer1.SplitterDistance = 220;
            }
        }

        private void resultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = resultList.SelectedItem.ToString();
            currentBook = "";
            isHighlighted = false;
            itemChanged();
        }

        private void itemChanged()
        {
            if (selectedItem == null || selectedItem.Equals("")){ return; }

            string bookName;
            int chapter;
            int verse;
            string[] sArr = selectedItem.Split(':');
            bookName = sArr[0];
            chapter = int.Parse(sArr[1]);
            verse = int.Parse(sArr[2]);
            

            string bookPath = Properties.Settings.Default.JSONBiblePath;
            bookPath += controller.GetBookPath(bookName);
            bookTitle = bookName;

            RTB1.Text = bookPath;

            if (verseRB.Checked)
            {
                // load verse
                LoadVerse(bookName, chapter, verse);
            }
            else
            {
                // load book
                LoadChapters(bookPath);
                
            }
            //!currentBook.Equals(bookName) &&
            if ( !isHighlighted)
            {
                HighlightWords(searchText.Text.Trim());
                currentBook = bookName;
                isHighlighted = true;
            }
            if (chapterRB.Checked)
            {
                string srchT = chapter.ToString() + ":" + verse.ToString();
                int idx = RTB1.Find(srchT,0,RTB1.Text.Length,RichTextBoxFinds.WholeWord);
                RTB1.ScrollToCaret();
                
            }
        }

        private void LoadVerse(string _name, int _chap, int _verse)
        {
            // load specific verse
            RTB1.Clear();
            RTB1.SelectionFont = new Font(RTB1.Font.FontFamily, 14, FontStyle.Bold);
            RTB1.AppendText("Name: " + _name + Environment.NewLine + "Chapter: " + _chap.ToString() + Environment.NewLine);
            RTB1.AppendText("______________________________________" + Environment.NewLine);
        
            RTB1.SelectionFont = new Font(RTB1.Font.FontFamily, RTB1.Font.Size, FontStyle.Bold);
            RTB1.SelectionFont = new Font(RTB1.Font.FontFamily, RTB1.Font.Size, FontStyle.Regular);
            RTB1.AppendText("Verse " + _verse.ToString() + " : " + controller.GetVerse(_name, _chap, _verse));
        }

        private void verseRB_CheckedChanged(object sender, EventArgs e)
        {
            isHighlighted = false;
            itemChanged();
     
        }

        private void chapterRB_CheckedChanged(object sender, EventArgs e)
        {
            isHighlighted = false;
            itemChanged();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RTB1.SelectedText,TextDataFormat.Text);
        }

        private void configMNU_Click(object sender, EventArgs e)
        {
            // load configuration dialog
            ConfigDLG cfg = new ConfigDLG();
            cfg.ShowDialog();
        }

        private void AboutMNU_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
