﻿
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
            this.ConnectButton.Location = new System.Drawing.Point(25, 64);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ClientIDNumeric
            // 
            this.ClientIDNumeric.AccessibleName = "ClientIDNumeric";
            this.ClientIDNumeric.Location = new System.Drawing.Point(64, 37);
            this.ClientIDNumeric.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.ClientIDNumeric.Name = "ClientIDNumeric";
            this.ClientIDNumeric.Size = new System.Drawing.Size(130, 23);
            this.ClientIDNumeric.TabIndex = 2;
            this.ClientIDNumeric.ValueChanged += new System.EventHandler(this.ClientIDNumeric_ValueChanged);
            // 
            // ClientIDLabel
            // 
            this.ClientIDLabel.AccessibleName = "ClientIDLabel";
            this.ClientIDLabel.AutoSize = true;
            this.ClientIDLabel.Location = new System.Drawing.Point(3, 39);
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
            this.RPCTabControl.Size = new System.Drawing.Size(528, 213);
            this.RPCTabControl.TabIndex = 4;
            // 
            // RPCSettingsTab
            // 
            this.RPCSettingsTab.AccessibleName = "RPCSettingsTab";
            this.RPCSettingsTab.Controls.Add(this.SmallImageTooltipText);
            this.RPCSettingsTab.Controls.Add(this.SmallImageTooltipLabel);
            this.RPCSettingsTab.Controls.Add(this.SmallImageKeyLabel);
            this.RPCSettingsTab.Controls.Add(this.SmallImageKeyText);
            this.RPCSettingsTab.Controls.Add(this.LargeImageTooltipText);
            this.RPCSettingsTab.Controls.Add(this.LargeImageTooltipLabel);
            this.RPCSettingsTab.Controls.Add(this.LargeImageKeyText);
            this.RPCSettingsTab.Controls.Add(this.LargeImageKeyLabel);
            this.RPCSettingsTab.Location = new System.Drawing.Point(4, 24);
            this.RPCSettingsTab.Name = "RPCSettingsTab";
            this.RPCSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.RPCSettingsTab.Size = new System.Drawing.Size(520, 185);
            this.RPCSettingsTab.TabIndex = 1;
            this.RPCSettingsTab.Text = "Settings";
            this.RPCSettingsTab.UseVisualStyleBackColor = true;
            // 
            // SmallImageTooltipText
            // 
            this.SmallImageTooltipText.AccessibleName = "SmallImageTooltipText";
            this.SmallImageTooltipText.Location = new System.Drawing.Point(363, 35);
            this.SmallImageTooltipText.Name = "SmallImageTooltipText";
            this.SmallImageTooltipText.Size = new System.Drawing.Size(151, 23);
            this.SmallImageTooltipText.TabIndex = 9;
            // 
            // SmallImageTooltipLabel
            // 
            this.SmallImageTooltipLabel.AccessibleName = "SmallImageTooltipLabel";
            this.SmallImageTooltipLabel.AutoSize = true;
            this.SmallImageTooltipLabel.Location = new System.Drawing.Point(243, 38);
            this.SmallImageTooltipLabel.Name = "SmallImageTooltipLabel";
            this.SmallImageTooltipLabel.Size = new System.Drawing.Size(114, 15);
            this.SmallImageTooltipLabel.TabIndex = 7;
            this.SmallImageTooltipLabel.Text = "Small Image Tooltip:";
            // 
            // SmallImageKeyLabel
            // 
            this.SmallImageKeyLabel.AccessibleName = "SmallImageKeyLabel";
            this.SmallImageKeyLabel.AutoSize = true;
            this.SmallImageKeyLabel.Location = new System.Drawing.Point(8, 38);
            this.SmallImageKeyLabel.Name = "SmallImageKeyLabel";
            this.SmallImageKeyLabel.Size = new System.Drawing.Size(128, 15);
            this.SmallImageKeyLabel.TabIndex = 8;
            this.SmallImageKeyLabel.Text = "Small Image Asset Key:";
            // 
            // SmallImageKeyText
            // 
            this.SmallImageKeyText.AccessibleName = "SmallImageKeyText";
            this.SmallImageKeyText.Location = new System.Drawing.Point(137, 35);
            this.SmallImageKeyText.Name = "SmallImageKeyText";
            this.SmallImageKeyText.Size = new System.Drawing.Size(100, 23);
            this.SmallImageKeyText.TabIndex = 7;
            // 
            // LargeImageTooltipText
            // 
            this.LargeImageTooltipText.AccessibleName = "LargeImageTooltipText";
            this.LargeImageTooltipText.Location = new System.Drawing.Point(363, 6);
            this.LargeImageTooltipText.Name = "LargeImageTooltipText";
            this.LargeImageTooltipText.Size = new System.Drawing.Size(151, 23);
            this.LargeImageTooltipText.TabIndex = 3;
            // 
            // LargeImageTooltipLabel
            // 
            this.LargeImageTooltipLabel.AccessibleName = "LargeImageTooltipLabel";
            this.LargeImageTooltipLabel.AutoSize = true;
            this.LargeImageTooltipLabel.Location = new System.Drawing.Point(243, 9);
            this.LargeImageTooltipLabel.Name = "LargeImageTooltipLabel";
            this.LargeImageTooltipLabel.Size = new System.Drawing.Size(114, 15);
            this.LargeImageTooltipLabel.TabIndex = 2;
            this.LargeImageTooltipLabel.Text = "Large Image Tooltip:";
            // 
            // LargeImageKeyText
            // 
            this.LargeImageKeyText.AccessibleName = "LargeImageKeyText";
            this.LargeImageKeyText.Location = new System.Drawing.Point(137, 6);
            this.LargeImageKeyText.Name = "LargeImageKeyText";
            this.LargeImageKeyText.Size = new System.Drawing.Size(100, 23);
            this.LargeImageKeyText.TabIndex = 1;
            // 
            // LargeImageKeyLabel
            // 
            this.LargeImageKeyLabel.AccessibleName = "LargeImageKeyLabel";
            this.LargeImageKeyLabel.AutoSize = true;
            this.LargeImageKeyLabel.Location = new System.Drawing.Point(8, 9);
            this.LargeImageKeyLabel.Name = "LargeImageKeyLabel";
            this.LargeImageKeyLabel.Size = new System.Drawing.Size(128, 15);
            this.LargeImageKeyLabel.TabIndex = 0;
            this.LargeImageKeyLabel.Text = "Large Image Asset Key:";
            // 
            // RPCLogTab
            // 
            this.RPCLogTab.AccessibleName = "RPCLogTab";
            this.RPCLogTab.Controls.Add(this.LogText);
            this.RPCLogTab.Location = new System.Drawing.Point(4, 24);
            this.RPCLogTab.Name = "RPCLogTab";
            this.RPCLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.RPCLogTab.Size = new System.Drawing.Size(520, 185);
            this.RPCLogTab.TabIndex = 2;
            this.RPCLogTab.Text = "Log";
            this.RPCLogTab.UseVisualStyleBackColor = true;
            // 
            // LogText
            // 
            this.LogText.AccessibleName = "LogText";
            this.LogText.Location = new System.Drawing.Point(0, 0);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(524, 325);
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
            this.ConnectionGroup.Location = new System.Drawing.Point(324, 219);
            this.ConnectionGroup.Name = "ConnectionGroup";
            this.ConnectionGroup.Size = new System.Drawing.Size(200, 100);
            this.ConnectionGroup.TabIndex = 5;
            this.ConnectionGroup.TabStop = false;
            this.ConnectionGroup.Text = "Connection";
            // 
            // SyncButton
            // 
            this.SyncButton.AccessibleName = "SyncButton";
            this.SyncButton.Enabled = false;
            this.SyncButton.Location = new System.Drawing.Point(106, 64);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size(75, 23);
            this.SyncButton.TabIndex = 4;
            this.SyncButton.Text = "Sync";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // StatusGroup
            // 
            this.StatusGroup.AccessibleName = "StatusGroup";
            this.StatusGroup.Controls.Add(this.StatusConnectionText);
            this.StatusGroup.Controls.Add(this.StatusConnectionLabel);
            this.StatusGroup.Location = new System.Drawing.Point(4, 219);
            this.StatusGroup.Name = "StatusGroup";
            this.StatusGroup.Size = new System.Drawing.Size(314, 100);
            this.StatusGroup.TabIndex = 6;
            this.StatusGroup.TabStop = false;
            this.StatusGroup.Text = "Status";
            // 
            // StatusConnectionText
            // 
            this.StatusConnectionText.AccessibleName = "StatusConnectionText";
            this.StatusConnectionText.AutoSize = true;
            this.StatusConnectionText.ForeColor = System.Drawing.Color.Red;
            this.StatusConnectionText.Location = new System.Drawing.Point(86, 19);
            this.StatusConnectionText.Name = "StatusConnectionText";
            this.StatusConnectionText.Size = new System.Drawing.Size(79, 15);
            this.StatusConnectionText.TabIndex = 8;
            this.StatusConnectionText.Text = "Disconnected";
            // 
            // StatusConnectionLabel
            // 
            this.StatusConnectionLabel.AccessibleName = "StatusConnectionLabel";
            this.StatusConnectionLabel.AutoSize = true;
            this.StatusConnectionLabel.Location = new System.Drawing.Point(8, 19);
            this.StatusConnectionLabel.Name = "StatusConnectionLabel";
            this.StatusConnectionLabel.Size = new System.Drawing.Size(72, 15);
            this.StatusConnectionLabel.TabIndex = 7;
            this.StatusConnectionLabel.Text = "Connection:";
            // 
            // Main
            // 
            this.AccessibleName = "Main";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 324);
            this.Controls.Add(this.StatusGroup);
            this.Controls.Add(this.ConnectionGroup);
            this.Controls.Add(this.RPCTabControl);
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
    }
}

