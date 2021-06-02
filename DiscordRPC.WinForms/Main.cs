using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiscordRPC.WinForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        bool ConnectedBool = false;
        long ClientID = Settings.Default.ClientID;

        private void Main_Load(object sender, EventArgs e)
        {
            ClientIDNumeric.Value = Settings.Default.ClientID;
        }

        private void ConnectButton_Click(object sender, System.EventArgs e)
        {
            if (ConnectedBool == false)
            {
                /*
                Grab that Client ID from earlier
                Discord.CreateFlags.Default will require Discord to be running for the game to work
                If Discord is not running, it will:
                1. Close your game
                2. Open Discord
                3. Attempt to re-open your game
                Step 3 may fail when running directly from your editor
                Therefore, always keep Discord running during tests, or use Discord.CreateFlags.NoRequireDiscord
                */
                var discord = new Discord.Discord(ClientID, (UInt64)Discord.CreateFlags.Default);
                var activityManager = discord.GetActivityManager();


                var activity = new Discord.Activity
                {
                    State = "RPC test",
                    Details = "wowzer it works",
                    Timestamps =
                {
                    Start = 5,
                },
                };

                // Doesn't seem to get executed?
                activityManager.UpdateActivity(activity, (result) =>
                {
                    if (result == Discord.Result.Ok)
                    {
                        SyncButton.Enabled = true;
                        ClientIDNumeric.Enabled = false;
                        StatusConnectionText.ForeColor = Color.Green;
                        StatusConnectionText.Text = "Connected";
                        ConnectButton.Text = "Disconnect";
                        ConnectedBool = true;
                        LogText.Text += Environment.NewLine + "Successfully connected.";
                        LogText.Text += Environment.NewLine + Convert.ToString(result);
                    }
                    else
                    {
                        SyncButton.Enabled = false;
                        ClientIDNumeric.Enabled = true;
                        StatusConnectionText.ForeColor = Color.Red;
                        StatusConnectionText.Text = "Disconnected";
                        ConnectButton.Text = "Connect";
                        ConnectedBool = false;
                        LogText.Text += Environment.NewLine + "Failed to connect.";
                        LogText.Text += Environment.NewLine + Convert.ToString(result);
                    }
                });
            }
        }

        private void ClientIDNumeric_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.ClientID = (long)ClientIDNumeric.Value;
            Settings.Default.Save();
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {

        }
    }
}
