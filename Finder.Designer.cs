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
            this.StatusMessage = new System.Windows.Forms.Label();
            this.RetryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.IterationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusMessage
            // 
            this.StatusMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusMessage.AutoSize = true;
            this.StatusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusMessage.Location = new System.Drawing.Point(156, 97);
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(255, 24);
            this.StatusMessage.TabIndex = 0;
            this.StatusMessage.Text = "Looking for Path of Exile...";
            // 
            // RetryButton
            // 
            this.RetryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RetryButton.Location = new System.Drawing.Point(13, 184);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(75, 23);
            this.RetryButton.TabIndex = 1;
            this.RetryButton.Text = "Retry";
            this.RetryButton.UseVisualStyleBackColor = true;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(450, 175);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 32);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit(and AHK)";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // IterationLabel
            // 
            this.IterationLabel.AutoSize = true;
            this.IterationLabel.Location = new System.Drawing.Point(13, 13);
            this.IterationLabel.Name = "IterationLabel";
            this.IterationLabel.Size = new System.Drawing.Size(0, 13);
            this.IterationLabel.TabIndex = 3;
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 219);
            this.Controls.Add(this.IterationLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.StatusMessage);
            this.Name = "Finder";
            this.Text = "...";
            this.Load += new System.EventHandler(this.Finder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusMessage;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label IterationLabel;
    }
}

