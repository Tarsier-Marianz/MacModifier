using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacModifier
{
    public partial class SerialModifierForm : Form
    {
        public char[] c = { '\n', '#',' '};
        public SerialModifierForm()
        {
            InitializeComponent();
            InitializeSerial();
        }

        private void InitializeSerial()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                txtCurSerial.Text = String.Empty;
                TelnetConnection tc = new TelnetConnection("192.168.1.1", 23);

                string s = tc.Login("wimax", "wimax820", 100);

                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);
                if (prompt != "$" && prompt != ">")
                    throw new Exception("Connection failed");

                tc.WriteLine("shell");
                tc.WriteLine("equipcmd serialnum display");
                prompt = tc.Read();
                String[] mac = prompt.Split(':');
                 String[] macs= mac[1].Split('\r');
                 txtCurSerial.Text = macs[0].Trim(c).ToUpper();
                 lblStatus.Text = "      Initializing complete!";
                 lblStatus.ForeColor = Color.Black;
            }
            catch
            {
                txtCurSerial.Text = "<Unknown>";
                lblStatus.Text = "      Exception Error!";
                lblStatus.ForeColor = Color.Red;

            }
            Cursor.Current = Cursors.Default;
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            btnChange.Enabled = txtSerial.TextLength > 0;
        }

       

        private void txtSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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
                prompt = "setserialnum " + txtSerial.Text;
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
    }
}
