using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using курсовая.Models;

namespace курсовая.Forms
{
    public partial class Form3 : Form
    {
        public static List<Film> FavoriteFilms = new List<Film>();

        public Form3()
        {
            InitializeComponent();
        }
        public void UpdateFavoritesList()
        {
            LoadFavorites();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadFavorites();
        }
        private void LoadFavorites()
        {
            lstFavorites.Items.Clear();
            foreach (var film in FavoriteFilms)
            {
                string filmDetails = $"{film.Title}, {film.Genre}, {film.ReleaseYear}, Режиссер: {film.Director}, Рейтинг: {film.Rating}";
                lstFavorites.Items.Add(filmDetails);
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            string selectedFilmDetails = lstFavorites.SelectedItem?.ToString();
            if (selectedFilmDetails == null)
            {
                MessageBox.Show("Пожалуйста, выберите фильм для удаления.");
                return;
            }

            // Извлекаем название фильма из строки (предполагая, что название — это первая часть строки до запятой)
            string filmTitle = selectedFilmDetails.Split(',')[0];

            // Находим и удаляем фильм из списка избранных
            var filmToRemove = FavoriteFilms.FirstOrDefault(f => f.Title == filmTitle);
            if (filmToRemove != null)
            {
                FavoriteFilms.Remove(filmToRemove);
                lstFavorites.Items.Remove(lstFavorites.SelectedItem);
                MessageBox.Show($"Фильм '{filmTitle}' удалён из избранных.");
            }
            else
            {
                MessageBox.Show("Произошла ошибка при удалении фильма.");
            }
        }
    }

}