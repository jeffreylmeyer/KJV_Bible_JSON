/******************************************************************
 * Bible Search - Controller (BibleController.dll)
 * Created: 20-SEP-2018 by Jeffrey L Meyer
 * https://github.com/jeffreylmeyer
 * 
 * Copyright © 2018 Jeffrey L Meyer
 * 
 *****************************************************************
 */

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace BibleController
{
    public class _Controller
    {
        private string bookList; 
        private string bookPath; 
        public _Controller(string _JSONBiblePath)
        {
            if (!"".Equals(_JSONBiblePath)){
                bookList = _JSONBiblePath + "\\books.json";
                bookPath = _JSONBiblePath + "\\";
            }
        }
        
        public List<BibleBooks> books = new List<BibleBooks>();

        // Get list of Bible books from books.json
        public List<BibleBooks> GetBookList()
        {
            try
            {
                // books[] holds values until program exit and
                // can be accessed in main class by referencing instance of class
                // Example:
                // _Controller controller = new _Controller(_JSONBiblePath);
                // BibleBooks books = controller.GetBookList();

                string text = System.IO.File.ReadAllText(bookList);
                books = JsonConvert.DeserializeObject<List<BibleBooks>>(text);
                return books;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + 
                    "Check your JSONBible path setting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        
        // Get single verse from specified book, chapter
        public string GetVerse(string _name, int _chap, int _verse)
        {
            string tmp = "";
            List<BookText> texts = new List<BookText>();

            foreach(BibleBooks book in books)
            {
                if (book.bibleBook.BookName.Equals(_name))
                {
                    texts = GetChapters(bookPath + "\\" + book.bibleBook.BookFilePath);
                    break;
                }
            }
            foreach(BookText text in texts)
            {
                if(text.chapter == _chap && text.verse == _verse) {
                    tmp = text.text.Trim();
                    break;
                }
            }
            texts = null;
            return tmp;
        }
        
        // Get all text for spcified book
        public List<BookText> GetChapters(string book)
        {
            try
            {
                string text = System.IO.File.ReadAllText(book);
                List<BookText> texts = JsonConvert.DeserializeObject<List<BookText>>(text);
                return texts;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + Environment.NewLine + book);
            }
            return null;
        }
    
        // Get .json file path for book
        public string GetBookPath(string bookTitle)
        {
            foreach (BibleBooks book in books)
            {
                if (book.bibleBook.BookName.Equals(bookTitle))
                {
                    return "\\" + book.bibleBook.BookFilePath;
                }
            }
            return "[error]";
        }

        // Get display title
        public string GetBookTitle(string bookName)
        {
            foreach (BibleBooks book in books)
            {
                if (book.bibleBook.BookName.Equals(bookName))
                {
                    return book.bibleBook.DisplayTitle;
                }
            }
            return bookName;
        }

        // Search for text and return a list for ListBox control
        public List<string> FindTexts(string _searchText)
        {
            this.books = this.GetBookList();
            List<string> tList = new List<string>();
            if (books != null && books.Count > 0)
            {
                foreach (BibleBooks book in books)
                {
                    // load full book
                    string tbookPath = bookPath;
                    tbookPath += "\\" + this.GetBookPath(book.bibleBook.BookName);
                    List<BookText> texts = GetChapters(tbookPath);
                    foreach (BookText text in texts)
                    {
                        if (text.text.Contains(_searchText))
                        {
                            string txt;
                            if (text.text.Length > 60)
                            {
                                txt = text.text.Substring(0, 60);
                            }
                            else
                            {
                                txt = text.text;
                            }
                            tList.Add(book.bibleBook.BookName + ":" + text.chapter + ":" + text.verse + ":" + txt + "...");
                        }
                    }
                }
            }
            return tList;
        }
    }
}
