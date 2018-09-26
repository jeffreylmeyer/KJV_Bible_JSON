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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bible_Search_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWin());
        }
    }
}
