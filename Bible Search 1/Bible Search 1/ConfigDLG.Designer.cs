namespace Bible_Search_1
{
    partial class ConfigDLG
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JSONBrowseBTN = new System.Windows.Forms.Button();
            this.JSONPathTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoneBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JSONBrowseBTN);
            this.groupBox1.Controls.Add(this.JSONPathTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program Settings";
            // 
            // JSONBrowseBTN
            // 
            this.JSONBrowseBTN.Location = new System.Drawing.Point(371, 48);
            this.JSONBrowseBTN.Name = "JSONBrowseBTN";
            this.JSONBrowseBTN.Size = new System.Drawing.Size(75, 20);
            this.JSONBrowseBTN.TabIndex = 2;
            this.JSONBrowseBTN.Text = "Browse";
            this.JSONBrowseBTN.UseVisualStyleBackColor = true;
            this.JSONBrowseBTN.Click += new System.EventHandler(this.JSONBrowseBTN_Click);
            // 
            // JSONPathTB
            // 
            this.JSONPathTB.Location = new System.Drawing.Point(10, 48);
            this.JSONPathTB.Name = "JSONPathTB";
            this.JSONPathTB.Size = new System.Drawing.Size(355, 20);
            this.JSONPathTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "JSON Bible Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DoneBTN
            // 
            this.DoneBTN.Location = new System.Drawing.Point(202, 115);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(75, 23);
            this.DoneBTN.TabIndex = 1;
            this.DoneBTN.Text = "&Done";
            this.DoneBTN.UseVisualStyleBackColor = true;
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // ConfigDLG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 151);
            this.Controls.Add(this.DoneBTN);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigDLG";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.ConfigDLG_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button JSONBrowseBTN;
        private System.Windows.Forms.TextBox JSONPathTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DoneBTN;
    }
}