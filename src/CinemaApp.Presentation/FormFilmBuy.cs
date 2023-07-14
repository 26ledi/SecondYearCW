using CinemaApp.BusinessLogic.DTO_s;
using CinemaApp.BusinessLogic.Services;
using CinemaApp.DataAccess.Entities;
using System.Data;

namespace CinemaApp.Presentation
{
    public partial class FormFilmBuy : Form
    {
        
        private readonly OrderService _orderservice;
        private readonly string _username;
        private readonly string _filmname;
        private readonly string _cinemaName;
        private readonly List<Session> sessionDtos;
        private readonly List<Film> filmDtos;
        private readonly List<Category> CategoryDtos;
        private readonly List<OrderDto>orderDtos1;
        private readonly List<Cinema> cinemasDto;
        private readonly List<Person> PersonDtos;
        private readonly List<Place> placesDtos;
        private readonly PlaceService _placeservice;
        


        List<OrderDto> orderDtos { get; set; } = new();
        private Order order { get; set; }
        public FormFilmBuy(OrderService orderService,string username,string filmname,string cinemaname,PlaceService placeService)
        {
            
            InitializeComponent();
            _orderservice = orderService;
            _username = username;
            _filmname = filmname;
            _cinemaName= cinemaname;
            _placeservice = placeService;
            filmDtos = _orderservice.GetAllFilm();
            cinemasDto = _orderservice.GetAllCinema();
            CategoryDtos = _orderservice.GetAllCategories();
            sessionDtos = _orderservice.GetAllSession();
            PersonDtos = _orderservice.GetAllPersons();
            orderDtos = _orderservice.GetAllOrderByName(username);
            placesDtos = _placeservice.GetPlacesByCinema(cinemaname);
        }
        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxCatego.SelectedIndex==-1 || BoxNbrticket.Value==0 || comboBoxSess.SelectedIndex==-1||comboBoxCash.SelectedIndex==-1) 
            {
                MessageBox.Show("Please fill the fields!!!");
            }
            else 
            {
                
                var category1 = comboBoxCatego.Text;
                var NbrTicket = Convert.ToInt32(BoxNbrticket.Value);
                var session1 = comboBoxSess.Text;
                var cashier = comboBoxCash.Text;
                var duration = filmDtos.Where(film => film.Name == _filmname).Select(film => film.Duration).FirstOrDefault();
                var price = filmDtos.Where(film => film.Name == _filmname).Select(film => film.Price).FirstOrDefault();
                var firstprice = _orderservice.Getprice_Form(session1, category1, price, duration);
                var amount = _orderservice.GetDiscountPrice(NbrTicket, firstprice);
                ShowbPrice.AppendText(Convert.ToString(amount));
              //-----------------------------------------------
                order = new Order();
                order.PeopleId = PersonDtos.Where(person => person.Name ==_username).Select(person => person.PeopleId).FirstOrDefault();
                order.Numberofticket = NbrTicket;
                order.SessionId = sessionDtos.Where(session => session.Time == session1).Select(session => session.SessionId).FirstOrDefault();
                order.Amount = amount;
                order.CategoryId = CategoryDtos.Where(category => category.Name == category1).Select(category => category.CategoryId).FirstOrDefault();
                order.FilmId = filmDtos.Where(film=> film.Name == _filmname).Select(film=>film.FilmId).FirstOrDefault();
                order.CinemaId = cinemasDto.Where(cinema => cinema.Name == _cinemaName).Select(cinema => cinema.CinemaId).FirstOrDefault();
                order.Dateoforder = DateTime.Now;
                order.Cashier = cashier;

            }
           
            
        }

        private void buttonBuyShow_Click(object sender, EventArgs e)
        {
            _orderservice.Insert(order);
            MessageBox.Show($"Mr/Mrs {_username} your order has been placed successfully");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ShowbPrice.Clear();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form is FormConnexion || form is FormFilm ||form is FormMenuUser||form is FormMenuGuest|| form is FormFilmBuy)
                {
                    form.Close();
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            foreach (var place in _placeservice.GetPlacesByCinema(_cinemaName))
            {
                textBoxPlace.AppendText($" Name: {_cinemaName}, Category: {place.CategoryName}, Number of Places: {place.Numberofplace} \n");
            }

        }

        private void FormFilmBuy_Load(object sender, EventArgs e)
        {
            this.Load += FormFilmBuy_Load;
            foreach(var c in PersonDtos.Where(cashier=>cashier.RoleId==3).Select(cashier=>cashier.Name)) 
            {
                comboBoxCash.Items.Add(c);
            } 
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            var unitprice =filmDtos.Where(film => film.Name == _filmname).Select(film => film.Price).FirstOrDefault();
            textBoxUnit.AppendText(unitprice.ToString());
        }
    }
}
