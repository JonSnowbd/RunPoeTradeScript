namespace BlueholeSucks
{
    partial class Finder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finder));
            this.StatusMessage = new System.Windows.Forms.Label();
            this.RetryButton = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RefreshStatusBarButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideOnSuccessTick = new System.Windows.Forms.ToolStripMenuItem();
            this.HideGUIButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusMessage
            // 
            this.StatusMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusMessage.AutoSize = true;
            this.StatusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusMessage.Location = new System.Drawing.Point(93, 81);
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(255, 24);
            this.StatusMessage.TabIndex = 0;
            this.StatusMessage.Text = "Looking for Path of Exile...";
            // 
            // RetryButton
            // 
            this.RetryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RetryButton.Location = new System.Drawing.Point(12, 139);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(75, 23);
            this.RetryButton.TabIndex = 1;
            this.RetryButton.Text = "Retry";
            this.RetryButton.UseVisualStyleBackColor = true;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel,
            this.RefreshStatusBarButton});
            this.StatusBar.Location = new System.Drawing.Point(0, 165);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(441, 22);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "Status";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(16, 17);
            this.StatusBarLabel.Text = "...";
            // 
            // RefreshStatusBarButton
            // 
            this.RefreshStatusBarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshStatusBarButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.RefreshStatusBarButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshStatusBarButton.Image")));
            this.RefreshStatusBarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshStatusBarButton.Name = "RefreshStatusBarButton";
            this.RefreshStatusBarButton.Size = new System.Drawing.Size(29, 20);
            this.RefreshStatusBarButton.Text = "Refresh";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HideOnSuccessTick,
            this.HideGUIButton});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // HideOnSuccessTick
            // 
            this.HideOnSuccessTick.Name = "HideOnSuccessTick";
            this.HideOnSuccessTick.Size = new System.Drawing.Size(189, 22);
            this.HideOnSuccessTick.Text = "Auto Hide on Success";
            this.HideOnSuccessTick.Click += new System.EventHandler(this.AutoHideOnSuccessToolStripMenuItem_Click);
            // 
            // HideGUIButton
            // 
            this.HideGUIButton.Name = "HideGUIButton";
            this.HideGUIButton.Size = new System.Drawing.Size(189, 22);
            this.HideGUIButton.Text = "Minimize to Tray";
            this.HideGUIButton.Click += new System.EventHandler(this.HideGUIButton_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Autorun AHK";
            this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 187);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.StatusMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Finder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            this.Load += new System.EventHandler(this.Finder_Load);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusMessage;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarLabel;
        private System.Windows.Forms.ToolStripDropDownButton RefreshStatusBarButton;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HideOnSuccessTick;
        private System.Windows.Forms.ToolStripMenuItem HideGUIButton;
        private System.Windows.Forms.NotifyIcon TrayIcon;
    }
}

