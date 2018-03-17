using MacModifier.Helpers;
using MacModifier.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MacModifier {
    public partial class WimaxTools : Form {
        private TelnetConnection tc = null;
        private string response = string.Empty;
        private string macAddress = string.Empty;
        private bool isConnected = false;

        public WimaxTools() {
            InitializeComponent();
            InitializeTelnet();
        }

        private void InitializeTelnet() {
            Cursor.Current = Cursors.WaitCursor;
            try {
                tc = new TelnetConnection(AuthVars.HOSTNAME, AuthVars.PORT);
                response = tc.Login(AuthVars.USERNAME, AuthVars.PASSWORD, AuthVars.TIMEOUT);
                string prompt = response.TrimEnd();
                prompt = response.Substring(prompt.Length - 1, 1);
                if(prompt != "$" && prompt != ">")
                    throw new Exception("Connection failed");

                prompt = string.Empty;
                if(!string.IsNullOrEmpty(response)) {
                    txtResponse.AppendText("Initializing completed..." + Environment.NewLine);
                    txtResponse.AppendText("Connected...");
                    txtResponse.AppendText(Environment.NewLine);
                    txtResponse.AppendText(Environment.NewLine);
                    txtResponse.AppendText(Environment.NewLine);

                    txtResponse.AppendText("Welcome To Huawei Wimax Tools...");
                    txtResponse.AppendText(Environment.NewLine);
                    txtResponse.AppendText("Huawei Wimax Tools...");
                    txtResponse.AppendText(Environment.NewLine);
                    txtResponse.AppendText("Version : v.1.0.0");
                    txtResponse.AppendText(Environment.NewLine);
                    txtResponse.AppendText("Copyright © MarianzK®™. 2012");
                    txtResponse.AppendText(Environment.NewLine);
                    txtResponse.AppendText("All Rights Reserved™. 2012");
                    SetConnection(true);
                } else {
                    SetConnection(false);
                }
            } catch {
                SetErrorStatus("Error in connecting the wimax.", true);
            } finally {
                Cursor.Current = Cursors.Default;
            }
        }
        void btnCmdDisplay_Click(object sender, EventArgs e) {
            txtResponse.Text = String.Empty;
            try {
                Cursor.Current = Cursors.WaitCursor;
                if(tc.IsConnected) {
                    tc.WriteLine(Command.BasicConfig);
                    txtResponse.AppendText(tc.Read());
                    SetResponseOK("Basic Configuration.");
                } else {
                    SetConnection(false);
                }
            } catch {
                SetErrorStatus("Error in displaying basic configuration.", true);
            } finally {
                Cursor.Current = Cursors.Default;
            }
        }

        void btnSignal_Click(object sender, EventArgs e) {
            txtResponse.Text = String.Empty;
            try {
                Cursor.Current = Cursors.WaitCursor;
                if(tc.IsConnected) {
                    tc.WriteLine(Command.SignalStrength);
                    txtResponse.AppendText(tc.Read());
                    SetResponseOK("Signal Strength");
                } else {
                    SetConnection(false);
                }
            } catch {
                SetErrorStatus("Error in displaying subscriber station.", true);
            } finally {
                Cursor.Current = Cursors.Default;
            }
        }

        
        private void btnModSerMac_Click(object sender, EventArgs e) {
            txtResponse.Text = String.Empty;
            try {
                Cursor.Current = Cursors.WaitCursor;
                if(tc.IsConnected) {
                    tc.WriteLine(Command.OpenShell);
                    txtResponse.AppendText(tc.Read());
                    tc.WriteLine(Command.DisplaySerial);
                    txtResponse.AppendText(tc.Read());
                    tc.WriteLine(Command.DisplayMAC);
                    string macResponse = tc.Read();
                    txtResponse.AppendText(macResponse);
                    macAddress = MacExtractor.GetMac(macResponse);
                    SetResponseOK("Modem Serial - Mac");
                } else {
                    SetConnection(false);
                }

            } catch {
                SetErrorStatus("Error in displaying serial /mac.", true);
            } finally {
                Cursor.Current = Cursors.Default;
            }
        }
        void btnChangeMac_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(macAddress)) {
                SetErrorStatus("Cannot change MAC. Please make sure you are connected to modem.", true);
            } else {
                using(MacModifierForm macMod = new MacModifierForm(macAddress)) {
                    macMod.ShowDialog();
                }
            }
        }
        void btnChangeSerial_Click(object sender, EventArgs e) {
            using(SerialModifierForm serMod = new SerialModifierForm()) {
                serMod.ShowDialog();
            }
        }
        private void SetConnection(bool connection) {
            if(connection) {
                txtResponse.ForeColor = Color.DarkGreen;
                this.lblStatus.ForeColor = Color.DarkGreen;
                lblStatus.Text = "Connected.";
                this.lblStatus.Image = Resources.typedef_public;
            } else {
                txtResponse.Text = "Connection failed..." + Environment.NewLine + "\nDisconnected...";
                txtResponse.ForeColor = Color.Red;
                this.lblStatus.Image = Resources.typedef_private;
                this.lblStatus.Text = "Disconnected.";
                this.lblStatus.ForeColor = Color.Red;
            }
        }

        private void SetErrorStatus(string message, bool displayResponse) {
            if(displayResponse) {
                txtResponse.Text = message;
            }
            this.lblStatus.Text = message;
            txtResponse.ForeColor = Color.Red;
            this.lblStatus.ForeColor = Color.Red;
            this.lblStatus.Image = Resources.typedef_private;
        }

        private void SetResponseOK(string message) {
            this.lblStatus.Text = message;
            this.lblStatus.ForeColor = Color.Green;
            this.lblStatus.Image = Resources.typedef_public;
        }
    }
}