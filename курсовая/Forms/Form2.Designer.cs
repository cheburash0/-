namespace курсовая
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFilmTitle;
        private System.Windows.Forms.Button btnCheckFilm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.ComboBox cmbDirector;
        private System.Windows.Forms.NumericUpDown numYearFrom;
        private System.Windows.Forms.NumericUpDown numYearTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown numRatingFrom;
        private System.Windows.Forms.NumericUpDown numRatingTo;
        private System.Windows.Forms.Label lblFilmTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblYearFrom;
        private System.Windows.Forms.Label lblYearTo;
        private System.Windows.Forms.Label lblRatingFrom;
        private System.Windows.Forms.Label lblRatingTo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFilmTitle = new System.Windows.Forms.TextBox();
            this.btnCheckFilm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.cmbDirector = new System.Windows.Forms.ComboBox();
            this.numYearFrom = new System.Windows.Forms.NumericUpDown();
            this.numYearTo = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.numRatingFrom = new System.Windows.Forms.NumericUpDown();
            this.numRatingTo = new System.Windows.Forms.NumericUpDown();
            this.lblFilmTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblYearFrom = new System.Windows.Forms.Label();
            this.lblYearTo = new System.Windows.Forms.Label();
            this.lblRatingFrom = new System.Windows.Forms.Label();
            this.lblRatingTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingTo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilmTitle
            // 
            this.txtFilmTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilmTitle.Location = new System.Drawing.Point(12, 468);
            this.txtFilmTitle.Name = "txtFilmTitle";
            this.txtFilmTitle.Size = new System.Drawing.Size(200, 22);
            this.txtFilmTitle.TabIndex = 0;
            // 
            // btnCheckFilm
            // 
            this.btnCheckFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckFilm.Location = new System.Drawing.Point(218, 468);
            this.btnCheckFilm.Name = "btnCheckFilm";
            this.btnCheckFilm.Size = new System.Drawing.Size(113, 23);
            this.btnCheckFilm.TabIndex = 1;
            this.btnCheckFilm.Text = "Перевірити";
            this.btnCheckFilm.UseVisualStyleBackColor = true;
            this.btnCheckFilm.Click += new System.EventHandler(this.btnCheckFilm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(861, 363);
            this.dataGridView1.TabIndex = 2;
            // 
            // cmbGenre
            // 
            this.cmbGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(12, 517);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(150, 24);
            this.cmbGenre.TabIndex = 3;
            // 
            // cmbDirector
            // 
            this.cmbDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbDirector.FormattingEnabled = true;
            this.cmbDirector.Location = new System.Drawing.Point(168, 517);
            this.cmbDirector.Name = "cmbDirector";
            this.cmbDirector.Size = new System.Drawing.Size(150, 24);
            this.cmbDirector.TabIndex = 4;
            // 
            // numYearFrom
            // 
            this.numYearFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numYearFrom.Location = new System.Drawing.Point(324, 518);
            this.numYearFrom.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numYearFrom.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYearFrom.Name = "numYearFrom";
            this.numYearFrom.Size = new System.Drawing.Size(100, 22);
            this.numYearFrom.TabIndex = 5;
            this.numYearFrom.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numYearTo
            // 
            this.numYearTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numYearTo.Location = new System.Drawing.Point(430, 518);
            this.numYearTo.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numYearTo.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYearTo.Name = "numYearTo";
            this.numYearTo.Size = new System.Drawing.Size(100, 22);
            this.numYearTo.TabIndex = 6;
            this.numYearTo.Value = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(748, 517);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // numRatingFrom
            // 
            this.numRatingFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numRatingFrom.DecimalPlaces = 1;
            this.numRatingFrom.Location = new System.Drawing.Point(536, 518);
            this.numRatingFrom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRatingFrom.Name = "numRatingFrom";
            this.numRatingFrom.Size = new System.Drawing.Size(100, 22);
            this.numRatingFrom.TabIndex = 8;
            // 
            // numRatingTo
            // 
            this.numRatingTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numRatingTo.DecimalPlaces = 1;
            this.numRatingTo.Location = new System.Drawing.Point(642, 518);
            this.numRatingTo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRatingTo.Name = "numRatingTo";
            this.numRatingTo.Size = new System.Drawing.Size(100, 22);
            this.numRatingTo.TabIndex = 9;
            this.numRatingTo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblFilmTitle
            // 
            this.lblFilmTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFilmTitle.AutoSize = true;
            this.lblFilmTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFilmTitle.Location = new System.Drawing.Point(12, 449);
            this.lblFilmTitle.Name = "lblFilmTitle";
            this.lblFilmTitle.Size = new System.Drawing.Size(98, 16);
            this.lblFilmTitle.TabIndex = 10;
            this.lblFilmTitle.Text = "Назва фільму";
            // 
            // lblGenre
            // 
            this.lblGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblGenre.Location = new System.Drawing.Point(12, 500);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(44, 16);
            this.lblGenre.TabIndex = 11;
            this.lblGenre.Text = "Жанр";
            // 
            // lblDirector
            // 
            this.lblDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDirector.AutoSize = true;
            this.lblDirector.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDirector.Location = new System.Drawing.Point(165, 500);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(64, 16);
            this.lblDirector.TabIndex = 12;
            this.lblDirector.Text = "Режисер";
            // 
            // lblYearFrom
            // 
            this.lblYearFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYearFrom.AutoSize = true;
            this.lblYearFrom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblYearFrom.Location = new System.Drawing.Point(321, 500);
            this.lblYearFrom.Name = "lblYearFrom";
            this.lblYearFrom.Size = new System.Drawing.Size(37, 16);
            this.lblYearFrom.TabIndex = 13;
            this.lblYearFrom.Text = "Рік з";
            // 
            // lblYearTo
            // 
            this.lblYearTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYearTo.AutoSize = true;
            this.lblYearTo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblYearTo.Location = new System.Drawing.Point(427, 500);
            this.lblYearTo.Name = "lblYearTo";
            this.lblYearTo.Size = new System.Drawing.Size(23, 16);
            this.lblYearTo.TabIndex = 14;
            this.lblYearTo.Text = "по";
            // 
            // lblRatingFrom
            // 
            this.lblRatingFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRatingFrom.AutoSize = true;
            this.lblRatingFrom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRatingFrom.Location = new System.Drawing.Point(533, 500);
            this.lblRatingFrom.Name = "lblRatingFrom";
            this.lblRatingFrom.Size = new System.Drawing.Size(62, 16);
            this.lblRatingFrom.TabIndex = 15;
            this.lblRatingFrom.Text = "Оцінка з";
            // 
            // lblRatingTo
            // 
            this.lblRatingTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRatingTo.AutoSize = true;
            this.lblRatingTo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRatingTo.Location = new System.Drawing.Point(639, 500);
            this.lblRatingTo.Name = "lblRatingTo";
            this.lblRatingTo.Size = new System.Drawing.Size(23, 16);
            this.lblRatingTo.TabIndex = 16;
            this.lblRatingTo.Text = "по";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 570);
            this.Controls.Add(this.lblRatingTo);
            this.Controls.Add(this.lblRatingFrom);
            this.Controls.Add(this.lblYearTo);
            this.Controls.Add(this.lblYearFrom);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblFilmTitle);
            this.Controls.Add(this.numRatingTo);
            this.Controls.Add(this.numRatingFrom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.numYearTo);
            this.Controls.Add(this.numYearFrom);
            this.Controls.Add(this.cmbDirector);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.btnCheckFilm);
            this.Controls.Add(this.txtFilmTitle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Каталог";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
