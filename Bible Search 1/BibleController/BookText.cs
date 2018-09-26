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
    // Am:1:1: The words of Amos, who was among the herdman of...

   public class BookText
    {
        public int chapter { get; set; }
        public int verse { get; set; }
        public string text { get; set; }

    }
}
