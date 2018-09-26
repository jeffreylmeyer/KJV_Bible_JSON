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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bible_Search_1
{
    public partial class StatusWin : Form
    {
        private string labelText = "Searching";
        private int value = 0;
        private int range = 10000;

        public void setLabel(string _label)
        {
            labelText = _label;
        }
        public void setVal(int _val)
        {
            value = _val;
        }
        public void setRange(int _range)
        {
            range = _range;
        }
        public StatusWin()
        {
            InitializeComponent();
        }

        private void StatusWin_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            if (value > 10000)
            {
                value = 10000;
            }
            pBar.Value = value;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            timer1.Enabled = false;
            base.OnClosing(e);
        }
    }
}
