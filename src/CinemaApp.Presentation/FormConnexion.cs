using CinemaApp.BusinessLogic.Services;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.Presentation
{
    public partial class FormConnexion : Form
    {
        private readonly PersonService _personService;
        
        public FormConnexion(PersonService personService)
        {
            _personService = personService;
            
            

            InitializeComponent();
        }

        private void buttonGoconnexion_Click(object sender, EventArgs e)
        {
            var username = UserNametextBox.Text;
            var password = PasswordtextBox.Text;
            if (_personService.UserAuthenticated(username,password))
            {
                FilmDao filmDao = new FilmDao();
                CinemaDao cinemaDao = new CinemaDao();
                CineService cineService = new CineService(filmDao, cinemaDao);
                FormMenuUser formMenuUser = new FormMenuUser(cineService,username);
                formMenuUser.ShowDialog();
            
            }
            else if (string.IsNullOrWhiteSpace(username)|| string.IsNullOrWhiteSpace(password))
            {
               
                UserNametextBox.ForeColor = Color.Red;
                UserNametextBox.BackColor = Color.White;
                UserNametextBox.Text = "Please fill the field";
                PasswordtextBox.ForeColor = Color.Red;
                PasswordtextBox.BackColor = Color.White;
                PasswordtextBox.Text= "Please fill the field";

                return;
            }

            else if (_personService.IsAdm(username,password)) 
            {
                var window = new FormMainAdmi();
                window.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Check again your username or your password");
            }

          
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var window = new Form2();
            window.Show();
        }
    }
}
