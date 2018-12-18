using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueholeSucks
{
    partial class Finder
    {
        // Iters tracks how many polls have been done so far
        // Checks for path of exile. If it's ever not found(ran from a Timer), disposes everything.
        // And kills ahk.
        private bool OneShotClose = false;
        private void CheckPathofExile(object sender, EventArgs e)
        {
            if(OneShotClose==false && Properties.Settings.Default.ShouldCloseWhenSuccess)
            {
                OneShotClose = true;
                MinimizeToTray();
            }
            if (!PathofExileIsPresent())
            {
                Count.Stop();
                Count.Dispose();
                KillAHK();
                Application.Exit();
                return;
            }
            SetMessage("Success! You may now minimize\nAnd ignore this.");
        }
        // Changes the center message.
        private void SetMessage(string msg)
        {
            StatusMessage.Text = msg;
            StatusMessage.Top = (this.ClientSize.Height - (StatusMessage.Height+35)) / 2;
            StatusMessage.Left = (this.ClientSize.Width - StatusMessage.Width) / 2;
        }
        private void SetStatus(string status)
        {
            StatusBarLabel.Text = status;
        }
        // Returns true if Path of Exile is open.
        private bool PathofExileIsPresent()
        {
            var Processes = Process.GetProcesses();
            foreach(Process p in Processes)
            {
                if (p.ProcessName.Contains("PathOfExile"))
                {
                    return true;
                }
            }
            return false;
        }
        private void MinimizeToTray()
        {
            TrayIcon.Visible = true;
            this.Hide();
        }
        private void PopupFromTray()
        {
            TrayIcon.Visible = false;
            this.Show();
        }
        // Goes through each instance of ahk and just kills it.
        private void KillAHK()
        {
            try
            {
                foreach (Process x in Process.GetProcessesByName("AutoHotkey"))
                {
                    x.Kill();
                }
            }
            catch
            {

            }
        }
    }
}
