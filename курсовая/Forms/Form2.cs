using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using курсовая.Models;
using System.IO;




namespace курсовая
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string jsonFilePath = "database_films.json";
            string jsonData = File.ReadAllText(jsonFilePath);
            var films = JsonConvert.DeserializeObject<List<Film>>(jsonData);

            dataGridView1.DataSource = films;
        }

        private void ConfigureDataGridView()
        {
            // Налаштування автоматичного розміру колонок
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.Columns["Location"].Visible = false; // Приховати колонку з шляхом до файлу
        }

    }
}
