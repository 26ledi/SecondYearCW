using CinemaApp.BusinessLogic.Services;
using CinemaApp.DataAccess.Entities;
using System.Data;

namespace CinemaApp.Presentation
{
    public partial class FormAdmi : Form
    {
        private readonly FilmService _filmservice;
        private readonly List<Film> _listFilms;
        private readonly List<Cinema> _listCinema;
        private readonly CineService _cineService;
        
        public FormAdmi(FilmService filmService,CineService cineService)
        {
            _filmservice= filmService;
            _cineService = cineService;
            _listFilms = _filmservice.GetFilms();
            _listCinema = _cineService.GetAllCinema();
            InitializeComponent();
        }

        private void buttonAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                textBoxImage.AppendText(imagePath);
            }
        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            Film film1 = new Film();
            film1.Name = textBoxFilmName.Text;
            film1.Duration = Convert.ToDouble(textBoxDurati.Text);
            film1.Rating = Convert.ToDouble(textBoxRating.Text);
            string path= textBoxImage.Text;
            byte[] imageData = File.ReadAllBytes(path);
            film1.Imagebytes = imageData;
            film1.Price = Convert.ToDouble(textBox4.Text);
            film1.Diffusion = Convert.ToDateTime(textBoxDate.Text);
            _filmservice.InsertFilm(film1);
            MessageBox.Show("Done!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            string filmName=textBoxDelete.Text;
            film.Name = filmName;
            film.FilmId = _listFilms.Where(film => film.Name == filmName).Select(film => film.FilmId).FirstOrDefault();
            _filmservice.DeleteFilm(film);
            MessageBox.Show("The Film has been deleted");
        }

       

        private void buttonAddCine_Click(object sender, EventArgs e)
        {
            Cinema cinema = new Cinema();
            cinema.Name = textBoxCineName.Text;
            cinema.Adress = textBoxAdress.Text;
            string path = textBoxImgC.Text;
            byte[] ImageData = File.ReadAllBytes(path);
            cinema.Imagebytes = ImageData;
            _cineService.Insert(cinema);
            MessageBox.Show("Done!!");

        }

        private void buttonSetImgC_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                textBoxImgC.AppendText(imagePath);
            }
        }

        private void buttonDltCine_Click(object sender, EventArgs e)
        {
            Cinema cinema = new Cinema();
            var cineName = textBoxCineName.Text;
            cinema.Name = cineName;
            cinema.CinemaId = _listCinema.Where(cinema => cinema.Name == cineName).Select(cinema => cinema.CinemaId).FirstOrDefault();
            _cineService.Delete(cinema);
            MessageBox.Show("The Cinema has been deleted!!!");
          
        }
    }
}
