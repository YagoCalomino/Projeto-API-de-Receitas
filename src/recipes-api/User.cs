using recipes_api.Models;
using System.Collections.Generic;

namespace recipes_api;

public class User
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
}