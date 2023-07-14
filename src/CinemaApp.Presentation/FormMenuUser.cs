using CinemaApp.BusinessLogic.Services;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.Presentation
{
    public partial class FormMenuUser : Form
    {
        private readonly CineService _cineService;
        private readonly string _username;
        private ListView ListView { get; set; } = new ListView();
        public FormMenuUser(CineService cineService,string username)
        {
            InitializeComponent();

            _cineService = cineService;//create
            _username = username;

            ListView.Width = panelUser.Width;
            ListView.Height = panelUser.Height;
            panelUser.Controls.Add(ListView);
            ImageList imageList= new ImageList();
            imageList.ImageSize = new(100,100);
            ListView.LargeImageList = imageList;
            foreach (var cinema in _cineService.GetAll())
            {
                MemoryStream ms = new MemoryStream(cinema.Imagebytes);
                Image image = Image.FromStream(ms);
                ms.Close();
                // Ajouter l'image à l'imageList
                imageList.Images.Add(image);

                // Ajouter l'élément à la ListView
                ListViewItem item = new ListViewItem(cinema.Name);
                item.Name = cinema.Name;
                item.ImageIndex = imageList.Images.Count - 1; // index de l'image dans l'imageList
                ListView.Items.Add(item);
            }

            ListView.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);

            
        }
        void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)
            {
                ListViewItem item = ListView.SelectedItems[0];
                FilmDao filmDao = new FilmDao();
                FilmService filmService = new FilmService(filmDao);

                FormFilm formFilm = new FormFilm(_cineService, item.Name,_username,filmService);

                formFilm.ShowDialog();

            }
        }

    }
}
