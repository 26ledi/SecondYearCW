using CinemaApp.DataAccess.Entities;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.BusinessLogic.Services
{
    public class PlaceService
    {
        private readonly PlaceDao _placeDao;
        public PlaceService(PlaceDao placeDao) 
        {
            _placeDao = placeDao;
        }
        public List<Place> GetPlaces(Place place) 
        {
            return _placeDao.GetAll();
        }
        public List<Place> GetPlacesByCinema(string cineName) 
        {
            return _placeDao.GetPlacesByCineName(cineName);
        }
    }
}
