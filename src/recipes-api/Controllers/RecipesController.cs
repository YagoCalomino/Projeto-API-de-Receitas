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
[Route("recipe")]
public class RecipesController : ControllerBase
{    
    public readonly IRecipeService _service;
    
    public RecipesController(IRecipeService service)
    {
        this._service = service;        
    }

    // 1 - Sua aplicação deve ter o endpoint GET /recipe
    //Read
    [HttpGet]
    public IActionResult GetRecipe()
    {
        IActionResult result;
        try
        {
            var recipes = _service.GetRecipes();
            result = Ok(recipes);
        }
        catch (Exception ex)
        {
            result = StatusCode(500, $"Erro ao buscar as receitas: {ex.Message}");
        }
        return result;
    }


    // 2 - Sua aplicação deve ter o endpoint GET /recipe/:name
    //Read
    [HttpGet("{name}", Name = "GetRecipe")]
    public IActionResult GetRecipe(string name)
    {
        IActionResult result;
        try
        {
            var recipe = _service.GetRecipe(name); 

            if (recipe == null)
            {
                result = NotFound();
            }
            else
            {
                result = Ok(recipe);
            }
        }
        catch (Exception ex)
        {
            result = StatusCode(500, $"Erro ao buscar a receita: {ex.Message}");
        }
        return result;
    }


    // 3 - Sua aplicação deve ter o endpoint POST /recipe
    [HttpPost]
    public IActionResult Post([FromBody] Recipe recipe)
    {
        IActionResult result;
        try
        {
            if (recipe == null)
            {
                result = BadRequest("O corpo da requisição não pode estar vazio");
            }
            else
            {
                _service.AddRecipe(recipe);
                result = CreatedAtAction(nameof(GetRecipe), new { name = recipe.Name }, recipe);
            }
        }
        catch (Exception ex)
        {
            result = StatusCode(500, $"Erro ao adicionar a receita: {ex.Message}");
        }
        return result;
    }

    // 4 - Sua aplicação deve ter o endpoint PUT /recipe
    [HttpPut("{name}")]
    public IActionResult Update(string name, [FromBody] Recipe recipe)
    {
        IActionResult result;
        try
        {
            if (recipe == null)
            {
                result = BadRequest("Recipe is null.");
            }
            else
            {
                var existentRecipe = _service.RecipeExists(name);
                if (!existentRecipe)
                {
                    result = NotFound("Recipe not found");
                }
                else
                {
                    _service.UpdateRecipe(recipe);
                    result = NoContent();
                }
            }
        }
        catch (Exception ex)
        {
            result = BadRequest(ex.Message);
        }
        return result;
    }

    // 5 - Sua aplicação deve ter o endpoint DEL /recipe
    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        IActionResult result;
        try
        {
            if (!_service.RecipeExists(name))
            {
                result = NotFound($"A receita com o nome '{name}' não foi encontrada");
            }
            else
            {
                _service.DeleteRecipe(name);
                result = NoContent();
            }
        }
        catch (Exception ex)
        {
            result = StatusCode(500, $"Erro ao excluir a receita: {ex.Message}");
        }
        return result;
    }
}
