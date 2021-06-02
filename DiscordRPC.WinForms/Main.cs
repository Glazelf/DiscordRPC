using System;
using System.Windows.Forms;

namespace DiscordRPC.WinForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }
        long ClientID = Settings.Default.ClientID;

        private void Main_Load(object sender, EventArgs e)
        {
            ClientIDNumeric.Value = Settings.Default.ClientID;
        }

        private void ConnectButton_Click(object sender, System.EventArgs e)
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
        }

        private void ClientIDNumeric_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.ClientID = (long)ClientIDNumeric.Value;
            Settings.Default.Save();
        }
    }
}
