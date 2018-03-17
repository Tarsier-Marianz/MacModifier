using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace MacModifier {
    public partial class MacModifierForm : Form {
        private TelnetConnection tc = null;
        private Validator val = new Validator();
        private StringBuilder _sb = new StringBuilder();
        private string response = string.Empty;
        private string mac = string.Empty;
        private bool isExecute = false;
        public MacModifierForm(string macAddress) {
            InitializeComponent();
            mac = macAddress;
            InitializeMac();
        }
        private void InitializeMac() {
            Cursor.Current = Cursors.WaitCursor;
            try {
                txtCurMac.Text = mac.ToUpper();
                lblStatus.Text = "      Initializing complete!";
                lblStatus.ForeColor = Color.Black;
                txtMac.Focus();
            } catch {
                txtCurMac.Text = "<Unknown>";
                lblStatus.Text = "      Exception Error!";
                lblStatus.ForeColor = Color.Red;
            }
            Cursor.Current = Cursors.Default;
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
                    tc.WriteLine(string.Format(Command.SetMacAddFormat, txtMac.Text.Trim()));
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
        private void txtMac_TextChanged(object sender, EventArgs e) {
            btnChange.Enabled = txtMac.TextLength > 8;
        }

        private void txtMac_KeyPress(object sender, KeyPressEventArgs e) {
            int c = (int)e.KeyChar;
            if(val.IsValidChar(c) == false && val.IsValidChar(e.KeyChar) == false) {
                e.Handled = true;
            }
        }
    }
}