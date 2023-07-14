using CinemaApp.BusinessLogic.Services;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.Presentation
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            PersonDao personDao = new PersonDao();
            PersonService personService = new PersonService(personDao);

            var window = new FormConnexion(personService);
            window.ShowDialog();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            var window = new FormMenuGuest();
            window.ShowDialog();

        }

        private void labelSignIn_Click(object sender, EventArgs e)
        {
            PersonDao personDao = new PersonDao();
            PersonService personService = new PersonService(personDao);
            var window = new FormRegister(personService);
            window.ShowDialog();
        }
    }
}
