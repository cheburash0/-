using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using курсовая.Forms;
using курсовая.Models;

namespace курсовая
{
    public partial class CatalogForm : Form
    {
        private List<Film> films;
        string favoritesPath = "favorite.json";

        public CatalogForm()
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
            DataGridViewCheckBoxColumn chkBoxColumn = new DataGridViewCheckBoxColumn();
            chkBoxColumn.Name = "chkSelect";
            chkBoxColumn.HeaderText = "Обрати";
            chkBoxColumn.Width = 50;
            chkBoxColumn.ReadOnly = false;
            chkBoxColumn.FillWeight = 10;
            dataGridView1.Columns.Add(chkBoxColumn);
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

        private void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            bool added = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["chkSelect"].Value);
                if (isSelected)
                {
                    Film film = row.DataBoundItem as Film;
                    if (film != null && !IsFilmInFavorites(film))
                    {
                        AddToFavorites(film);
                        added = true;
                    }
                }
            }
            if (added)
            {
                MessageBox.Show("Обрані фільми додані до улюбленого.");
                FavoriteForm form3 = Application.OpenForms.OfType<FavoriteForm>().FirstOrDefault();
                if (form3 != null)
                {
                    form3.UpdateFavoritesList();
                }
            }
            else
            {
                MessageBox.Show("Нема нофих фільмів для додавання.");
            }
        }
        private void AddToFavorites(Film film)
        {
            List<Film> favorites = LoadFavorites();

            if (!favorites.Any(f => f.Title == film.Title))
            {
                favorites.Add(film);
                string json = JsonConvert.SerializeObject(favorites, Formatting.Indented);
                File.WriteAllText(favoritesPath, json);
                MessageBox.Show($"{film.Title} додан(-о) в улюблене.");
            }
            else
            {
                MessageBox.Show($"{film.Title} вже є в улюбленому.");
            }
        }
        private bool IsFilmInFavorites(Film film)
        {
            List<Film> favorites = LoadFavorites();
            return favorites.Any(f => f.Title == film.Title);
        }
        private List<Film> LoadFavorites()
        {
            if (File.Exists(favoritesPath))
            {
                string json = File.ReadAllText(favoritesPath);
                return JsonConvert.DeserializeObject<List<Film>>(json) ?? new List<Film>();
            }
            return new List<Film>();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();

        }
    }
}