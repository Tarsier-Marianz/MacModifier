namespace MacModifier
{
    partial class MacModifierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacModifierForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bgWorkerUpdate = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.txtCurMac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.macTextbox1 = new MacModifier.MacTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Mac Address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(169, 114);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(66, 23);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Image = ((System.Drawing.Image)(resources.GetObject("lblStatus.Image")));
            this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Location = new System.Drawing.Point(12, 114);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(136, 23);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "          Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(15, 240);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(299, 0);
            this.textBox2.TabIndex = 6;
            // 
            // bgWorkerUpdate
            // 
            this.bgWorkerUpdate.WorkerReportsProgress = true;
            this.bgWorkerUpdate.WorkerSupportsCancellation = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(241, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtMac
            // 
            this.txtMac.Location = new System.Drawing.Point(64, 80);
            this.txtMac.MaxLength = 17;
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(243, 21);
            this.txtMac.TabIndex = 8;
            this.txtMac.TextChanged += new System.EventHandler(this.txtMac_TextChanged);
            this.txtMac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMac_KeyPress);
            // 
            // txtCurMac
            // 
            this.txtCurMac.Location = new System.Drawing.Point(64, 27);
            this.txtCurMac.MaxLength = 17;
            this.txtCurMac.Name = "txtCurMac";
            this.txtCurMac.ReadOnly = true;
            this.txtCurMac.Size = new System.Drawing.Size(243, 21);
            this.txtCurMac.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "          New Mac Address:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // macTextbox1
            // 
            this.macTextbox1.BackColor = System.Drawing.Color.White;
            this.macTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.macTextbox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTextbox1.Location = new System.Drawing.Point(349, 24);
            this.macTextbox1.Name = "macTextbox1";
            this.macTextbox1.Size = new System.Drawing.Size(202, 32);
            this.macTextbox1.TabIndex = 9;
            // 
            // MacModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 150);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurMac);
            this.Controls.Add(this.macTextbox1);
            this.Controls.Add(this.txtMac);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MacModifierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Mac Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker bgWorkerUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMac;
        private MacTextbox macTextbox1;
        private System.Windows.Forms.TextBox txtCurMac;
        private System.Windows.Forms.Label label2;
    }
}

