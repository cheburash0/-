using Newtonsoft.Json;
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
using System.IO;

namespace курсовая.Forms
{
    public partial class Form4 : Form
    {
        public Film Film { get; private set; }
        public class FilmDatabase
        {
            public List<Film> Films { get; set; }
        }

        public Form4()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeComboBox(); // Убедитесь, что вызываете этот метод здесь, чтобы инициализировать DataGridView
            this.Film = new Film();    // Инициализация нового фильма
        }
        public Form4(Film film) : this()
        {
            this.Film = film;  // Установка существующего фильма
                               // Здесь можно добавить код для заполнения полей формы данными фильма
        }
        private void InitializeDataGridView()
        {
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "", Width = 30 });
            dataGridView.Columns.Add("Title", "Название");
            dataGridView.Columns.Add("Genre", "Жанр");
            dataGridView.Columns.Add("Year", "Год выпуска");
            dataGridView.Columns.Add("Director", "Режиссер");
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadFilmData();
        }

        private List<Film> films;
        private void InitializeComboBox()
        {
            comboBoxCollections.Items.Add("Все фильмы");
            comboBoxCollections.Items.Add("Sci-Fi");
            comboBoxCollections.Items.Add("Drama");
            comboBoxCollections.SelectedIndex = 0; 
            // Выбор первого элемента по умолчанию
        }
        private void comboBoxCollections_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFilteredFilms(comboBoxCollections.SelectedItem.ToString());
        }

        private void LoadFilteredFilms(string filter)
        {
            List<Film> filteredFilms;
            if (filter == "Все фильмы")
            {
                filteredFilms = films;
            }
            else
            {
                // Пример фильтрации, предполагающий, что у вас есть метод или логика для определения, какие фильмы относятся к какой коллекции
                filteredFilms = films.Where(f => f.Genre.Contains(filter)).ToList();
            }
            UpdateDataGridView(filteredFilms);
        }
        private void UpdateDataGridView(List<Film> filmsToShow)
        {
            dataGridView.Rows.Clear();
            foreach (var film in filmsToShow)
            {
                dataGridView.Rows.Add(film.Title, film.Genre, film.ReleaseYear, film.Director);
            }
        }


        private void LoadFilmData()
        {
            try
            {
                string jsonData = File.ReadAllText("database_films.json");
                var filmDatabase = JsonConvert.DeserializeObject<FilmDatabase>(jsonData);
                if (filmDatabase == null || filmDatabase.Films == null)
                {
                    MessageBox.Show("Данные о фильмах не загружены.");
                    return;
                }

                films = filmDatabase.Films;
                UpdateDataGridView();
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Ошибка десериализации: {ex.Message}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
            }
        }
        private void UpdateDataGridView()
        {
            dataGridView.Rows.Clear();
            foreach (var film in films)
            {
                dataGridView.Rows.Add(film.Title, film.Genre, film.ReleaseYear, film.Director);
            }
        }
        private void SaveFilms()
        {
            try
            {
                var filmDatabase = new FilmDatabase { Films = films };
                string jsonData = JsonConvert.SerializeObject(filmDatabase, Formatting.Indented);
                File.WriteAllText("database_films.json", jsonData);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка записи файла: {ex.Message}");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Создание новой формы для добавления фильма
            var addEditForm = new Form4(new Film());
            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                films.Add(addEditForm.Film);
                UpdateDataGridView();
                SaveFilms(); // Сохраняем изменения в файл
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int index = dataGridView.SelectedRows[0].Index;
                var film = films[index];
                var addEditForm = new Form4(film);
                if (addEditForm.ShowDialog() == DialogResult.OK)
                {
                    films[index] = addEditForm.Film;
                    UpdateDataGridView();
                    SaveFilms(); // Сохраняем изменения в файл
                }
            }
            else
            {
                MessageBox.Show("Выберите фильм для редактирования.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранный фильм?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int index = dataGridView.SelectedRows[0].Index;
                    films.RemoveAt(index);
                    UpdateDataGridView();
                    SaveFilms(); // Сохраняем изменения в файл
                }
            }
            else
            {
                MessageBox.Show("Выберите фильм для удаления.");
            }
        }      
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
