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
        private System.Windows.Forms.NumericUpDown numDurationFrom;
        private System.Windows.Forms.NumericUpDown numDurationTo;
        private System.Windows.Forms.Label lblDurationFrom;
        private System.Windows.Forms.Label lblDurationTo;
        

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
            this.numDurationFrom = new System.Windows.Forms.NumericUpDown();
            this.numDurationTo = new System.Windows.Forms.NumericUpDown();
            this.lblFilmTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblYearFrom = new System.Windows.Forms.Label();
            this.lblYearTo = new System.Windows.Forms.Label();
            this.lblDurationFrom = new System.Windows.Forms.Label();
            this.lblDurationTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationTo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilmTitle
            // 
            this.txtFilmTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilmTitle.Location = new System.Drawing.Point(12, 434);
            this.txtFilmTitle.Name = "txtFilmTitle";
            this.txtFilmTitle.Size = new System.Drawing.Size(200, 22);
            this.txtFilmTitle.TabIndex = 0;
            // 
            // btnCheckFilm
            // 
            this.btnCheckFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckFilm.Location = new System.Drawing.Point(218, 434);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(883, 358);
            this.dataGridView1.TabIndex = 2;
            // 
            // cmbGenre
            // 
            this.cmbGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(12, 486);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(150, 24);
            this.cmbGenre.TabIndex = 3;
            // 
            // cmbDirector
            // 
            this.cmbDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbDirector.FormattingEnabled = true;
            this.cmbDirector.Location = new System.Drawing.Point(168, 486);
            this.cmbDirector.Name = "cmbDirector";
            this.cmbDirector.Size = new System.Drawing.Size(150, 24);
            this.cmbDirector.TabIndex = 4;
            // 
            // numYearFrom
            // 
            this.numYearFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numYearFrom.Location = new System.Drawing.Point(324, 487);
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
            this.numYearTo.Location = new System.Drawing.Point(430, 487);
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
            this.btnSearch.Location = new System.Drawing.Point(15, 520);
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
            this.numRatingFrom.Location = new System.Drawing.Point(536, 487);
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
            this.numRatingTo.Location = new System.Drawing.Point(642, 487);
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
            // numDurationFrom
            // 
            this.numDurationFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numDurationFrom.Location = new System.Drawing.Point(748, 488);
            this.numDurationFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDurationFrom.Name = "numDurationFrom";
            this.numDurationFrom.Size = new System.Drawing.Size(100, 22);
            this.numDurationFrom.TabIndex = 18;
            // 
            // numDurationTo
            // 
            this.numDurationTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numDurationTo.Location = new System.Drawing.Point(854, 488);
            this.numDurationTo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDurationTo.Name = "numDurationTo";
            this.numDurationTo.Size = new System.Drawing.Size(100, 22);
            this.numDurationTo.TabIndex = 19;
            this.numDurationTo.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblFilmTitle
            // 
            this.lblFilmTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFilmTitle.Name = "lblFilmTitle";
            this.lblFilmTitle.Size = new System.Drawing.Size(100, 23);
            this.lblFilmTitle.TabIndex = 29;
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(0, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(100, 23);
            this.lblGenre.TabIndex = 28;
            // 
            // lblDirector
            // 
            this.lblDirector.Location = new System.Drawing.Point(0, 0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(100, 23);
            this.lblDirector.TabIndex = 27;
            // 
            // lblYearFrom
            // 
            this.lblYearFrom.Location = new System.Drawing.Point(0, 0);
            this.lblYearFrom.Name = "lblYearFrom";
            this.lblYearFrom.Size = new System.Drawing.Size(100, 23);
            this.lblYearFrom.TabIndex = 26;
            // 
            // lblYearTo
            // 
            this.lblYearTo.Location = new System.Drawing.Point(0, 0);
            this.lblYearTo.Name = "lblYearTo";
            this.lblYearTo.Size = new System.Drawing.Size(100, 23);
            this.lblYearTo.TabIndex = 25;
            // 
            // lblDurationFrom
            // 
            this.lblDurationFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDurationFrom.AutoSize = true;
            this.lblDurationFrom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDurationFrom.Location = new System.Drawing.Point(745, 464);
            this.lblDurationFrom.Name = "lblDurationFrom";
            this.lblDurationFrom.Size = new System.Drawing.Size(91, 16);
            this.lblDurationFrom.TabIndex = 20;
            this.lblDurationFrom.Text = "Тривалість з";
            // 
            // lblDurationTo
            // 
            this.lblDurationTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDurationTo.AutoSize = true;
            this.lblDurationTo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDurationTo.Location = new System.Drawing.Point(851, 464);
            this.lblDurationTo.Name = "lblDurationTo";
            this.lblDurationTo.Size = new System.Drawing.Size(23, 16);
            this.lblDurationTo.TabIndex = 21;
            this.lblDurationTo.Text = "по";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Жанри";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(165, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Режисер";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(321, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Рік з";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(427, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "по";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(533, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Оцінка з";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(639, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "по";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 569);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDurationTo);
            this.Controls.Add(this.lblDurationFrom);
            this.Controls.Add(this.numDurationTo);
            this.Controls.Add(this.numDurationFrom);
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
            this.Controls.Add(this.lblYearFrom);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblFilmTitle);
            this.Controls.Add(this.lblYearTo);
            this.Name = "Form2";
            this.Text = "Каталог";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatingTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}