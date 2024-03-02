namespace splahScreen_and_Login
{
    partial class frmSplash
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.bnProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.TimerPrbar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bnProgressBar
            // 
            this.bnProgressBar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bnProgressBar.BorderRadius = 5;
            this.bnProgressBar.Location = new System.Drawing.Point(144, 485);
            this.bnProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnProgressBar.MaximumValue = 100;
            this.bnProgressBar.Name = "bnProgressBar";
            this.bnProgressBar.ProgressColor = System.Drawing.Color.Turquoise;
            this.bnProgressBar.Size = new System.Drawing.Size(345, 12);
            this.bnProgressBar.TabIndex = 0;
            this.bnProgressBar.Value = 0;
            this.bnProgressBar.progressChanged += new System.EventHandler(this.bnProgressBar_progressChanged);
            // 
            // TimerPrbar
            // 
            this.TimerPrbar.Enabled = true;
            this.TimerPrbar.Interval = 500;
            this.TimerPrbar.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(629, 584);
            this.Controls.Add(this.bnProgressBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Desktop;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSplash_FormClosed);
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar bnProgressBar;
        private System.Windows.Forms.Timer TimerPrbar;
    }
}

