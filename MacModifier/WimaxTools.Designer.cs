namespace MacModifier
{
    partial class WimaxTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WimaxTools));
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnCmdDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSignal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModSerMac = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChangeMac = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChangeSerial = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.webBrowserContextMenu1 = new WebBrowserMenu.WebBrowserContextMenu();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResponse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.Location = new System.Drawing.Point(9, 47);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(451, 218);
            this.txtResponse.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.btnChangeMac,
            this.toolStripSeparator3,
            this.btnChangeSerial,
            this.toolStripSeparator5,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(469, 39);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCmdDisplay,
            this.btnSignal,
            this.btnNetwork,
            this.btnModSerMac});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(117, 36);
            this.toolStripSplitButton1.Text = "Display Info";
            // 
            // btnCmdDisplay
            // 
            this.btnCmdDisplay.Image = ((System.Drawing.Image)(resources.GetObject("btnCmdDisplay.Image")));
            this.btnCmdDisplay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCmdDisplay.Name = "btnCmdDisplay";
            this.btnCmdDisplay.Size = new System.Drawing.Size(194, 38);
            this.btnCmdDisplay.Text = "Basic Configuration";
            this.btnCmdDisplay.Click += new System.EventHandler(this.btnCmdDisplay_Click);
            // 
            // btnSignal
            // 
            this.btnSignal.Image = ((System.Drawing.Image)(resources.GetObject("btnSignal.Image")));
            this.btnSignal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSignal.Name = "btnSignal";
            this.btnSignal.Size = new System.Drawing.Size(194, 38);
            this.btnSignal.Text = "Signal Strength";
            this.btnSignal.Click += new System.EventHandler(this.btnSignal_Click);
            // 
            // btnNetwork
            // 
            this.btnNetwork.Image = ((System.Drawing.Image)(resources.GetObject("btnNetwork.Image")));
            this.btnNetwork.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(194, 38);
            this.btnNetwork.Text = "Network Adapter";
            this.btnNetwork.Click += new System.EventHandler(this.btnNetwork_Click_1);
            // 
            // btnModSerMac
            // 
            this.btnModSerMac.Image = ((System.Drawing.Image)(resources.GetObject("btnModSerMac.Image")));
            this.btnModSerMac.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModSerMac.Name = "btnModSerMac";
            this.btnModSerMac.Size = new System.Drawing.Size(194, 38);
            this.btnModSerMac.Text = "Modem Serial/Mac";
            this.btnModSerMac.Click += new System.EventHandler(this.btnModSerMac_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnChangeMac
            // 
            this.btnChangeMac.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeMac.Image")));
            this.btnChangeMac.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChangeMac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeMac.Name = "btnChangeMac";
            this.btnChangeMac.Size = new System.Drawing.Size(110, 36);
            this.btnChangeMac.Text = "Change Mac";
            this.btnChangeMac.Click += new System.EventHandler(this.btnChangeMac_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnChangeSerial
            // 
            this.btnChangeSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeSerial.Image")));
            this.btnChangeSerial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChangeSerial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeSerial.Name = "btnChangeSerial";
            this.btnChangeSerial.Size = new System.Drawing.Size(115, 36);
            this.btnChangeSerial.Text = "Change Serial";
            this.btnChangeSerial.Click += new System.EventHandler(this.btnChangeSerial_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDown = this.webBrowserContextMenu1;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(118, 28);
            this.toolStripDropDownButton1.Text = "Open Browser";
            // 
            // webBrowserContextMenu1
            // 
            this.webBrowserContextMenu1.Name = "webBrowserContextMenu1";
            this.webBrowserContextMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.webBrowserContextMenu1.Size = new System.Drawing.Size(179, 26);
            this.webBrowserContextMenu1.Url = null;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 276);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(469, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Image = global::MacModifier.Properties.Resources.typedef_public;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 17);
            this.lblStatus.Text = "Ready...";
            // 
            // WimaxTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 298);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtResponse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WimaxTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Huawei Wimax BM622i Tools";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnChangeMac;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnChangeSerial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem btnCmdDisplay;
        private System.Windows.Forms.ToolStripMenuItem btnSignal;
        private WebBrowserMenu.WebBrowserContextMenu webBrowserContextMenu1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnNetwork;
        private System.Windows.Forms.ToolStripMenuItem btnModSerMac;
      
    }
}