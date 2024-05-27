using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using курсовая.Models;

namespace курсовая
{
    public partial class Form2 : Form
    {
        private List<Film> films;

        public Form2()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
            ConfigureDataGridView();
            InitializeSearchCriteria();
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                string jsonFilePath = "database_films.json";
                string jsonData = System.IO.File.ReadAllText(jsonFilePath);
                var filmDatabase = JsonConvert.DeserializeObject<FilmDatabase>(jsonData);

                if (filmDatabase == null || filmDatabase.Films == null)
                {
                    MessageBox.Show("Дані не були завантажені з файлу JSON.");
                    return;
                }

                films = filmDatabase.Films;
                dataGridView1.DataSource = films;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час завантаження даних: {ex.Message}");
            }
        }


        private void ConfigureDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Columns["Title"].HeaderText = "Назва фільму";
            dataGridView1.Columns["Studio"].HeaderText = "Студія";
            dataGridView1.Columns["Genre"].HeaderText = "Жанр";
            dataGridView1.Columns["ReleaseYear"].HeaderText = "Рік випуску";
            dataGridView1.Columns["Director"].HeaderText = "Режисер";
            dataGridView1.Columns["Summary"].HeaderText = "Короткий зміст";
            dataGridView1.Columns["Rating"].HeaderText = "Суб'єктивна оцінка фільму";
            dataGridView1.Columns["Location"].HeaderText = "Розташування відеофайлу";
            dataGridView1.Columns["Size"].HeaderText = "Розмір файлу";
            dataGridView1.Columns["Duration"].HeaderText = "Тривалість";  // Новое поле
        }


        private void InitializeSearchCriteria()
        {
            var genres = films.Select(f => f.Genre).Distinct().ToList();
            var directors = films.Select(f => f.Director).Distinct().ToList();

            genres.Insert(0, "Всі");
            directors.Insert(0, "Всі");

            cmbGenre.Items.AddRange(genres.ToArray());
            cmbDirector.Items.AddRange(directors.ToArray());

            cmbGenre.SelectedIndex = 0;
            cmbDirector.SelectedIndex = 0;
        }

        private void btnCheckFilm_Click(object sender, EventArgs e)
        {
            string filmTitle = txtFilmTitle.Text;
            var film = FindFilmByTitle(filmTitle);

            if (film != null)
            {
                MessageBox.Show($"Фільм '{film.Title}' знайдений у відеотеці.");
            }
            else
            {
                MessageBox.Show("Фільм не знайдений.");
            }
        }

        private Film FindFilmByTitle(string title)
        {
            return films.FirstOrDefault(f => f.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedGenre = cmbGenre.SelectedItem?.ToString();
            string selectedDirector = cmbDirector.SelectedItem?.ToString();
            int yearFrom = (int)numYearFrom.Value;
            int yearTo = (int)numYearTo.Value;
            double ratingFrom = (double)numRatingFrom.Value;
            double ratingTo = (double)numRatingTo.Value;
            int durationFrom = (int)numDurationFrom.Value;
            int durationTo = (int)numDurationTo.Value;

            var filteredFilms = films.Where(f =>
                (selectedGenre == "Всі" || f.Genre == selectedGenre) &&
                (selectedDirector == "Всі" || f.Director == selectedDirector) &&
                (f.ReleaseYear >= yearFrom && f.ReleaseYear <= yearTo) &&
                (f.Rating >= ratingFrom && f.Rating <= ratingTo) &&
                (GetDurationInMinutes(f.Duration) >= durationFrom && GetDurationInMinutes(f.Duration) <= durationTo)).ToList();

            dataGridView1.DataSource = filteredFilms;

            if (!filteredFilms.Any())
            {
                MessageBox.Show("Не знайдено фільмів, що відповідають критеріям пошуку.");
            }
        }

        private int GetDurationInMinutes(string duration)
        {
            if (int.TryParse(duration.Replace(" min", ""), out int minutes))
            {
                return minutes;
            }
            return 0;
        }

    }
}