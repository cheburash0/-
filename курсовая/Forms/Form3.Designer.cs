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
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFavorites
            // 
            this.lstFavorites.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstFavorites.FormattingEnabled = true;
            this.lstFavorites.ItemHeight = 16;
            this.lstFavorites.Location = new System.Drawing.Point(0, 0);
            this.lstFavorites.Name = "lstFavorites";
            this.lstFavorites.Size = new System.Drawing.Size(835, 228);
            this.lstFavorites.TabIndex = 0;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemoveSelected.Location = new System.Drawing.Point(0, 435);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(835, 59);
            this.btnRemoveSelected.TabIndex = 1;
            this.btnRemoveSelected.Text = "Видалити з улюблених фільмів";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 494);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.lstFavorites);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Улюблені Фільми";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFavorites;
        private System.Windows.Forms.Button btnRemoveSelected;
    }
}