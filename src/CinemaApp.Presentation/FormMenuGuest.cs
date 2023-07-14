using CinemaApp.DataAccess.Entities;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.Presentation
{
    public partial class FormMenuGuest : Form
    {
        private readonly CinemaDao _cinemaDao = new CinemaDao();
        public FormMenuGuest()
        {

            InitializeComponent();
            ListView listView = new ListView();
            listView.Width = panelGuest.Width;
            listView.Height = panelGuest.Height;
            panelGuest.Controls.Add(listView);
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(100, 100); // taille des images
            listView.LargeImageList = imageList;
            foreach (var cinema in _cinemaDao.GetAll())
            {
                MemoryStream ms = new MemoryStream(cinema.Imagebytes);
                Image image = Image.FromStream(ms);
                ms.Close();
                // Ajouter l'image à l'imageList
                imageList.Images.Add(image);

                // Ajouter l'élément à la ListView
                ListViewItem item = new ListViewItem(cinema.Adress);
                item.ImageIndex = imageList.Images.Count - 1; // index de l'image dans l'imageList
                listView.Items.Add(item);
                
            }
            listView.ItemActivate += (sender, e) =>
            {
                // Récupération de l'élément sélectionné dans la ListView
                ListViewItem item = listView.SelectedItems[0];

                // Récupération des données du cinéma associé à l'élément sélectionné
                Cinema cinema = _cinemaDao.GetAll()[0];

                // Affichage d'une nouvelle fenêtre pour le cinéma sélectionné
                MessageBox.Show("You don't have an account.Please Go to Sign in !!!");
               
            };



        }
    }
}
