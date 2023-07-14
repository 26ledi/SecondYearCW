using CinemaApp.BusinessLogic.DTO_s;
using CinemaApp.BusinessLogic.Services;
using CinemaApp.DataAccess.Entities;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.Presentation
{
    public partial class FormFilm : Form
    {
        private readonly CineService _cineService;
        private readonly OrderService _orderService;
        private readonly string _username;
        private readonly string _cinemaName;
        private readonly List<Film> _filmDtos;
        private readonly FilmService _filmService;
        public FormFilm(CineService cineService, string cineName,string username,FilmService filmService)
        {
            InitializeComponent();
            _cineService = cineService;
            _cinemaName = cineName;
            _username = username;
            _filmService = filmService;
            _filmDtos = _filmService.GetFilms();

            Films = _cineService.GetFilmsByCineName(_cinemaName);
            
            ListView.Width = panelFilm.Width;
            ListView.Height = panelFilm.Height;
            panelFilm.Controls.Add(ListView);

            ImageList imageList = new ImageList();
            imageList.ImageSize = new(100, 100);
            ListView.LargeImageList = imageList;

            var films = _cineService.GetFilmsByCineName(_cinemaName);
           

            films.ForEach( film =>
            {
                MemoryStream ms = new MemoryStream(film.Imagebytes);
                Image image = Image.FromStream(ms);
                ms.Close();
                // Ajouter l'image à l'imageList
                imageList.Images.Add(image);

                // Ajouter l'élément à la ListView
                ListViewItem item = new ListViewItem(film.Name);
                item.Name = film.Name;
                //item.SubItems.Add(film.Price.ToString("C"));
                item.ImageIndex = imageList.Images.Count - 1;
                // index de l'image dans l'imageList
                ListView.Items.Add(item);

            });

            ListView.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);

        }

        public List<FilmDto> Films { get; set; } = new();
        private ListView ListView { get; set; } = new ListView();

        void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)
            {
                ListViewItem item = ListView.SelectedItems[0];
                OrderDao orderDao = new OrderDao();
                FilmDao filmDao = new FilmDao();
                CinemaDao cinemaDao = new CinemaDao();
                PlaceDao placeDao = new PlaceDao();
                PlaceService placeService = new PlaceService(placeDao);

                OrderService orderService = new OrderService(orderDao,filmDao,cinemaDao);
                
                
                FormFilmBuy formFilmBuy = new FormFilmBuy(orderService,_username,item.Name,_cinemaName,placeService);

                formFilmBuy.ShowDialog();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelDiffusion_Click(object sender, EventArgs e)
        {
            foreach (var c in _filmDtos) 
            {
                textBoxDiffusion.AppendText($"Movie:{c.Name}\n Date of Diffusion:{c.Diffusion}\n ");
            }
        }
    }
}
