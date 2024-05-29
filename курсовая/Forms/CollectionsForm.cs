using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using курсовая.Models;

namespace курсовая.Forms
{
    public partial class CollectionsForm : Form
    {
        private List<Film> films;

        public CollectionsForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            films = LoadMovies("database_films.json").Films;

            var genres = films
                .SelectMany(f => f.Genre.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                .Select(g => g.Trim())
                .Distinct()
                .ToList();

            comboBox1.Items.AddRange(genres.ToArray());

            var directors = films
                .Select(f => f.Director)
                .Distinct()
                .ToList();

            comboBox2.Items.AddRange(directors.ToArray());

            var years = films
                .Select(f => f.ReleaseYear.ToString())
                .Distinct()
                .ToList();

            comboBox3.Items.AddRange(years.ToArray());
        }

        public FilmCollection LoadMovies(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<FilmCollection>(json);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAndDisplayMovies();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAndDisplayMovies();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterAndDisplayMovies();
        }

        private void FilterAndDisplayMovies()
        {
            var selectedGenre = comboBox1.SelectedItem?.ToString();
            var selectedDirector = comboBox2.SelectedItem?.ToString();
            var selectedYear = comboBox3.SelectedItem?.ToString();

            var filteredMovies = films.AsEnumerable();

            if (!string.IsNullOrEmpty(selectedGenre))
            {
                filteredMovies = filteredMovies
                    .Where(f => f.Genre.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(g => g.Trim())
                    .Contains(selectedGenre));
            }

            if (!string.IsNullOrEmpty(selectedDirector))
            {
                filteredMovies = filteredMovies
                    .Where(f => f.Director == selectedDirector);
            }

            if (!string.IsNullOrEmpty(selectedYear) && int.TryParse(selectedYear, out int year))
            {
                filteredMovies = filteredMovies
                    .Where(f => f.ReleaseYear == year);
            }

            filteredMovies = filteredMovies.OrderBy(f => f.ReleaseYear).ToList();

            listBox1.Items.Clear();
            foreach (var film in filteredMovies)
            {
                listBox1.Items.Add($"{film.Title} ({film.ReleaseYear})");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
