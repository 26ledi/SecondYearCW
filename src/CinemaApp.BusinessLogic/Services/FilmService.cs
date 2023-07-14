using CinemaApp.DataAccess.Entities;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.BusinessLogic.Services
{

    public class FilmService
    {
        private readonly FilmDao _filmDao;
        public FilmService(FilmDao filmDao)
        {
            _filmDao= filmDao;
        }
        public List<Film> GetFilms()
        {
            return _filmDao.GetAll();
        }
        public void InsertFilm(Film film) 
        {
            
            
            _filmDao.Insert(film);
            
            
        }
        public void UpdateFilm(Film film) 
        {
            _filmDao.Update(film);
        }
        public void DeleteFilm(Film film)
        {
            _filmDao.Delete(film);
        }
        
    }
}
