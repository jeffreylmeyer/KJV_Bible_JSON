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
    public partial class ConfigDLG : Form
    {
        public ConfigDLG()
        {
            InitializeComponent();
        }

        private void JSONBrowseBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgJ = new FolderBrowserDialog();
            //dlgJ.RootFolder = Environment.SpecialFolder.LocalApplicationData;
            dlgJ.SelectedPath = "JSONBible";
            if(dlgJ.ShowDialog() == DialogResult.OK)
            {
                JSONPathTB.Text = dlgJ.SelectedPath;
                Properties.Settings.Default.JSONBiblePath = JSONPathTB.Text.Trim('\\') + "\\";
                Properties.Settings.Default.Save();
            }

        }

        private void ConfigDLG_Load(object sender, EventArgs e)
        {
            if (!"".Equals(Properties.Settings.Default.JSONBiblePath))
            {
                JSONPathTB.Text = Properties.Settings.Default.JSONBiblePath;
            }
        }

        private void DoneBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
