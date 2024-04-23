using recipes_api.Models;
using System.Collections.Generic;
using System.Linq;

namespace recipes_api.Services;

public class CommentService : ICommentService
{
    public readonly List<Comment> comments;

    public CommentService()
    {
        this.comments = new List<Comment>{};
    }
    public void AddComment(Comment comment){
        this.comments.Add(comment);
    }

    public List<Comment> GetComments(string recipeName)
    {        
        return this.comments.Where(x => x.RecipeName.ToLower() == recipeName.ToLower()).ToList();
    }
}