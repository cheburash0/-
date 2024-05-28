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

    }

}