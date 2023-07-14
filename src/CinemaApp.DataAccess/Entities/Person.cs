namespace CinemaApp.DataAccess.Entities;


public class Person
{
    public int PeopleId { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public int RoleId { get; set; }

    public Person() { }
    
}
