using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace crpytoolscs
{
    public partial class Form1 : Form
    {
        
        public OpenFileDialog encfile ;
        public Form1()
        {
            InitializeComponent();
        }

        private void BNSHOWMD5_Click(object sender, EventArgs e)
        {
            string orig = EDITTEXT.Text;
            //md5con x;
            //string newmd5=x.Encodemd5(orig);

            Byte[] origbytes;
            Byte[] encodedbytes;
            MD5 md5;
            md5 = new MD5CryptoServiceProvider();
            origbytes = ASCIIEncoding.Default.GetBytes(orig);
            encodedbytes = md5.ComputeHash(origbytes);
            string newmd5 = BitConverter.ToString(encodedbytes);

            //System.Windows.Forms.MessageBox.Show(newmd5);
            EDITdispmd5.Text = newmd5;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BNBROWSEmd5_Click(object sender, EventArgs e)
        {
            OpenFileDialog md5file=new OpenFileDialog();
            md5file.Title = "Select a file to crunch for md5";
            md5file.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            md5file.FilterIndex = 2;
            md5file.RestoreDirectory = false;
            if (md5file.ShowDialog() == DialogResult.OK)
            {
                EDITfilemd5.Text = md5file.FileName;
            }
            FileStream file; 
            byte[] retval;
            try
            {
                file = new FileStream(md5file.FileName, FileMode.Open);
                MD5 md5 = new MD5CryptoServiceProvider();
                retval = md5.ComputeHash(file);
                file.Close();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retval.Length; i++)
                {
                    sb.Append(retval[i].ToString("x2"));
                }
                EDITDISPfilemd5.Text = sb.ToString();
            }
            catch
            { }
            

            
        }

        private void BNENCRYPT_Click(object sender, EventArgs e)
        {
            encfile = new OpenFileDialog();
            encfile.Title = "Select a file to encrypt";
            encfile.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            encfile.FilterIndex = 2;
            encfile.RestoreDirectory = false;
            if (encfile.ShowDialog() == DialogResult.OK)
            {
                EDITencfile.Text = encfile.FileName;
            }
        }

        private void EDITepass_TextChanged(object sender, EventArgs e)
        {
            //EDITepass.Text = "";
            //EDITepass.PasswordChar = '*'; //uncomment only this line when needed
            //this.Cursor = Cursors.Arrow;
        }

        private void EDITepassconf_TextChanged(object sender, EventArgs e)
        {
            //EDITepassconf.Text = "";
            //EDITepassconf.PasswordChar = '*';
            //this.Cursor = Cursors.Arrow;
        }

        private void comboencoptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show(comboencoptions.SelectedItem.ToString());
            //System.Windows.Forms.MessageBox.Show(comboencoptions.SelectedIndex.ToString());
        }

        private void BNfecn_Click(object sender, EventArgs e)
        {
            if (EDITencfile.Text == "" || !File.Exists(EDITencfile.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter appropriate file");
                return;
            }
            if (EDITepassconf.Text != EDITepass.Text)
            {
                System.Windows.Forms.MessageBox.Show("Passwords dont match... ");
                return;
            }

            switch (comboencoptions.SelectedItem.ToString())
            {
                case "AES":
                    {
                        if (EDITepass.Text.Length != 16)
                        {
                            System.Windows.Forms.MessageBox.Show("Please enter 16 character pass for AES");
                            System.Windows.Forms.MessageBox.Show("AES functionality hasnt been provided. try DES");
                            return;
                        }

                        break;
                    }
                case "DES":
                    {
                        if (EDITepass.Text.Length != 8)
                        {
                            System.Windows.Forms.MessageBox.Show("Please enter 8 character pass for DES");
                            return;
                        }
                        string inputfile = EDITencfile.Text.ToString();
                        string outputfile = inputfile + ".des.";
                        string key = EDITepass.Text;
                        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                        DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
                        DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
                        ICryptoTransform desenc = DES.CreateEncryptor();
                        FileStream fsinput = new FileStream(inputfile, FileMode.Open, FileAccess.Read);
                        FileStream fsencout = new FileStream(outputfile, FileMode.OpenOrCreate, FileAccess.Write);

                        if(inputfile.Substring(inputfile.Length-3)=="txt" || true)
                        {
                        
                        CryptoStream cryptstream = new CryptoStream(fsencout, desenc, CryptoStreamMode.Write);
                        byte[] bytearrayinput = new byte[fsinput.Length];
                        fsinput.Read(bytearrayinput, 0, bytearrayinput.Length);
                        cryptstream.Write(bytearrayinput, 0, bytearrayinput.Length);
                        cryptstream.Close();
                        fsinput.Close();
                        fsencout.Close();
                        }
                        else
                        {
                            MessageBox.Show("non txt");
                            BinaryReader bnin= new BinaryReader(fsinput);
                            CryptoStream cryptstream = new CryptoStream(fsencout, desenc, CryptoStreamMode.Write);
                            byte[] bytearrayinput = new byte[fsinput.Length];
                            bnin.Read(bytearrayinput,0,bytearrayinput.Length);
                            cryptstream.Write(bytearrayinput,0,bytearrayinput.Length);
                            cryptstream.Close();
                            fsinput.Close();
                            bnin.Close();
                        }

                        MessageBox.Show("Done");
                        break;
                    }
                default:
                    {
                        System.Windows.Forms.MessageBox.Show("Only DES works. try that");
                        break;
                    }
            }
        }

        private void BNabout_Click(object sender, EventArgs e)
        {
            AboutCryptools a = new AboutCryptools();
            a.ShowDialog();
        }

        private void BNHELP_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Md5 text shows md5 hash of a given string. MD5 file finds the md5 hash of a file. Encrypt a file or decrypt using appropriate algorithm... ");
        }

        private void EDITDecpass_TextChanged(object sender, EventArgs e)
        {
            //EDITDecpass.PasswordChar = '*';
        }

        private void BNbrowseDecfile_Click(object sender, EventArgs e)
        {
            encfile = new OpenFileDialog();
            encfile.Title = "Select a file to decrypt";
            encfile.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            encfile.FilterIndex = 2;
            encfile.RestoreDirectory = false;
            if (encfile.ShowDialog() == DialogResult.OK)
            {
                EDITdecfile.Text = encfile.FileName;
            }            
        }

        private void combodecoptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BNdecrypt_Click(object sender, EventArgs e)
        {
            if (EDITdecfile.Text == "" || !File.Exists(EDITdecfile.Text))
            {
                System.Windows.Forms.MessageBox.Show("Please enter appropriate file");
                return;
            }
            switch (combodecoptions.SelectedItem.ToString())
            {
                case "AES":
                    {
                        if (EDITDecpass.Text.Length != 16)
                        {
                            System.Windows.Forms.MessageBox.Show("Please enter 16 character pass for AES");
                            System.Windows.Forms.MessageBox.Show("AES functionality hasnt been provided. try DES");
                            return;
                        }

                        break;
                    }
                case "DES":
                    {
                        if (EDITDecpass.Text.Length != 8)
                        {
                            System.Windows.Forms.MessageBox.Show("Please enter 8 character pass for DES");
                            return;
                        }
                        string inputfile = EDITdecfile.Text.ToString();
                        string outputfile = inputfile.Remove(EDITdecfile.Text.Length - 4);
                        MessageBox.Show(outputfile);
                        string key = EDITDecpass.Text;
                        FileStream fsinput = new FileStream(inputfile, FileMode.Open, FileAccess.Read);
                        //FileStream fsdecout = new FileStream(outputfile, FileMode.OpenOrCreate, FileAccess.Write);
                        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                        DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
                        DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
                        ICryptoTransform desenc = DES.CreateDecryptor();
                        CryptoStream cryptstream;
                        try
                        {
                            cryptstream = new CryptoStream(fsinput, desenc, CryptoStreamMode.Read);
                            string x=outputfile;
                            if (x.Substring(outputfile.Length - 3) == "txt" || true)
                            {
                                StreamWriter fsdecout = new StreamWriter(outputfile);
                                fsdecout.Write(new StreamReader(cryptstream).ReadToEnd());
                                fsdecout.Flush();
                                fsdecout.Close();
                            }
                            else
                            {
                                //from here
                                MessageBox.Show("non txt");
                                FileStream fsdecout = new FileStream(outputfile, FileMode.OpenOrCreate, FileAccess.Write);
                                BinaryWriter outb = new BinaryWriter(fsdecout);
                                outb.Write(new StreamReader(cryptstream).ReadToEnd());
                                fsdecout.Flush();
                                fsdecout.Close();
                                //till here
                            }
                            cryptstream.Flush();
                            cryptstream.Close();
                            
                            /*
                            byte[] bytearrayinput = new byte[fsinput.Length - 1];
                            fsinput.Read(bytearrayinput, 0, bytearrayinput.Length);
                            cryptstream.Write(bytearrayinput, 0, bytearrayinput.Length);
                             */
                            
                            
                           
                            
                        }
                        catch
                        {
                            MessageBox.Show("Could not decrypt. possibly wrong password");
                        }
                        finally
                        {
                            
                            
                            MessageBox.Show("Done");
                            
                            fsinput.Close();
                        }
                         
                        break;
                    }
                default:
                    {
                        System.Windows.Forms.MessageBox.Show("Only DES works. try that");
                        break;
                    }
            }
        }

        private void EDITTEXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
