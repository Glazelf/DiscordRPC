
namespace DiscordRPC.WinForms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButon = new System.Windows.Forms.Button();
            this.ClientIDNumeric = new System.Windows.Forms.NumericUpDown();
            this.ClientIDLabel = new System.Windows.Forms.Label();
            this.RPCTabControl = new System.Windows.Forms.TabControl();
            this.RPCSettingsTab = new System.Windows.Forms.TabPage();
            this.RPCLogTab = new System.Windows.Forms.TabPage();
            this.LogText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientIDNumeric)).BeginInit();
            this.RPCTabControl.SuspendLayout();
            this.RPCLogTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButon
            // 
            this.ConnectButon.AccessibleName = "ConnectButon";
            this.ConnectButon.Location = new System.Drawing.Point(713, 415);
            this.ConnectButon.Name = "ConnectButon";
            this.ConnectButon.Size = new System.Drawing.Size(75, 23);
            this.ConnectButon.TabIndex = 0;
            this.ConnectButon.Text = "Connect";
            this.ConnectButon.UseVisualStyleBackColor = true;
            this.ConnectButon.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ClientIDNumeric
            // 
            this.ClientIDNumeric.AccessibleName = "ClientIDNumeric";
            this.ClientIDNumeric.Location = new System.Drawing.Point(583, 355);
            this.ClientIDNumeric.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.ClientIDNumeric.Name = "ClientIDNumeric";
            this.ClientIDNumeric.Size = new System.Drawing.Size(205, 23);
            this.ClientIDNumeric.TabIndex = 2;
            this.ClientIDNumeric.ValueChanged += new System.EventHandler(this.ClientIDNumeric_ValueChanged);
            // 
            // ClientIDLabel
            // 
            this.ClientIDLabel.AccessibleName = "ClientIDLabel";
            this.ClientIDLabel.AutoSize = true;
            this.ClientIDLabel.Location = new System.Drawing.Point(522, 357);
            this.ClientIDLabel.Name = "ClientIDLabel";
            this.ClientIDLabel.Size = new System.Drawing.Size(55, 15);
            this.ClientIDLabel.TabIndex = 3;
            this.ClientIDLabel.Text = "Client ID:";
            // 
            // RPCTabControl
            // 
            this.RPCTabControl.AccessibleName = "RPCTabControl";
            this.RPCTabControl.Controls.Add(this.RPCSettingsTab);
            this.RPCTabControl.Controls.Add(this.RPCLogTab);
            this.RPCTabControl.Location = new System.Drawing.Point(0, 0);
            this.RPCTabControl.Name = "RPCTabControl";
            this.RPCTabControl.SelectedIndex = 0;
            this.RPCTabControl.Size = new System.Drawing.Size(788, 349);
            this.RPCTabControl.TabIndex = 4;
            // 
            // RPCSettingsTab
            // 
            this.RPCSettingsTab.AccessibleName = "RPCSettingsTab";
            this.RPCSettingsTab.Location = new System.Drawing.Point(4, 24);
            this.RPCSettingsTab.Name = "RPCSettingsTab";
            this.RPCSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.RPCSettingsTab.Size = new System.Drawing.Size(780, 321);
            this.RPCSettingsTab.TabIndex = 1;
            this.RPCSettingsTab.Text = "Settings";
            this.RPCSettingsTab.UseVisualStyleBackColor = true;
            // 
            // RPCLogTab
            // 
            this.RPCLogTab.AccessibleName = "RPCLogTab";
            this.RPCLogTab.Controls.Add(this.LogText);
            this.RPCLogTab.Location = new System.Drawing.Point(4, 24);
            this.RPCLogTab.Name = "RPCLogTab";
            this.RPCLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.RPCLogTab.Size = new System.Drawing.Size(780, 321);
            this.RPCLogTab.TabIndex = 2;
            this.RPCLogTab.Text = "Log";
            this.RPCLogTab.UseVisualStyleBackColor = true;
            // 
            // LogText
            // 
            this.LogText.AccessibleName = "LogText";
            this.LogText.Location = new System.Drawing.Point(0, 0);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(780, 321);
            this.LogText.TabIndex = 0;
            this.LogText.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RPCTabControl);
            this.Controls.Add(this.ClientIDLabel);
            this.Controls.Add(this.ClientIDNumeric);
            this.Controls.Add(this.ConnectButon);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientIDNumeric)).EndInit();
            this.RPCTabControl.ResumeLayout(false);
            this.RPCLogTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButon;
        private System.Windows.Forms.NumericUpDown ClientIDNumeric;
        private System.Windows.Forms.Label ClientIDLabel;
        private System.Windows.Forms.TabControl RPCTabControl;
        private System.Windows.Forms.TabPage RPCSettingsTab;
        private System.Windows.Forms.TabPage RPCLogTab;
        private System.Windows.Forms.RichTextBox LogText;
    }
}

