using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacModifier {
    public partial class SerialModifierForm : Form {
        private TelnetConnection tc = null;
        private Validator val = new Validator();
        private StringBuilder _sb = new StringBuilder();
        private string response = string.Empty;
        private string serialNumber = string.Empty;
        private bool isExecute = false;
        public SerialModifierForm(string serial) {
            InitializeComponent();
            serialNumber = serial;
            InitializeSerial();
        }

        private void InitializeSerial() {
            try {
                Cursor.Current = Cursors.WaitCursor;
                txtCurSerial.Text = serialNumber;
                lblStatus.Text = "      Initializing complete!";
                lblStatus.ForeColor = Color.Black;
            } catch {
                txtCurSerial.Text = "<Unknown>";
                lblStatus.Text = "      Exception Error!";
                lblStatus.ForeColor = Color.Red;

            }
            Cursor.Current = Cursors.Default;
        }

        private void txtSerial_TextChanged(object sender, EventArgs e) {
            btnChange.Enabled = txtSerial.TextLength > 0;
        }
        private void btnChange_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                tc = new TelnetConnection(AuthVars.HOSTNAME, AuthVars.PORT);
                response = tc.Login(AuthVars.USERNAME, AuthVars.PASSWORD, AuthVars.TIMEOUT);

                string prompt = response.TrimEnd();
                prompt = response.Substring(prompt.Length - 1, 1);
                if(prompt != "$" && prompt != ">")
                    throw new Exception("Connection failed");

                if(tc.IsConnected) {
                    tc.WriteLine(string.Format(Command.SetSerialFormat, txtSerial.Text.Trim()));
                    textBox2.AppendText(tc.Read());
                    tc.WriteLine(Command.RestoreDefault);
                    textBox2.AppendText(tc.Read());
                    this.Close();
                } else {
                    lblStatus.Text = "      Not connected!";
                    lblStatus.ForeColor = Color.Red;
                }
            } catch {
                lblStatus.Text = "      Exception Error!";
                lblStatus.ForeColor = Color.Red;
            } finally {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}