using Microsoft.AspNetCore.Mvc;
using recipes_api.Services;
using recipes_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace recipes_api.Controllers;

[ApiController]
[Route("comment")]
public class CommentController : ControllerBase
{  
    public readonly ICommentService _service;
    
    public CommentController(ICommentService service)
    {
        this._service = service;        
    }

    // 10 - Sua aplicação deve ter o endpoint POST /comment
    [HttpPost]
    public IActionResult Create([FromBody] Comment comment)
    {
        if (comment == null)
        {
            return BadRequest("Comentário não pode ser nulo.");
        }

        try
        {
            _service.AddComment(comment);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao adicionar o comentário: {ex.Message}");
        }

        return CreatedAtRoute("GetComment", new { name = comment.RecipeName }, comment);
    }

    // 11 - Sua aplicação deve ter o endpoint GET /comment/:recipeName
    [HttpGet("{name}", Name = "GetComment")]
    public IActionResult Get(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return BadRequest("Nome não pode ser nulo ou vazio.");
        }

        List<Comment> comments;
        
        try
        {
            comments = _service.GetComments(name);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao buscar os comentários: {ex.Message}");
        }

        return Ok(comments);
    }
}