
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
            ((System.ComponentModel.ISupportInitialize)(this.ClientIDNumeric)).BeginInit();
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
            this.ClientIDNumeric.Location = new System.Drawing.Point(668, 355);
            this.ClientIDNumeric.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.ClientIDNumeric.Name = "ClientIDNumeric";
            this.ClientIDNumeric.Size = new System.Drawing.Size(120, 23);
            this.ClientIDNumeric.TabIndex = 2;
            this.ClientIDNumeric.ValueChanged += new System.EventHandler(this.ClientIDNumeric_ValueChanged);
            // 
            // ClientIDLabel
            // 
            this.ClientIDLabel.AccessibleName = "ClientIDLabel";
            this.ClientIDLabel.AutoSize = true;
            this.ClientIDLabel.Location = new System.Drawing.Point(607, 357);
            this.ClientIDLabel.Name = "ClientIDLabel";
            this.ClientIDLabel.Size = new System.Drawing.Size(55, 15);
            this.ClientIDLabel.TabIndex = 3;
            this.ClientIDLabel.Text = "Client ID:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientIDLabel);
            this.Controls.Add(this.ClientIDNumeric);
            this.Controls.Add(this.ConnectButon);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientIDNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButon;
        private System.Windows.Forms.NumericUpDown ClientIDNumeric;
        private System.Windows.Forms.Label ClientIDLabel;
    }
}

