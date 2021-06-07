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

        Discord.Discord discord;
        Discord.ActivityManager activityManager;

        private void Main_Load(object sender, EventArgs e)
        {
            ClientIDNumeric.Value = Settings.Default.ClientID;
        }

        bool ConnectedBool = false;
        long ClientID = Settings.Default.ClientID;

        private void ConnectButton_Click(object sender, System.EventArgs e)
        {
            ClientID = (long)ClientIDNumeric.Value;
            if (ConnectedBool == false)
            {
                discord = new Discord.Discord(ClientID, (ulong)Discord.CreateFlags.Default);
                activityManager = discord.GetActivityManager();
                discord.SetLogHook(Discord.LogLevel.Debug, LogProblemsFunction);
                var activity = new Discord.Activity
                {
                    State = "RPC test",
                    Details = "wowzer it works",
                    Timestamps =
                    {
                        Start = 5,
                    },
                    /*
                    Assets =
                    {
                        LargeImage = "foo largeImageKey", // Larger Image Asset Key
                        LargeText = "foo largeImageText", // Large Image Tooltip
                        SmallImage = "foo smallImageKey", // Small Image Asset Key
                        SmallText = "foo smallImageText", // Small Image Tooltip
                    },
                    Party =
                    {
                        Id = "foo partyID",
                        Size = {
                            CurrentSize = 1,
                            MaxSize = 4,
                        },
                    },
                    Secrets =
                    {
                        Match = "foo matchSecret",
                        Join = "foo joinSecret",
                        Spectate = "foo spectateSecret",
                    },
                    */
                    Instance = true,
                };

                // Doesn't seem to get executed?
                activityManager.UpdateActivity(activity, (result) =>
                {
                    if (result == Discord.Result.Ok)
                    {
                        ChangeStateConnected();
                        LogText.Text += Environment.NewLine + "Successfully connected.";
                        LogText.Text += Environment.NewLine + Convert.ToString(result);
                    }
                    else
                    {
                        ChangeStateDisconnected();
                        LogText.Text += Environment.NewLine + "Failed to connect.";
                        LogText.Text += Environment.NewLine + Convert.ToString(result);
                    }
                });
            }
            else
            {
                activityManager.ClearActivity((result) =>
                {
                    if (result == Discord.Result.Ok)
                    {
                        LogText.Text += Environment.NewLine + "Cleared activity.";
                    }
                    else
                    {
                        LogText.Text += Environment.NewLine + "Failed to clear activity.";
                    }
                });
                discord.Dispose();
                ChangeStateDisconnected();
                LogText.Text += Environment.NewLine + "Disconnected.";
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
        public void LogProblemsFunction(Discord.LogLevel level, string message)
        {
            LogText.Text += Environment.NewLine + $"Discord:{level} - {message}";
        }

        public void ChangeStateConnected()
        {
            ConnectButton.Enabled = false;
            SyncButton.Enabled = true;
            ClientIDNumeric.Enabled = false;
            StatusConnectionText.ForeColor = Color.Green;
            StatusConnectionText.Text = "Connected";
            ConnectButton.Text = "Disconnect";
            ConnectedBool = true;
        }

        public void ChangeStateDisconnected()
        {
            ConnectButton.Enabled = true;
            SyncButton.Enabled = false;
            ClientIDNumeric.Enabled = true;
            StatusConnectionText.ForeColor = Color.Red;
            StatusConnectionText.Text = "Disconnected";
            ConnectButton.Text = "Connect";
            ConnectedBool = false;

        }
    }
}
