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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleController
{
    public class BibleBooks
    {
        public book bibleBook { get; set; }
        public class book
        {
            public int BookID { get; set; }
            public string DisplayTitle { get; set; }
            public string BookName { get; set; }
            public string BookFilePath { get; set; }
        }
    }
}
