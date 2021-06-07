using System;
using System.Drawing;
using System.Threading;
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
        Thread t;

        private void Main_Load(object sender, EventArgs e)
        {
            ClientIDNumeric.Value = Settings.Default.ClientID;
            LargeImageKeyText.Text = Settings.Default.LargeImageAssetKey;
            LargeImageTooltipText.Text = Settings.Default.LargeImageTooltip;
            SmallImageKeyText.Text = Settings.Default.SmallImageAssetKey;
            SmallImageTooltipText.Text = Settings.Default.SmallImageTooltip;
            DetailsText.Text = Settings.Default.Details;
            StateText.Text = Settings.Default.State;
            t = new Thread(EventLoop);
        }

        bool ConnectedBool = false;

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ConnectedBool == false)
            {
                discord = new Discord.Discord((long)ClientIDNumeric.Value, (ulong)Discord.CreateFlags.Default);
                activityManager = discord.GetActivityManager();
                discord.SetLogHook(Discord.LogLevel.Debug, LogProblemsFunction);
                if(t.IsAlive != true)
                {
                    t.Start();
                }

                try
                {
                    var activity = new Discord.Activity
                    {
                        State = StateText.Text,
                        Details = DetailsText.Text,
                        Assets =
                        {
                            LargeImage = LargeImageKeyText.Text, // Larger Image Asset Key
                            LargeText = LargeImageTooltipText.Text, // Large Image Tooltip
                            SmallImage = SmallImageKeyText.Text, // Small Image Asset Key
                            SmallText = SmallImageTooltipText.Text, // Small Image Tooltip
                        },
                        /*
                         * Timestamps =
                        {
                            Start = 1,
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
                            LogText.Text += Environment.NewLine + $"Discord response: {Convert.ToString(result)}";
                        }
                        else
                        {
                            ChangeStateDisconnected();
                            LogText.Text += Environment.NewLine + "Failed to connect.";
                            LogText.Text += Environment.NewLine + $"Discord response: {Convert.ToString(result)}";
                        }
                    });
                } catch (Exception exception)
                {
                    LogText.Text += Environment.NewLine + "Error occurred while using your settings to create an activity.";
                    LogText.Text += Environment.NewLine + $"Error: {exception}";
                }
            }
            else
            {
                try
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
                } catch (Exception exception)
                {
                    LogText.Text += Environment.NewLine + "Error occurred while clearing activity.";
                    LogText.Text += Environment.NewLine + $"Error: {exception}";
                }

                // Thread.Abort is not supported in .Net 5.0 anymore, should find a better way to do this
                // t.Abort();
                
                ChangeStateDisconnected();
                LogText.Text += Environment.NewLine + "Disconnected.";
            }
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
        public void EventLoop()
        {
            while (true)
            {
                MethodInvoker mi = delegate () { 
                    discord.RunCallbacks(); 
                };
                Invoke(mi);
            }
        }

        private void ClientIDNumeric_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.ClientID = (long)ClientIDNumeric.Value;
            Settings.Default.Save();
        }

        private void LargeImageKeyText_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.LargeImageAssetKey = LargeImageKeyText.Text;
            Settings.Default.Save();
        }

        private void LargeImageTooltipText_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.LargeImageTooltip = LargeImageTooltipText.Text;
            Settings.Default.Save();
        }

        private void SmallImageKeyText_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.SmallImageAssetKey = SmallImageKeyText.Text;
            Settings.Default.Save();
        }

        private void SmallImageTooltipText_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.SmallImageTooltip = SmallImageTooltipText.Text;
            Settings.Default.Save();
        }

        private void DetailsText_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Details = DetailsText.Text;
            Settings.Default.Save();
        }

        private void StateText_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.State = StateText.Text;
            Settings.Default.Save();
        }
    }
}
