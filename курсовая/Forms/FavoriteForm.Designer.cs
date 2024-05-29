namespace курсовая.Forms
{
    partial class FavoriteForm
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
            this.btnForm1 = new System.Windows.Forms.Button();
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
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(0, 363);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(122, 23);
            this.btnForm1.TabIndex = 38;
            this.btnForm1.Text = "Головне меню";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 494);
            this.Controls.Add(this.btnForm1);
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
        private System.Windows.Forms.Button btnForm1;
    }
}