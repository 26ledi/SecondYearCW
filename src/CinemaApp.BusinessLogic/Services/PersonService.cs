using CinemaApp.DataAccess.Entities;
using CinemaApp.DataAccess.Repositories;

namespace CinemaApp.BusinessLogic.Services
{
    public class PersonService
    {
        //We are connecting the services with repositories 
        private readonly PersonDao _personDao;   
        public PersonService(PersonDao peopleDao)
        {
            _personDao = peopleDao;
        }

        public List<Person> GetAll()
        {
            List<Person> people = _personDao.GetAll();
            return people;
        }
       
        public void Insert(Person people)
        {
            _personDao.Insert(people);
        }
        public bool IsAdm(string name, string password)
        {
            List<Person> people = _personDao.GetAll();

            foreach (var adm in people)
            {
                if (adm.Name == name && adm.Password == password && adm.RoleId == 1)
                {
                    return true;
                }
            }

            return false;
        }


        public bool UserAuthenticated(string name, string password)
        {
            List<Person> people = GetAll();
            foreach(var p in people) 
            {
                if(p.Name==name && p.Password==password && p.RoleId == 2) 
                {
                    return true;
                }
            }
            return false;
           
           // return people.Any(p => p.Name == name && p.Password == password && p.RoleId==2);
        }


    }
}
