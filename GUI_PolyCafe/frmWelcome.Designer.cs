namespace GUI_PolyCafe
{
    partial class frmWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(0, 568);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(915, 32);
            progressBar.TabIndex = 0;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.img_coffe;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(912, 589);
            Controls.Add(progressBar);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "frmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chào mừng đến với PolyCafe";
            FormClosing += Welcome_FormClosing;
            Load += frmWelcome_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar;
    }
}
