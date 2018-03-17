using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacModifier {
    public partial class WimaxTools : Form {

        public WimaxTools() {
            InitializeComponent();
            InitializeTelnet();
        }

        private void InitializeTelnet() {
            try {
                TelnetConnection tc = new TelnetConnection("192.168.1.1", 23);

                string s = tc.Login("wimax", "wimax820", 100);

                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);
                if(prompt != "$" && prompt != ">")
                    throw new Exception("Connection failed");

                prompt = "";

                if(s != "") {
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
                    this.lblStatus.Image = global::MacModifier.Properties.Resources.typedef_public;
                    this.lblStatus.Text = "Connected.";
                    this.lblStatus.ForeColor = Color.Black;
                    txtResponse.ForeColor = Color.Black;



                } else {
                    txtResponse.Text = "Connection failed..." + Environment.NewLine + "\nDisconnected...";
                    txtResponse.ForeColor = Color.Red;
                    this.lblStatus.Image = global::MacModifier.Properties.Resources.typedef_private;
                    this.lblStatus.Text = "Disconnected.";
                    this.lblStatus.ForeColor = Color.Red;

                }
            } catch {
                this.lblStatus.Image = global::MacModifier.Properties.Resources.typedef_private;
                this.lblStatus.Text = "Error in connecting the wimax.";
                txtResponse.Text = "Error in connecting the wimax.";
                txtResponse.ForeColor = Color.Red;
                this.lblStatus.ForeColor = Color.Red;


            }


        }

        void btnCmdDisplay_Click(object sender, EventArgs e) {
            txtResponse.Text = String.Empty;

            try {
                Cursor.Current = Cursors.WaitCursor;

                TelnetConnection tc = new TelnetConnection(AuthVars.HOSTNAME, AuthVars.PORT);

                string s = tc.Login(AuthVars.USERNAME, AuthVars.PASSWORD, AuthVars.TIMEOUT);

                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);
                if(prompt != "$" && prompt != ">")
                    throw new Exception("Connection failed");

                tc.WriteLine(Command.BasicConfig);
                txtResponse.AppendText(tc.Read());
                txtResponse.ForeColor = Color.Black;
                this.lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "Basic Configuration.";
                this.lblStatus.Image = global::MacModifier.Properties.Resources.typedef_public;
            } catch {
                txtResponse.Text = "Error in displaying basic configuration.";
                this.lblStatus.Text = "Error in displaying basic configuration.";
                txtResponse.ForeColor = Color.Red;
                this.lblStatus.ForeColor = Color.Red;
                this.lblStatus.Image = global::MacModifier.Properties.Resources.typedef_private;


            }
            Cursor.Current = Cursors.Default;
        }

        void btnSignal_Click(object sender, EventArgs e) {
            try {
                Cursor.Current = Cursors.WaitCursor;

                txtResponse.Text = String.Empty;

                TelnetConnection tc = new TelnetConnection(AuthVars.HOSTNAME, AuthVars.PORT);

                string s = tc.Login(AuthVars.USERNAME, AuthVars.PASSWORD, AuthVars.TIMEOUT);

                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);
                if(prompt != "$" && prompt != ">")
                    throw new Exception("Connection failed");

                tc.WriteLine("cmd showssp");
                txtResponse.AppendText(tc.Read());
                txtResponse.ForeColor = Color.Black;
                this.lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "Signal Strength.";
                this.lblStatus.Image = global::MacModifier.Properties.Resources.typedef_public;
            } catch {
                txtResponse.Text = "Error in displaying subscriber station.";
                this.lblStatus.Text = "Error in displaying subscriber station.";
                txtResponse.ForeColor = Color.Red;
                this.lblStatus.ForeColor = Color.Red;
                this.lblStatus.Image = global::MacModifier.Properties.Resources.typedef_private;

            }
            Cursor.Current = Cursors.Default;
        }

        void btnChangeMac_Click(object sender, EventArgs e) {
            MacModifierForm macMod = new MacModifierForm();
            macMod.ShowDialog();
        }

        void btnChangeSerial_Click(object sender, EventArgs e) {
            SerialModifierForm serMod = new SerialModifierForm();
            serMod.ShowDialog();
        }

        void btnNetwork_Click(object sender, EventArgs e) {

        }

        private void btnNetwork_Click_1(object sender, EventArgs e) {

        }

        private void btnModSerMac_Click(object sender, EventArgs e) {
            try {
                Cursor.Current = Cursors.WaitCursor;

                txtResponse.Text = String.Empty;

                TelnetConnection tc = new TelnetConnection(AuthVars.HOSTNAME, AuthVars.PORT);

                string s = tc.Login(AuthVars.USERNAME, AuthVars.PASSWORD, AuthVars.TIMEOUT);

                string prompt = s.TrimEnd();
                prompt = s.Substring(prompt.Length - 1, 1);
                if(prompt != "$" && prompt != ">")
                    throw new Exception("Connection failed");

                tc.WriteLine(Command.OpenShell);
                txtResponse.AppendText(tc.Read());
                tc.WriteLine(Command.DisplaySerial);
                txtResponse.AppendText(tc.Read());
                tc.WriteLine(Command.DisplayMAC);
                txtResponse.AppendText(tc.Read());
                txtResponse.ForeColor = Color.Black;
                this.lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "Modem Serial - Mac";
                this.lblStatus.Image = global::MacModifier.Properties.Resources.typedef_public;
            } catch {
                txtResponse.Text = "Error in displaying serial /mac.";
                this.lblStatus.Text = "Error in displaying serial /mac.";
                txtResponse.ForeColor = Color.Red;
                this.lblStatus.ForeColor = Color.Red;
                this.lblStatus.Image = global::MacModifier.Properties.Resources.typedef_private;
            }
            Cursor.Current = Cursors.Default;
        }
    }
}