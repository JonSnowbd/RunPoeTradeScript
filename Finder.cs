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
            RetryButton.Hide();
            SetMessage("Looking for Path of Exile Process...");
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
                     Process.Start("Run_TradeMacro.ahk");
                }
                catch
                {
                    SetMessage("It seems you havent placed this .exe\nNext to Run_TradeMacro.ahk.");
                    Count.Dispose();
                    Count = null;
                    RetryButton.Show();
                }
            }
            else
            {
                SetMessage("Could not find Path of Exile. \n Start the game then retry.");
                RetryButton.Show();
            }
                
        }

        private void SetMessage(string msg)
        {
            StatusMessage.Text = msg;
            StatusMessage.Top = (this.ClientSize.Height - StatusMessage.Height) / 2;
            StatusMessage.Left = (this.ClientSize.Width - StatusMessage.Width) / 2;
        }

        private bool PathofExileIsPresent()
        {
            Process[] L = Process.GetProcessesByName("PathOfExile");
            if (L.Length == 0)
                return false;
            else
                return true;
        }

        // Iters tracks how many polls have been done so far
        // Checks for path of exile. If it's ever not found(ran from a Timer), disposes everything.
        // And kills ahk.
        private int iters = 0;
        private void CheckPathofExile(object sender, EventArgs e)
        {
            if (!PathofExileIsPresent())
            {
                Count.Stop();
                Count.Dispose();
                KillAHK();
                Application.Exit();
                return;
            }
            iters++;
            IterationLabel.Text = "iter " + iters.ToString();
        }

        // Goes through each instance of ahk and just kills it.
        private void KillAHK()
        {
            try
            {
                foreach(Process x in Process.GetProcessesByName("AutoHotkey"))
                {
                    x.Kill();
                }
            }
            catch
            {

            }
        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            Finder_Load(sender, e);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            KillAHK();
            Application.Exit();
        }
    }
}
