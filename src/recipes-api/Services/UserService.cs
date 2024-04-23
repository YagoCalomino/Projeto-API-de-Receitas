using recipes_api.Models;
using System.Collections.Generic;
using System.Linq;

namespace recipes_api.Services;

public class UserService : IUserService
{
    public readonly List<User> users;

    public UserService()
    {
        this.users = new List<User>
        {
            new User { 
                Email = "pessoa@betrybe.com",
                Name = "Pessoa tryber",
                Password = "senhaTryber"}
        };
    }

    public void AddUser(User user)
    {        
        this.users.Add(user);                
    }

    public void DeleteUser(string email)
    {        
        var toRemove = this.users.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
        this.users.Remove(toRemove);              
    }

    public void UpdateUser(User item)
    {
        var toUpdate = this.users.Where(x => x.Email.ToLower() == item.Email.ToLower()).FirstOrDefault();

        toUpdate.Name = item.Name;
        toUpdate.Password = item.Password;
    }

    public bool UserExists(string email)
    {
        return this.users.Any(x => x.Email.ToLower() == email.ToLower());
    }

    public User GetUser(string email)
    {
        return this.users.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
    }

}