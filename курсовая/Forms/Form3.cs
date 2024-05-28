using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using курсовая.Models;

namespace курсовая.Forms
{
    public partial class Form3 : Form
    {
        private string favoritesPath = "favorite.json";

        public Form3()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form3_Load);
            btnRemoveSelected.Click += new EventHandler(btnRemoveSelected_Click);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadFavorites();
        }

        public void UpdateFavoritesList()
        {
            LoadFavorites();
        }

        private void LoadFavorites()
        {
            lstFavorites.Items.Clear();
            List<Film> favoriteFilms = LoadFavoritesFromFile();
            foreach (var film in favoriteFilms)
            {
                string filmDetails = $"{film.Title}, {film.Genre}, {film.ReleaseYear}, Режиссер: {film.Director}, Рейтинг: {film.Rating}";
                lstFavorites.Items.Add(filmDetails);
            }
        }

        private List<Film> LoadFavoritesFromFile()
        {
            if (File.Exists(favoritesPath))
            {
                string json = File.ReadAllText(favoritesPath);
                return JsonConvert.DeserializeObject<List<Film>>(json) ?? new List<Film>();
            }
            return new List<Film>();
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            string selectedFilmDetails = lstFavorites.SelectedItem?.ToString();
            if (selectedFilmDetails == null)
            {
                MessageBox.Show("Пожалуйста, выберите фильм для удаления.");
                return;
            }

            string filmTitle = selectedFilmDetails.Split(',')[0];
            List<Film> favoriteFilms = LoadFavoritesFromFile();
            var filmToRemove = favoriteFilms.FirstOrDefault(f => f.Title == filmTitle);
            if (filmToRemove != null)
            {
                favoriteFilms.Remove(filmToRemove);
                SaveFavoritesToFile(favoriteFilms);
                LoadFavorites();
                MessageBox.Show($"Фильм '{filmTitle}' удалён из избранных.");
            }
            else
            {
                MessageBox.Show("Произошла ошибка при удалении фильма.");
            }
        }

        private void SaveFavoritesToFile(List<Film> favoriteFilms)
        {
            var json = JsonConvert.SerializeObject(favoriteFilms, Formatting.Indented);
            File.WriteAllText(favoritesPath, json);
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
