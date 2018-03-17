using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace MacModifier
{
    public partial class MacModifierForm : Form
    {
        public char[] c = { '\n', '#', '\r' };
        StringBuilder _sb = new StringBuilder();
        public bool isExecute = false;
        public MacModifierForm()
        {
            InitializeComponent();
            InitializeMac();
            txtMac.Focus();
        }
        private void InitializeMac()
        {
           try
            {
                Cursor.Current = Cursors.WaitCursor;

                txtCurMac.Text = String.Empty;
                TelnetConnection tc = new TelnetConnection("192.168.1.1", 23);

                string s = tc.Login("wimax", "wimax820", 100);

                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);
                if (prompt != "$" && prompt != ">")
                    throw new Exception("Connection failed");

                tc.WriteLine("shell");
                tc.WriteLine("equipcmd macaddr display");
                prompt = tc.Read();
                String[] mac = prompt.Split(':');
                String [] macs = mac[6].Split('\r');
              
               UInt32 currInput = Conversions.Input2Binary( macs[0].ToString());

				String last = Conversions.Binary2Output( macs[0].ToString(), currInput - 1 );


                String str = (mac[1] + ":" + mac[2] + ":" + mac[3] + ":" + mac[4] + ":" + mac[5] + ":" + last).Trim(c); 
                txtCurMac.Text = str.ToUpper();
                lblStatus.Text = "      Initializing complete!";
                lblStatus.ForeColor = Color.Black;
               
           }

           catch
            {
                txtCurMac.Text = "<Unknown>";
                lblStatus.Text = "      Exception Error!";
                lblStatus.ForeColor = Color.Red;

           }
           Cursor.Current = Cursors.Default;
        }
       
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //create a new telnet connection to hostname "gobelijn" on port "23"
                TelnetConnection tc = new TelnetConnection("192.168.1.1", 23);


                //login with user "root",password "rootpassword", using a timeout of 100ms, and show server output
                string s = tc.Login("wimax", "wimax820", 100);
                textBox2.AppendText(s);
                //Console.Write(s);

                // server output should end with "$" or ">", otherwise the connection failed
                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);
                if (prompt != "$" && prompt != ">")
                    throw new Exception("Connection failed");

                prompt = "";


                // display server output
                textBox2.AppendText(tc.Read());
                // Console.Write(tc.Read());

                // send client input to server
                prompt = "setallmacaddr "+txtMac.Text;
                tc.WriteLine(prompt);

                // display server output
                textBox2.AppendText(tc.Read());
                //Console.Write(tc.Read());

                prompt = "restoredef";
                tc.WriteLine(prompt);
                textBox2.AppendText(tc.Read());
                Cursor.Current = Cursors.Default;
                this.Close();
            }
            catch
            {
                lblStatus.Text = "      Exception Error!";
                lblStatus.ForeColor = Color.Red;
            }
           
        }

        private void txtMac_TextChanged(object sender, EventArgs e)
        {
         
            
            btnChange.Enabled = txtMac.TextLength > 0;
        }

        private void txtMac_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = (int) e.KeyChar;          
            if (IsValidChar(c)==false && IsValidChar(e.KeyChar)==false)
            {
                e.Handled = true;
            }
        }
        private bool IsValidChar(int c)
        {
            if(c>=65 && c<= 70) return true;
            if (c >= 97 && c <= 102) return true;
            if (c >=48 && c<= 58) return true;
            if (c == 8) return true;
           
            return false;
        }

        private bool IsValidChar(char c)
        {
            if (c >= 'a' && c <= 'f') return true;
            if (c >= 'A' && c <= 'F') return true;
            if (c >='1' && c<=':') return true;
           // if (c >= 'space') ;
            return false;
        }

        

        


    }
}
