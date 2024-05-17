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
[Route("user")]
public class UserController : ControllerBase
{    
    public readonly IUserService _service;
    
    public UserController(IUserService service)
    {
        this._service = service;        
    }

    // 6 - Sua aplicação deve ter o endpoint GET /user/:email
    [HttpGet("{email}", Name = "GetUser")]
    public IActionResult Get(string email)
    {
        IActionResult result;
        try
        {
            var user = _service.GetUser(email);
            result = user != null ? Ok(user) : NotFound() as IActionResult;
        }
        catch (Exception ex)
        {
            result = StatusCode(500, $"Erro ao buscar a pessoa usuária: {ex.Message}");
        }
        return result;
    }


    // 7 - Sua aplicação deve ter o endpoint POST /user
    [HttpPost]
    public IActionResult Create([FromBody] User user)
    {
        IActionResult result;
        try
        {
            result = user != null ? CreatedAtRoute("GetUser", new { email = user.Email }, user) : BadRequest("User is null") as IActionResult;
            if (user != null)
            {
                _service.AddUser(user);
            }
        }
        catch (Exception ex)
        {
            result = BadRequest(ex.Message);
        }
        return result;
    }


    // "8 - Sua aplicação deve ter o endpoint PUT /user
    [HttpPut("{email}")]
    public IActionResult Update(string email, [FromBody] User user)
    {
        IActionResult result;
        try
        {
            if (email != user.Email)
            {
                result = BadRequest("O e-mail na URL deve ser o mesmo que o e-mail no corpo da requisição");
            }
            else if (!_service.UserExists(email))
            {
                result = NotFound($"A pessoa usuária com o e-mail '{email}' não foi encontrada");
            }
            else
            {
                _service.UpdateUser(user);
                result = Ok(user);
            }
        }
        catch (Exception ex)
        {
            result = StatusCode(500, $"Erro ao atualizar a pessoa usuária: {ex.Message}");
        }
        return result;
    }

    // 9 - Sua aplicação deve ter o endpoint DEL /user
    [HttpDelete("{email}")]
    public IActionResult Delete(string email)
    {
        throw new NotImplementedException();
    } 
}