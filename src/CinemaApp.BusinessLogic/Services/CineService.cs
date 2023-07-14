using CinemaApp.BusinessLogic.DTO_s;
using CinemaApp.DataAccess.Entities;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.BusinessLogic.Services
{
    public class CineService
    {
        private readonly FilmDao _filmDao;
        private readonly CinemaDao _cineDao;
        public CineService(FilmDao filmDao, CinemaDao cineDao)
        {
            _filmDao = filmDao;
            _cineDao = cineDao;
        }
        //a method that returns a list of cinemaDto
        public List<CinemaDto> GetAll()
        {
            List<CinemaDto> cinemaDtos= new List<CinemaDto>();
            try
            {
                var cinemas = _cineDao.GetAll();
                cinemas.ForEach(cinema =>
                {
                    cinemaDtos.Add(new CinemaDto
                    {
                        CinemaId = cinema.CinemaId,
                        Name = cinema.Name,
                        Adress = cinema.Adress,
                        SessionId = cinema.SessionId,
                        Imagebytes = cinema.Imagebytes,
                    });
                });

                return cinemaDtos;
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Cinema> GetAllCinema()
        {
            List<Cinema> cinemaDtos = new List<Cinema>();
            try
            {
                var cinemas = _cineDao.GetAll();
                cinemas.ForEach(cinema =>
                {
                    cinemaDtos.Add(new Cinema
                    {
                        CinemaId = cinema.CinemaId,
                        Name = cinema.Name,
                        Adress = cinema.Adress,
                        SessionId = cinema.SessionId,
                        Imagebytes = cinema.Imagebytes,
                    });
                });

                return cinemaDtos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //a method that returns a list of Dto
        public List<FilmDto> GetFilmsByCineName(string cineName)
        {
            List<FilmDto> filmDtos = new List<FilmDto>();
            
            
                var films = _filmDao.GetFilmsByCinemaName(cineName);
                films.ForEach(film =>
                {
                    filmDtos.Add(new FilmDto
                    {
                        FilmId = film.FilmId,
                        Name = film.Name,
                        Duration = film.Duration,
                        Rating = film.Rating,
                        Session = film.Session,
                        Price=film.Price,
                        Imagebytes = film.Imagebytes,
                        Diffusion= film.Diffusion
                        
                    });
                });

                return filmDtos;
            
        }
        public void Insert(Cinema cinema) 
        {
            _cineDao.Insert(cinema);
        }
        public void Delete(Cinema cinema) 
        {
            _cineDao.Delete(cinema);
        }
    }
}
