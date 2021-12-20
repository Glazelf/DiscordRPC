
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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ClientIDNumeric = new System.Windows.Forms.NumericUpDown();
            this.ClientIDLabel = new System.Windows.Forms.Label();
            this.RPCTabControl = new System.Windows.Forms.TabControl();
            this.RPCSettingsTab = new System.Windows.Forms.TabPage();
            this.DetailsText = new System.Windows.Forms.TextBox();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.StateText = new System.Windows.Forms.TextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.SmallImageTooltipText = new System.Windows.Forms.TextBox();
            this.SmallImageTooltipLabel = new System.Windows.Forms.Label();
            this.SmallImageKeyLabel = new System.Windows.Forms.Label();
            this.SmallImageKeyText = new System.Windows.Forms.TextBox();
            this.LargeImageTooltipText = new System.Windows.Forms.TextBox();
            this.LargeImageTooltipLabel = new System.Windows.Forms.Label();
            this.LargeImageKeyText = new System.Windows.Forms.TextBox();
            this.LargeImageKeyLabel = new System.Windows.Forms.Label();
            this.RPCLogTab = new System.Windows.Forms.TabPage();
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.ConnectionGroup = new System.Windows.Forms.GroupBox();
            this.SyncButton = new System.Windows.Forms.Button();
            this.StatusGroup = new System.Windows.Forms.GroupBox();
            this.TaskBarCheckBox = new System.Windows.Forms.CheckBox();
            this.StatusConnectionText = new System.Windows.Forms.Label();
            this.StatusConnectionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientIDNumeric)).BeginInit();
            this.RPCTabControl.SuspendLayout();
            this.RPCSettingsTab.SuspendLayout();
            this.RPCLogTab.SuspendLayout();
            this.ConnectionGroup.SuspendLayout();
            this.StatusGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.AccessibleName = "ConnectButton";
            this.ConnectButton.Location = new System.Drawing.Point(43, 68);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(86, 31);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ClientIDNumeric
            // 
            this.ClientIDNumeric.AccessibleName = "ClientIDNumeric";
            this.ClientIDNumeric.Location = new System.Drawing.Point(73, 29);
            this.ClientIDNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientIDNumeric.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.ClientIDNumeric.Name = "ClientIDNumeric";
            this.ClientIDNumeric.Size = new System.Drawing.Size(149, 27);
            this.ClientIDNumeric.TabIndex = 2;
            this.ClientIDNumeric.ValueChanged += new System.EventHandler(this.ClientIDNumeric_ValueChanged);
            // 
            // ClientIDLabel
            // 
            this.ClientIDLabel.AccessibleName = "ClientIDLabel";
            this.ClientIDLabel.AutoSize = true;
            this.ClientIDLabel.Location = new System.Drawing.Point(7, 32);
            this.ClientIDLabel.Name = "ClientIDLabel";
            this.ClientIDLabel.Size = new System.Drawing.Size(69, 20);
            this.ClientIDLabel.TabIndex = 3;
            this.ClientIDLabel.Text = "Client ID:";
            // 
            // RPCTabControl
            // 
            this.RPCTabControl.AccessibleName = "RPCTabControl";
            this.RPCTabControl.Controls.Add(this.RPCSettingsTab);
            this.RPCTabControl.Controls.Add(this.RPCLogTab);
            this.RPCTabControl.Location = new System.Drawing.Point(0, 0);
            this.RPCTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RPCTabControl.Name = "RPCTabControl";
            this.RPCTabControl.SelectedIndex = 0;
            this.RPCTabControl.Size = new System.Drawing.Size(633, 284);
            this.RPCTabControl.TabIndex = 4;
            // 
            // RPCSettingsTab
            // 
            this.RPCSettingsTab.AccessibleName = "RPCSettingsTab";
            this.RPCSettingsTab.Controls.Add(this.DetailsText);
            this.RPCSettingsTab.Controls.Add(this.DetailsLabel);
            this.RPCSettingsTab.Controls.Add(this.StateText);
            this.RPCSettingsTab.Controls.Add(this.StateLabel);
            this.RPCSettingsTab.Controls.Add(this.SmallImageTooltipText);
            this.RPCSettingsTab.Controls.Add(this.SmallImageTooltipLabel);
            this.RPCSettingsTab.Controls.Add(this.SmallImageKeyLabel);
            this.RPCSettingsTab.Controls.Add(this.SmallImageKeyText);
            this.RPCSettingsTab.Controls.Add(this.LargeImageTooltipText);
            this.RPCSettingsTab.Controls.Add(this.LargeImageTooltipLabel);
            this.RPCSettingsTab.Controls.Add(this.LargeImageKeyText);
            this.RPCSettingsTab.Controls.Add(this.LargeImageKeyLabel);
            this.RPCSettingsTab.Location = new System.Drawing.Point(4, 29);
            this.RPCSettingsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RPCSettingsTab.Name = "RPCSettingsTab";
            this.RPCSettingsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RPCSettingsTab.Size = new System.Drawing.Size(625, 251);
            this.RPCSettingsTab.TabIndex = 1;
            this.RPCSettingsTab.Text = "Settings";
            this.RPCSettingsTab.UseVisualStyleBackColor = true;
            // 
            // DetailsText
            // 
            this.DetailsText.AccessibleName = "DetailsText";
            this.DetailsText.Location = new System.Drawing.Point(73, 83);
            this.DetailsText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.Size = new System.Drawing.Size(210, 27);
            this.DetailsText.TabIndex = 12;
            this.DetailsText.TextChanged += new System.EventHandler(this.DetailsText_TextChanged);
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AccessibleName = "DetailsLabel";
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(9, 86);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(58, 20);
            this.DetailsLabel.TabIndex = 11;
            this.DetailsLabel.Text = "Details:";
            // 
            // StateText
            // 
            this.StateText.AccessibleName = "StateText";
            this.StateText.Location = new System.Drawing.Point(341, 83);
            this.StateText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(273, 27);
            this.StateText.TabIndex = 10;
            this.StateText.TextChanged += new System.EventHandler(this.StateText_TextChanged);
            // 
            // StateLabel
            // 
            this.StateLabel.AccessibleName = "StateLabel";
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(289, 89);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(46, 20);
            this.StateLabel.TabIndex = 7;
            this.StateLabel.Text = "State:";
            // 
            // SmallImageTooltipText
            // 
            this.SmallImageTooltipText.AccessibleName = "SmallImageTooltipText";
            this.SmallImageTooltipText.Location = new System.Drawing.Point(465, 48);
            this.SmallImageTooltipText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SmallImageTooltipText.Name = "SmallImageTooltipText";
            this.SmallImageTooltipText.Size = new System.Drawing.Size(149, 27);
            this.SmallImageTooltipText.TabIndex = 9;
            this.SmallImageTooltipText.TextChanged += new System.EventHandler(this.SmallImageTooltipText_TextChanged);
            // 
            // SmallImageTooltipLabel
            // 
            this.SmallImageTooltipLabel.AccessibleName = "SmallImageTooltipLabel";
            this.SmallImageTooltipLabel.AutoSize = true;
            this.SmallImageTooltipLabel.Location = new System.Drawing.Point(289, 51);
            this.SmallImageTooltipLabel.Name = "SmallImageTooltipLabel";
            this.SmallImageTooltipLabel.Size = new System.Drawing.Size(170, 20);
            this.SmallImageTooltipLabel.TabIndex = 7;
            this.SmallImageTooltipLabel.Text = "Small Image Hover Text:";
            // 
            // SmallImageKeyLabel
            // 
            this.SmallImageKeyLabel.AccessibleName = "SmallImageKeyLabel";
            this.SmallImageKeyLabel.AutoSize = true;
            this.SmallImageKeyLabel.Location = new System.Drawing.Point(9, 51);
            this.SmallImageKeyLabel.Name = "SmallImageKeyLabel";
            this.SmallImageKeyLabel.Size = new System.Drawing.Size(139, 20);
            this.SmallImageKeyLabel.TabIndex = 8;
            this.SmallImageKeyLabel.Text = "Small Image Name:";
            // 
            // SmallImageKeyText
            // 
            this.SmallImageKeyText.AccessibleName = "SmallImageKeyText";
            this.SmallImageKeyText.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.SmallImageKeyText.Location = new System.Drawing.Point(154, 48);
            this.SmallImageKeyText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SmallImageKeyText.Name = "SmallImageKeyText";
            this.SmallImageKeyText.Size = new System.Drawing.Size(129, 27);
            this.SmallImageKeyText.TabIndex = 7;
            this.SmallImageKeyText.TextChanged += new System.EventHandler(this.SmallImageKeyText_TextChanged);
            // 
            // LargeImageTooltipText
            // 
            this.LargeImageTooltipText.AccessibleName = "LargeImageTooltipText";
            this.LargeImageTooltipText.Location = new System.Drawing.Point(465, 9);
            this.LargeImageTooltipText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LargeImageTooltipText.Name = "LargeImageTooltipText";
            this.LargeImageTooltipText.Size = new System.Drawing.Size(149, 27);
            this.LargeImageTooltipText.TabIndex = 3;
            this.LargeImageTooltipText.TextChanged += new System.EventHandler(this.LargeImageTooltipText_TextChanged);
            // 
            // LargeImageTooltipLabel
            // 
            this.LargeImageTooltipLabel.AccessibleName = "LargeImageTooltipLabel";
            this.LargeImageTooltipLabel.AutoSize = true;
            this.LargeImageTooltipLabel.Location = new System.Drawing.Point(289, 12);
            this.LargeImageTooltipLabel.Name = "LargeImageTooltipLabel";
            this.LargeImageTooltipLabel.Size = new System.Drawing.Size(170, 20);
            this.LargeImageTooltipLabel.TabIndex = 2;
            this.LargeImageTooltipLabel.Text = "Large Image Hover Text:";
            // 
            // LargeImageKeyText
            // 
            this.LargeImageKeyText.AccessibleName = "LargeImageKeyText";
            this.LargeImageKeyText.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.LargeImageKeyText.Location = new System.Drawing.Point(154, 9);
            this.LargeImageKeyText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LargeImageKeyText.Name = "LargeImageKeyText";
            this.LargeImageKeyText.Size = new System.Drawing.Size(129, 27);
            this.LargeImageKeyText.TabIndex = 1;
            this.LargeImageKeyText.TextChanged += new System.EventHandler(this.LargeImageKeyText_TextChanged);
            // 
            // LargeImageKeyLabel
            // 
            this.LargeImageKeyLabel.AccessibleName = "LargeImageKeyLabel";
            this.LargeImageKeyLabel.AutoSize = true;
            this.LargeImageKeyLabel.Location = new System.Drawing.Point(9, 12);
            this.LargeImageKeyLabel.Name = "LargeImageKeyLabel";
            this.LargeImageKeyLabel.Size = new System.Drawing.Size(139, 20);
            this.LargeImageKeyLabel.TabIndex = 0;
            this.LargeImageKeyLabel.Text = "Large Image Name:";
            // 
            // RPCLogTab
            // 
            this.RPCLogTab.AccessibleName = "RPCLogTab";
            this.RPCLogTab.Controls.Add(this.LogText);
            this.RPCLogTab.Location = new System.Drawing.Point(4, 29);
            this.RPCLogTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RPCLogTab.Name = "RPCLogTab";
            this.RPCLogTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RPCLogTab.Size = new System.Drawing.Size(625, 251);
            this.RPCLogTab.TabIndex = 2;
            this.RPCLogTab.Text = "Log";
            this.RPCLogTab.UseVisualStyleBackColor = true;
            // 
            // LogText
            // 
            this.LogText.AccessibleName = "LogText";
            this.LogText.Location = new System.Drawing.Point(0, 0);
            this.LogText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(598, 241);
            this.LogText.TabIndex = 0;
            this.LogText.Text = "Booted application.";
            // 
            // ConnectionGroup
            // 
            this.ConnectionGroup.AccessibleName = "ConnectionGroup";
            this.ConnectionGroup.Controls.Add(this.SyncButton);
            this.ConnectionGroup.Controls.Add(this.ClientIDNumeric);
            this.ConnectionGroup.Controls.Add(this.ConnectButton);
            this.ConnectionGroup.Controls.Add(this.ClientIDLabel);
            this.ConnectionGroup.Location = new System.Drawing.Point(400, 292);
            this.ConnectionGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectionGroup.Name = "ConnectionGroup";
            this.ConnectionGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectionGroup.Size = new System.Drawing.Size(229, 108);
            this.ConnectionGroup.TabIndex = 5;
            this.ConnectionGroup.TabStop = false;
            this.ConnectionGroup.Text = "Connection";
            // 
            // SyncButton
            // 
            this.SyncButton.AccessibleName = "SyncButton";
            this.SyncButton.Enabled = false;
            this.SyncButton.Location = new System.Drawing.Point(136, 68);
            this.SyncButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(86, 31);
            this.SyncButton.TabIndex = 4;
            this.SyncButton.Text = "Sync";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // StatusGroup
            // 
            this.StatusGroup.AccessibleName = "StatusGroup";
            this.StatusGroup.Controls.Add(this.TaskBarCheckBox);
            this.StatusGroup.Controls.Add(this.StatusConnectionText);
            this.StatusGroup.Controls.Add(this.StatusConnectionLabel);
            this.StatusGroup.Location = new System.Drawing.Point(5, 292);
            this.StatusGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusGroup.Name = "StatusGroup";
            this.StatusGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusGroup.Size = new System.Drawing.Size(389, 108);
            this.StatusGroup.TabIndex = 6;
            this.StatusGroup.TabStop = false;
            this.StatusGroup.Text = "Status";
            // 
            // TaskBarCheckBox
            // 
            this.TaskBarCheckBox.AccessibleName = "TaskBarCheckBox";
            this.TaskBarCheckBox.AutoSize = true;
            this.TaskBarCheckBox.Checked = true;
            this.TaskBarCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TaskBarCheckBox.Location = new System.Drawing.Point(243, 21);
            this.TaskBarCheckBox.Name = "TaskBarCheckBox";
            this.TaskBarCheckBox.Size = new System.Drawing.Size(140, 24);
            this.TaskBarCheckBox.TabIndex = 13;
            this.TaskBarCheckBox.Text = "Show on taskbar";
            this.TaskBarCheckBox.UseVisualStyleBackColor = true;
            this.TaskBarCheckBox.CheckedChanged += new System.EventHandler(this.TaskBarCheckBox_CheckedChanged);
            // 
            // StatusConnectionText
            // 
            this.StatusConnectionText.AccessibleName = "StatusConnectionText";
            this.StatusConnectionText.AutoSize = true;
            this.StatusConnectionText.ForeColor = System.Drawing.Color.Red;
            this.StatusConnectionText.Location = new System.Drawing.Point(98, 25);
            this.StatusConnectionText.Name = "StatusConnectionText";
            this.StatusConnectionText.Size = new System.Drawing.Size(99, 20);
            this.StatusConnectionText.TabIndex = 8;
            this.StatusConnectionText.Text = "Disconnected";
            // 
            // StatusConnectionLabel
            // 
            this.StatusConnectionLabel.AccessibleName = "StatusConnectionLabel";
            this.StatusConnectionLabel.AutoSize = true;
            this.StatusConnectionLabel.Location = new System.Drawing.Point(9, 25);
            this.StatusConnectionLabel.Name = "StatusConnectionLabel";
            this.StatusConnectionLabel.Size = new System.Drawing.Size(87, 20);
            this.StatusConnectionLabel.TabIndex = 7;
            this.StatusConnectionLabel.Text = "Connection:";
            // 
            // Main
            // 
            this.AccessibleName = "Main";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 409);
            this.Controls.Add(this.StatusGroup);
            this.Controls.Add(this.ConnectionGroup);
            this.Controls.Add(this.RPCTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "DiscordRPC";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientIDNumeric)).EndInit();
            this.RPCTabControl.ResumeLayout(false);
            this.RPCSettingsTab.ResumeLayout(false);
            this.RPCSettingsTab.PerformLayout();
            this.RPCLogTab.ResumeLayout(false);
            this.ConnectionGroup.ResumeLayout(false);
            this.ConnectionGroup.PerformLayout();
            this.StatusGroup.ResumeLayout(false);
            this.StatusGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.NumericUpDown ClientIDNumeric;
        private System.Windows.Forms.Label ClientIDLabel;
        private System.Windows.Forms.TabControl RPCTabControl;
        private System.Windows.Forms.TabPage RPCSettingsTab;
        private System.Windows.Forms.TabPage RPCLogTab;
        private System.Windows.Forms.RichTextBox LogText;
        private System.Windows.Forms.GroupBox ConnectionGroup;
        private System.Windows.Forms.GroupBox StatusGroup;
        private System.Windows.Forms.Label StatusConnectionText;
        private System.Windows.Forms.Label StatusConnectionLabel;
        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.Label LargeImageKeyLabel;
        private System.Windows.Forms.Label SmallImageKeyLabel;
        private System.Windows.Forms.TextBox SmallImageKeyText;
        private System.Windows.Forms.TextBox LargeImageTooltipText;
        private System.Windows.Forms.Label LargeImageTooltipLabel;
        private System.Windows.Forms.TextBox LargeImageKeyText;
        private System.Windows.Forms.TextBox SmallImageTooltipText;
        private System.Windows.Forms.Label SmallImageTooltipLabel;
        private System.Windows.Forms.TextBox DetailsText;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.TextBox StateText;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.CheckBox TaskBarCheckBox;
    }
}

