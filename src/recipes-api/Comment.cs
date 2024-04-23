using recipes_api.Models;
using System.Collections.Generic;

namespace recipes_api;

public class Comment
{
    public string Email { get; set; }
    public string RecipeName { get; set; }
    public string CommentText { get; set; }
}