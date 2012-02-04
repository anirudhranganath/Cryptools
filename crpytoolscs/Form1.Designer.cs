namespace crpytoolscs
{
    partial class Form1
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
            this.BNSHOWMD5 = new System.Windows.Forms.Button();
            this.EDITdispmd5 = new System.Windows.Forms.TextBox();
            this.EDITTEXT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EDITDISPfilemd5 = new System.Windows.Forms.TextBox();
            this.BNBROWSEmd5 = new System.Windows.Forms.Button();
            this.EDITfilemd5 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboencoptions = new System.Windows.Forms.ComboBox();
            this.BNfecn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EDITepassconf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EDITepass = new System.Windows.Forms.TextBox();
            this.BNENCRYPT = new System.Windows.Forms.Button();
            this.EDITencfile = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BNdecrypt = new System.Windows.Forms.Button();
            this.combodecoptions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EDITDecpass = new System.Windows.Forms.TextBox();
            this.BNbrowseDecfile = new System.Windows.Forms.Button();
            this.EDITdecfile = new System.Windows.Forms.TextBox();
            this.BNabout = new System.Windows.Forms.Button();
            this.BNHELP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BNSHOWMD5);
            this.groupBox1.Controls.Add(this.EDITdispmd5);
            this.groupBox1.Controls.Add(this.EDITTEXT);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "md5 text";
            // 
            // BNSHOWMD5
            // 
            this.BNSHOWMD5.Location = new System.Drawing.Point(208, 21);
            this.BNSHOWMD5.Name = "BNSHOWMD5";
            this.BNSHOWMD5.Size = new System.Drawing.Size(79, 19);
            this.BNSHOWMD5.TabIndex = 2;
            this.BNSHOWMD5.Text = "Calculate MD5";
            this.BNSHOWMD5.UseVisualStyleBackColor = true;
            this.BNSHOWMD5.Click += new System.EventHandler(this.BNSHOWMD5_Click);
            // 
            // EDITdispmd5
            // 
            this.EDITdispmd5.Location = new System.Drawing.Point(6, 57);
            this.EDITdispmd5.Name = "EDITdispmd5";
            this.EDITdispmd5.ReadOnly = true;
            this.EDITdispmd5.Size = new System.Drawing.Size(281, 20);
            this.EDITdispmd5.TabIndex = 3;
            // 
            // EDITTEXT
            // 
            this.EDITTEXT.Location = new System.Drawing.Point(6, 20);
            this.EDITTEXT.Name = "EDITTEXT";
            this.EDITTEXT.Size = new System.Drawing.Size(196, 20);
            this.EDITTEXT.TabIndex = 0;
            this.EDITTEXT.TextChanged += new System.EventHandler(this.EDITTEXT_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EDITDISPfilemd5);
            this.groupBox2.Controls.Add(this.BNBROWSEmd5);
            this.groupBox2.Controls.Add(this.EDITfilemd5);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "md5 file";
            // 
            // EDITDISPfilemd5
            // 
            this.EDITDISPfilemd5.Location = new System.Drawing.Point(8, 61);
            this.EDITDISPfilemd5.Name = "EDITDISPfilemd5";
            this.EDITDISPfilemd5.ReadOnly = true;
            this.EDITDISPfilemd5.Size = new System.Drawing.Size(281, 20);
            this.EDITDISPfilemd5.TabIndex = 4;
            // 
            // BNBROWSEmd5
            // 
            this.BNBROWSEmd5.Location = new System.Drawing.Point(209, 20);
            this.BNBROWSEmd5.Name = "BNBROWSEmd5";
            this.BNBROWSEmd5.Size = new System.Drawing.Size(80, 20);
            this.BNBROWSEmd5.TabIndex = 1;
            this.BNBROWSEmd5.Text = "browse & calc";
            this.BNBROWSEmd5.UseVisualStyleBackColor = true;
            this.BNBROWSEmd5.Click += new System.EventHandler(this.BNBROWSEmd5_Click);
            // 
            // EDITfilemd5
            // 
            this.EDITfilemd5.Location = new System.Drawing.Point(6, 20);
            this.EDITfilemd5.Name = "EDITfilemd5";
            this.EDITfilemd5.Size = new System.Drawing.Size(197, 20);
            this.EDITfilemd5.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboencoptions);
            this.groupBox3.Controls.Add(this.BNfecn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.EDITepassconf);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.EDITepass);
            this.groupBox3.Controls.Add(this.BNENCRYPT);
            this.groupBox3.Controls.Add(this.EDITencfile);
            this.groupBox3.Location = new System.Drawing.Point(362, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 130);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encryption";
            // 
            // comboencoptions
            // 
            this.comboencoptions.FormattingEnabled = true;
            this.comboencoptions.Items.AddRange(new object[] {
            "3DES",
            "AES",
            "blowfish",
            "DES"});
            this.comboencoptions.Location = new System.Drawing.Point(20, 103);
            this.comboencoptions.Name = "comboencoptions";
            this.comboencoptions.Size = new System.Drawing.Size(121, 21);
            this.comboencoptions.Sorted = true;
            this.comboencoptions.TabIndex = 10;
            this.comboencoptions.SelectedIndexChanged += new System.EventHandler(this.comboencoptions_SelectedIndexChanged);
            // 
            // BNfecn
            // 
            this.BNfecn.Location = new System.Drawing.Point(174, 98);
            this.BNfecn.Name = "BNfecn";
            this.BNfecn.Size = new System.Drawing.Size(176, 20);
            this.BNfecn.TabIndex = 11;
            this.BNfecn.Text = "encrypt";
            this.BNfecn.UseVisualStyleBackColor = true;
            this.BNfecn.Click += new System.EventHandler(this.BNfecn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Confirm Password";
            // 
            // EDITepassconf
            // 
            this.EDITepassconf.Location = new System.Drawing.Point(123, 72);
            this.EDITepassconf.Name = "EDITepassconf";
            this.EDITepassconf.PasswordChar = '*';
            this.EDITepassconf.Size = new System.Drawing.Size(227, 20);
            this.EDITepassconf.TabIndex = 8;
            this.EDITepassconf.TextChanged += new System.EventHandler(this.EDITepassconf_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // EDITepass
            // 
            this.EDITepass.Cursor = System.Windows.Forms.Cursors.Default;
            this.EDITepass.Location = new System.Drawing.Point(123, 46);
            this.EDITepass.Name = "EDITepass";
            this.EDITepass.PasswordChar = '*';
            this.EDITepass.Size = new System.Drawing.Size(227, 20);
            this.EDITepass.TabIndex = 6;
            this.EDITepass.TextChanged += new System.EventHandler(this.EDITepass_TextChanged);
            // 
            // BNENCRYPT
            // 
            this.BNENCRYPT.Location = new System.Drawing.Point(223, 20);
            this.BNENCRYPT.Name = "BNENCRYPT";
            this.BNENCRYPT.Size = new System.Drawing.Size(80, 20);
            this.BNENCRYPT.TabIndex = 5;
            this.BNENCRYPT.Text = "browse";
            this.BNENCRYPT.UseVisualStyleBackColor = true;
            this.BNENCRYPT.Click += new System.EventHandler(this.BNENCRYPT_Click);
            // 
            // EDITencfile
            // 
            this.EDITencfile.Location = new System.Drawing.Point(6, 20);
            this.EDITencfile.Name = "EDITencfile";
            this.EDITencfile.Size = new System.Drawing.Size(197, 20);
            this.EDITencfile.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BNdecrypt);
            this.groupBox4.Controls.Add(this.combodecoptions);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.EDITDecpass);
            this.groupBox4.Controls.Add(this.BNbrowseDecfile);
            this.groupBox4.Controls.Add(this.EDITdecfile);
            this.groupBox4.Location = new System.Drawing.Point(362, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 104);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Decryption";
            // 
            // BNdecrypt
            // 
            this.BNdecrypt.Location = new System.Drawing.Point(157, 71);
            this.BNdecrypt.Name = "BNdecrypt";
            this.BNdecrypt.Size = new System.Drawing.Size(176, 20);
            this.BNdecrypt.TabIndex = 16;
            this.BNdecrypt.Text = "Decrypt";
            this.BNdecrypt.UseVisualStyleBackColor = true;
            this.BNdecrypt.Click += new System.EventHandler(this.BNdecrypt_Click);
            // 
            // combodecoptions
            // 
            this.combodecoptions.FormattingEnabled = true;
            this.combodecoptions.Items.AddRange(new object[] {
            "3DES",
            "AES",
            "blowfish",
            "DES"});
            this.combodecoptions.Location = new System.Drawing.Point(20, 71);
            this.combodecoptions.Name = "combodecoptions";
            this.combodecoptions.Size = new System.Drawing.Size(121, 21);
            this.combodecoptions.Sorted = true;
            this.combodecoptions.TabIndex = 15;
            this.combodecoptions.SelectedIndexChanged += new System.EventHandler(this.combodecoptions_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // EDITDecpass
            // 
            this.EDITDecpass.Cursor = System.Windows.Forms.Cursors.Default;
            this.EDITDecpass.Location = new System.Drawing.Point(123, 45);
            this.EDITDecpass.Name = "EDITDecpass";
            this.EDITDecpass.PasswordChar = '*';
            this.EDITDecpass.Size = new System.Drawing.Size(227, 20);
            this.EDITDecpass.TabIndex = 14;
            this.EDITDecpass.TextChanged += new System.EventHandler(this.EDITDecpass_TextChanged);
            // 
            // BNbrowseDecfile
            // 
            this.BNbrowseDecfile.Location = new System.Drawing.Point(223, 19);
            this.BNbrowseDecfile.Name = "BNbrowseDecfile";
            this.BNbrowseDecfile.Size = new System.Drawing.Size(80, 20);
            this.BNbrowseDecfile.TabIndex = 13;
            this.BNbrowseDecfile.Text = "browse";
            this.BNbrowseDecfile.UseVisualStyleBackColor = true;
            this.BNbrowseDecfile.Click += new System.EventHandler(this.BNbrowseDecfile_Click);
            // 
            // EDITdecfile
            // 
            this.EDITdecfile.Location = new System.Drawing.Point(6, 19);
            this.EDITdecfile.Name = "EDITdecfile";
            this.EDITdecfile.Size = new System.Drawing.Size(197, 20);
            this.EDITdecfile.TabIndex = 12;
            // 
            // BNabout
            // 
            this.BNabout.Location = new System.Drawing.Point(18, 232);
            this.BNabout.Name = "BNabout";
            this.BNabout.Size = new System.Drawing.Size(80, 20);
            this.BNabout.TabIndex = 14;
            this.BNabout.Text = "About";
            this.BNabout.UseVisualStyleBackColor = true;
            this.BNabout.Click += new System.EventHandler(this.BNabout_Click);
            // 
            // BNHELP
            // 
            this.BNHELP.Location = new System.Drawing.Point(117, 232);
            this.BNHELP.Name = "BNHELP";
            this.BNHELP.Size = new System.Drawing.Size(80, 20);
            this.BNHELP.TabIndex = 15;
            this.BNHELP.Text = "Help";
            this.BNHELP.UseVisualStyleBackColor = true;
            this.BNHELP.Click += new System.EventHandler(this.BNHELP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 274);
            this.Controls.Add(this.BNHELP);
            this.Controls.Add(this.BNabout);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cryptools 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EDITTEXT;
        private System.Windows.Forms.Button BNSHOWMD5;
        private System.Windows.Forms.TextBox EDITdispmd5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BNBROWSEmd5;
        private System.Windows.Forms.TextBox EDITfilemd5;
        private System.Windows.Forms.TextBox EDITDISPfilemd5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BNENCRYPT;
        private System.Windows.Forms.TextBox EDITencfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EDITepass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EDITepassconf;
        private System.Windows.Forms.Button BNfecn;
        private System.Windows.Forms.ComboBox comboencoptions;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BNdecrypt;
        private System.Windows.Forms.ComboBox combodecoptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EDITDecpass;
        private System.Windows.Forms.Button BNbrowseDecfile;
        private System.Windows.Forms.TextBox EDITdecfile;
        private System.Windows.Forms.Button BNabout;
        private System.Windows.Forms.Button BNHELP;
    }
}

