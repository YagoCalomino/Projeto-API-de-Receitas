using recipes_api.Models;
using System.Collections.Generic;

namespace recipes_api.Services;

public interface IUserService
{
   void AddUser(User user);
   void DeleteUser(string email);
   void UpdateUser(User item);
   bool UserExists(string email);
   User GetUser(string email);
   
}