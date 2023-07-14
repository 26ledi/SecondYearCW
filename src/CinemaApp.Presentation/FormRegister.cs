using CinemaApp.BusinessLogic.Services;
using CinemaApp.DataAccess.Entities;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.Presentation
{
    public partial class FormRegister : Form
    {
        private readonly PersonService _personService;
        public FormRegister(PersonService personService)
        {
            _personService = personService;
            InitializeComponent();
        }

        private void buttonGoconnexion_Click(object sender, EventArgs e)
        {
            var username = textBoxEntry.Text;
            var password = textBoxEntryPwd.Text;
            if (username!=null && password!=null) 
            {
                Person person = new Person();
                person.Name = username;
                person.Password = password;
                person.RoleId = 2;
                _personService.Insert(person);
                MessageBox.Show("You have now an account :)");
                FilmDao filmDao = new FilmDao();
                CinemaDao cinemaDao = new CinemaDao();
                CineService cineService = new CineService(filmDao,cinemaDao);
                FormMenuUser formMenuUser = new FormMenuUser(cineService,username);
                formMenuUser.ShowDialog();
            }
            else 
            {
                MessageBox.Show("The Field is Empty!!!");
            }
           
        }
    }
}
