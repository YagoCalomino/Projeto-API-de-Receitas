using recipes_api.Models;
using System.Collections.Generic;

namespace recipes_api.Services;

public interface ICommentService
{
    void AddComment(Comment comment);
    List<Comment> GetComments(string recipeName);
}