using CinemaApp.BusinessLogic.Services;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.Presentation
{
    public partial class FormMainAdmi : Form
    {
        public FormMainAdmi()
        {
            InitializeComponent();
        }

        private void LabelModif_Click(object sender, EventArgs e)
        {

            FilmDao filmDao = new FilmDao();
            CinemaDao cinemaDao = new CinemaDao();
            CineService cineService = new CineService(filmDao, cinemaDao);
            FilmService filmService = new FilmService(filmDao);
            var window = new FormAdmi(filmService, cineService);
            window.ShowDialog();
        }

        private void labelbalance_Click_1(object sender, EventArgs e)
        {
            FilmDao filmDao = new FilmDao();
            CinemaDao cinemaDao = new CinemaDao();
            OrderDao orderDao = new OrderDao();
            OrderService orderService = new OrderService(orderDao, filmDao, cinemaDao);
            var window = new FormAdmiBalance(orderService);
            window.ShowDialog();
        }
    }
}
