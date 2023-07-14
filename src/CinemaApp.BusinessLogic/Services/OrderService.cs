using CinemaApp.BusinessLogic.DTO_s;
using CinemaApp.DataAccess.Entities;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.BusinessLogic.Services
{

    public class OrderService
    {
        private readonly OrderDao _orderDao;
        private readonly FilmDao _filmDao;
        private readonly PersonDao _personDao;
        private readonly SessionDao _sessionDao;
        private readonly CinemaDao _cinemaDao;
        private readonly CategoryDao _categoryDao;
        public OrderService(OrderDao orderDao,FilmDao filmDao,CinemaDao cinemaDao) 
        {
            _orderDao = orderDao;
            _filmDao= filmDao;
            _cinemaDao= cinemaDao;
            _categoryDao = new();
            _sessionDao = new();
            _personDao = new();
        }
        public List<OrderDto> GetAllOrderByName(string username)
        {
           List<OrderDto>orderDtos= new List<OrderDto>();
           
                var orders = _orderDao.GetAllOrderByName(username);
                orders.ForEach(order =>
                {
                    orderDtos.Add(new OrderDto
                    {
                        OrderId = order.OrderId,
                        PeopleId = order.PeopleId,
                        CategoryId = order.CategoryId,
                        Numberofticket = order.Numberofticket,
                        SessionId = order.SessionId,
                        Amount = order.Amount,
                        Duration = order.Duration,
                        FilmId = order.FilmId,
                        CinemaId = order.CinemaId,
                        dateoforder = order.Dateoforder

                    });

                });

                return orderDtos;
            
        }

        public List<Film> GetAllFilm()
        {
           
           return _filmDao.GetAll();
        }
        public int GetById(string name)
        {
            return _personDao.GetById(name);
        }
        public int GetById2(string name)
        {
            return _sessionDao.GetById(name);
        }
        public int GetAllIdCine(string name)
        {
            return _cinemaDao.GetById(name);
        }
        public int GetAllIdCategory(string name)
        {
            return _categoryDao.GetById(name);
        }
        public List<Cinema> GetAllCinema()
        {
            return _cinemaDao.GetAll();
        }
        public List<Category> GetAllCategories()
        {
            return _categoryDao.GetAll();
        }
        public List<Session> GetAllSession()
        {
            return _sessionDao.GetAll();
        }
        public List<Person> GetAllPersons() 
        {
            return _personDao.GetAll();
        }
     

        public void Insert(Order order)
        { 
            try
            {
                _orderDao.Insert(order);

            }
            catch
            {
                throw;
            }

        }
        public List<Order> GetAverage(DateTime startDate,DateTime endDate) 
        {
            return _orderDao.GetAverageByCinemas(startDate,endDate);
        }
        public List<Order> GetPopularFilms() 
        {
            return _orderDao.GetPopularFilms();
        }
        public List<Order> GetCashier(DateTime startDate, DateTime endDate) 
        {
            return _orderDao.GetCashiers(startDate,endDate);
        }

        public double GetDiscountPrice(int nbrticket, double unitprice)
        {
            double totalprice;
            if (nbrticket <= 5)
            {
                totalprice = unitprice * nbrticket;

            }
            else
            {
                double amountbefore = unitprice * nbrticket;
                double discount = amountbefore * 0.07;
                totalprice = amountbefore - discount;
            }
            return totalprice;
        }
        public double Getprice_Form(string session, string category, double unitprice, double duration)
        {
            double totalprice = 0;
            if (session == "Night" && category == "VIP")
            {
                if (duration > 150)
                {
                    totalprice = unitprice * 0.50;
                }
                else
                {
                    totalprice = unitprice * 0.30;
                }

            }
            else if (session == "Night" && category == "Middle")
            {
                if (duration > 150)
                {
                    totalprice = unitprice * 0.40;
                }
                else
                {
                    totalprice = unitprice * 0.27;
                }
            }
            else if (session == "Night" && category == "Economic")
            {
                if (duration > 150)
                {
                    totalprice = unitprice * 0.30;
                }
                else
                {
                    totalprice = unitprice * 0.25;
                }
            }
            else if (session == "Evening" && category == "VIP")
            {
                if (duration > 150)
                {
                    totalprice = unitprice * 0.25;
                }
                else
                {
                    totalprice = unitprice * 0.23;
                }
            }
            else if (session == "Evening" && category == "Middle")
            {
                if (duration > 150)
                {
                    totalprice = unitprice * 0.23;
                }
                else
                {
                    totalprice = unitprice * 0.20;
                }
            }
            else if (session == "Evening" && category == "Economic")
            {
                if (duration > 150)
                {
                    totalprice = unitprice * 0.20;
                }
                else
                {
                    totalprice = unitprice * 0.17;
                }
            }
            else if (session == "Morning" && category == "VIP")
            {
                if (duration > 150)
                {
                    totalprice = unitprice * 0.17;
                }
                else
                {
                    totalprice = unitprice * 0.15;
                }
            }
            else if (session == "Morning" && category == "Middle")
            {
                if (duration > 150)
                {
                    totalprice = unitprice * 0.15;
                }
                else
                {
                    totalprice = unitprice * 0.12;
                }
            }
            else if (session == "Morning" && category == "Economic")
            {
                if (duration > 150)
                {
                    totalprice = unitprice * 0.12;
                }
                else
                {
                    totalprice = unitprice * 0.10;
                }
            }

            return totalprice;
        }
    }
}
