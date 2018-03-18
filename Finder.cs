using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BlueholeSucks
{
    public partial class Finder : Form
    {
        private Timer Count;

        public Finder()
        {
            InitializeComponent();
            string[] Messages =
            {
                "Blue 'fun and banned go hand in hand' Hole",
                "Blue 'run a script and you get ript' Hole",
                "Blue 'battle eye will make you cry' Hole",
                "Blue 'bans our fans' Hole",
                "Blue 'quite the fan? have a ban' Hole",
                "Blue 'fun with a friend? that will end' Hole"
            };
            Random rng = new Random();
            this.Text = Messages[rng.Next(Messages.Length)];
        }

        private void Finder_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ShouldCloseWhenSuccess)
            {
                HideOnSuccessTick.Checked = true;
            }
            RetryButton.Hide();
            SetMessage("Looking for Path of Exile Process...");
            SetStatus("Searching...");
            if (PathofExileIsPresent())
            {
                Count = new Timer();
                
                // Every 3.5 seconds check if POE has closed.
                // I'd rather poll and be safe than to hook into POE's process and get banned there too...
                Count.Interval = 3500;
                Count.Tick += CheckPathofExile;

                Count.Start();

                SetMessage("Found Path of Exile.\nStarting Trade Script");

                try
                {
                    SetStatus("Working!");
                    Process.Start("Run_TradeMacro.ahk");
                }
                catch
                {
                    SetMessage("It seems you havent placed this .exe\nNext to Run_TradeMacro.ahk.");
                    Count.Dispose();
                    Count = null;
                    RetryButton.Show();
                    SetStatus("Failed to find Run_TradeMacro.ahk!");
                }
            }
            else
            {
                SetStatus("You are not playing Path of Exile.");
                SetMessage("Could not find Path of Exile. \n Start the game then retry.");
                RetryButton.Show();
            }
                
        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            Finder_Load(sender, e);
        }

        // When hide on success is ticked, toggle its check and store the updated setting.
        private void AutoHideOnSuccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShouldCloseWhenSuccess = !Properties.Settings.Default.ShouldCloseWhenSuccess;
            if (Properties.Settings.Default.ShouldCloseWhenSuccess)
                HideOnSuccessTick.Checked = true;
            else
                HideOnSuccessTick.Checked = false;
            Properties.Settings.Default.Save();
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            PopupFromTray();
        }

        private void HideGUIButton_Click(object sender, EventArgs e)
        {
            MinimizeToTray();
        }
    }
}
