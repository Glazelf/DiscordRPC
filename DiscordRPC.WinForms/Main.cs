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
        
        bool runActivity;
        bool threadRunning;

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                ClientIDNumeric.Value = Settings.Default.ClientID;
                LargeImageKeyText.Text = Settings.Default.LargeImageAssetKey;
                LargeImageTooltipText.Text = Settings.Default.LargeImageTooltip;
                SmallImageKeyText.Text = Settings.Default.SmallImageAssetKey;
                SmallImageTooltipText.Text = Settings.Default.SmallImageTooltip;
                DetailsText.Text = Settings.Default.Details;
                StateText.Text = Settings.Default.State;
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        bool ConnectedBool = false;

        private void ConnectButton_Click(object sender, EventArgs e)
        {
                try
                {
                    discord = new Discord.Discord((long)ClientIDNumeric.Value, (ulong)Discord.CreateFlags.Default);
                    activityManager = discord.GetActivityManager();
                    discord.SetLogHook(Discord.LogLevel.Debug, LogProblemsFunction);
                    SetActivity();
                }
                catch (Exception ex)
                {
                    LogError(ex);
                }
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetActivity();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
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
            ConnectButton.Enabled = false;
            ConnectedBool = true;
        }

        public void SetActivity()
        {
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
                    Timestamps =
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
                    Instance = false,
                };

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
                        LogText.Text += Environment.NewLine + "Failed to connect.";
                        LogText.Text += Environment.NewLine + $"Discord response: {Convert.ToString(result)}";
                    }
                });
                runActivity = true;

                if (threadRunning == false)
                {
                    threadRunning = true;
                    ThreadPool.QueueUserWorkItem(EventLoop);
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        public void EventLoop(object threadContext)
        {
            try
            {
                while (runActivity == true)
                {
                    discord.RunCallbacks();
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
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

        public void LogError(Exception ex)
        {
            LogText.Text += Environment.NewLine + $"Error: {ex.Message}\n{ex.StackTrace}";
        }
    }
}
