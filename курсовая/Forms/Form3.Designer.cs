namespace курсовая.Forms
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            this.lstFavorites = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFavorites
            // 
            this.lstFavorites.FormattingEnabled = true;
            this.lstFavorites.ItemHeight = 16;
            this.lstFavorites.Location = new System.Drawing.Point(0, 0);
            this.lstFavorites.Name = "lstFavorites";
            this.lstFavorites.Size = new System.Drawing.Size(420, 260);
            this.lstFavorites.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 456);
            this.Controls.Add(this.lstFavorites);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Улюблені Фільми";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFavorites;
    }
}