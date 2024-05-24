using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using курсовая.Models;

namespace курсовая
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
            ConfigureDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                // Укажите путь к вашему JSON-файлу
                string jsonFilePath = "database_films.json";

                // Чтение данных из файла
                string jsonData = File.ReadAllText(jsonFilePath);

                // Десериализация JSON в объект FilmDatabase
                var filmDatabase = JsonConvert.DeserializeObject<FilmDatabase>(jsonData);

                // Проверка данных в отладочной среде
                if (filmDatabase == null || filmDatabase.Films == null)
                {
                    MessageBox.Show("Данные не были загружены из файла JSON.");
                    return;
                }

                // Связывание данных с DataGridView
                dataGridView1.DataSource = filmDatabase.Films;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }


        private void ConfigureDataGridView()
        {
            // Автоматическое изменение размеров столбцов по содержимому
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Настройка заголовков столбцов
            dataGridView1.Columns["Title"].HeaderText = "Назва фільму";
            dataGridView1.Columns["Studio"].HeaderText = "Студія";
            dataGridView1.Columns["Genre"].HeaderText = "Жанр";
            dataGridView1.Columns["ReleaseYear"].HeaderText = "Рік випуску";
            dataGridView1.Columns["Director"].HeaderText = "Режисер";            
            dataGridView1.Columns["Summary"].HeaderText = "Короткий зміст";
            dataGridView1.Columns["Rating"].HeaderText = "Суб'єктивна оцінка фільму";
            dataGridView1.Columns["Location"].HeaderText = "Розташування відеофайлу";
            dataGridView1.Columns["Size"].HeaderText = "Розмір файлу";

            // Настройка поведения при изменении размера формы
            dataGridView1.Dock = DockStyle.Fill;
        }

    }
}
