using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using System;
using recipes_api;
using recipes_api.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Diagnostics;
using System.Xml;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace recipes_api.Test.Test;

public class TestReq1 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq1(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "1. Desenvolva o endpoint GET /recipe")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 200")]
    [InlineData("/recipe")]
    public async Task TestRecipeController(string url)
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
    }

    [Trait("Category", "1. Desenvolva o endpoint GET /recipe")]
    [Theory(DisplayName = "Será validado que a resposta um array de objetos")]
    [InlineData("/recipe")]
    public async Task TestRecipeControllerResponse(string url)
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        var responseString = await response.Content.ReadAsStringAsync();
        List<Recipe>? jsonResponse = JsonConvert.DeserializeObject<List<Recipe>>(responseString);
        Assert.Contains("Bolo de cenoura", jsonResponse[0].Name);
        Assert.Contains("Coxinha", jsonResponse[1].Name);
    }

}

public class TestReq2 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq2(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "2. Desenvolva o endpoint GET /recipe/:name")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 200")]
    [InlineData("/recipe/coxinha")]
    public async Task TestRecipeController(string url)
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
    }

    [Trait("Category", "2. Desenvolva o endpoint GET /recipe/:name")]
    [Theory(DisplayName = "Será validado que a resposta será um objeto")]
    [InlineData("/recipe/coxinha", "coxinha")]
    public async Task TestRecipeControllerResponse(string url, string name)
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        var responseString = await response.Content.ReadAsStringAsync();
        Recipe jsonResponse = JsonConvert.DeserializeObject<Recipe>(responseString);
        Assert.Contains(name.ToLower(), jsonResponse.Name.ToLower());
    }
}


public class TestReq3 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq3(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "3. Desenvolva o endpoint POST /recipe")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 201")]
    [InlineData("/recipe")]
    public async Task TestRecipeController(string url)
    {
        var inputObj = new Recipe { 
                        Name = "Cocada", 
                        RecipeType = RecipesType.sweet, 
                        PreparationTime = 1.3, 
                        Ingredients = new List<string> {"2 xícaras de coco fresco ralado grosso", "1 xícara de açúcar refinado ou cristal", " meia xícara de água (120 mililitros)"},
                        Directions = "Separe os 3 ingredientes da sua cocada de antigamente: água, coco ralado fresco ralado grosso e açúcar. Em uma panela misture o açúcar e a água.",
                        Rating = 4
        };

        var client = _factory.CreateClient();
        var response = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        Assert.Equal(System.Net.HttpStatusCode.Created, response?.StatusCode);
    }

    [Trait("Category", "3. Desenvolva o endpoint POST /recipe")]
    [Theory(DisplayName = "Será validado que a resposta será igual ao objeto criado")]
    [InlineData("/recipe")]
    public async Task TestRecipeControllerResponse(string url)
    {
        var inputObj = new Recipe { 
                        Name = "Cocada", 
                        RecipeType = RecipesType.sweet, 
                        PreparationTime = 1.3, 
                        Ingredients = new List<string> {"2 xícaras de coco fresco ralado grosso", "1 xícara de açúcar refinado ou cristal", " meia xícara de água (120 mililitros)"},
                        Directions = "Separe os 3 ingredientes da sua cocada de antigamente: água, coco ralado fresco ralado grosso e açúcar. Em uma panela misture o açúcar e a água.",
                        Rating = 4
        };

        var client = _factory.CreateClient();
        var response = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        var responseString = await response.Content.ReadAsStringAsync();
        Recipe? jsonResponse = JsonConvert.DeserializeObject<Recipe>(responseString);
        Assert.Equal(inputObj.Name, jsonResponse.Name);
        Assert.Equal(inputObj.RecipeType, jsonResponse.RecipeType);
        Assert.Equal(inputObj.PreparationTime, jsonResponse.PreparationTime);
        Assert.Equal(inputObj.Directions, jsonResponse.Directions);
        Assert.Equal(inputObj.Rating, jsonResponse.Rating);

    }
}


public class TestReq4 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq4(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "4. Desenvolva o endpoint PUT /recipe")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 200")]
    [InlineData("/recipe/coxinha")]
    public async Task TestRecipeController(string url)
    {
        var inputObj = new Recipe { 
                        Name = "Coxinha", 
                        RecipeType = RecipesType.salty, 
                        PreparationTime = 1.3, 
                        Ingredients = new List<string> {"2 xícaras de coco fresco ralado grosso", "1 xícara de açúcar refinado ou cristal", " meia xícara de água (120 mililitros)"},
                        Directions = "Separe os 3 ingredientes da sua cocada de antigamente: água, coco ralado fresco ralado grosso e açúcar. Em uma panela misture o açúcar e a água.",
                        Rating = 4
        };

        var client = _factory.CreateClient();
        var response = await client.PutAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        Assert.Equal(System.Net.HttpStatusCode.NoContent, response?.StatusCode);
    }

    [Trait("Category", "4. Desenvolva o endpoint PUT /recipe")]
    [Theory(DisplayName = "Será validado que a resposta será um status bad request")]
    [InlineData("/recipe/coxinha")]
    public async Task TestRecipeControllerError(string url)
    {
        var inputObj = new Recipe { 
                        Name = "Coxinhas", 
                        RecipeType = RecipesType.salty, 
                        PreparationTime = 1.3, 
                        Ingredients = new List<string> {"2 xícaras de coco fresco ralado grosso", "1 xícara de açúcar refinado ou cristal", " meia xícara de água (120 mililitros)"},
                        Directions = "Separe os 3 ingredientes da sua cocada de antigamente: água, coco ralado fresco ralado grosso e açúcar. Em uma panela misture o açúcar e a água.",
                        Rating = 4
        };

        var client = _factory.CreateClient();
        var response = await client.PutAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        Assert.Equal(System.Net.HttpStatusCode.BadRequest, response?.StatusCode);
    }

}

public class TestReq5 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq5(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "5. Desenvolva o endpoint DEL /recipe")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 204")]
    [InlineData("/recipe/coxinha")]
    public async Task TestRecipeController(string url)
    {

        var client = _factory.CreateClient();
        var response = await client.DeleteAsync(url);
        Assert.Equal(System.Net.HttpStatusCode.NoContent, response?.StatusCode);
    }

}

public class TestReq6 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq6(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "6. Desenvolva o endpoint GET /user/:email")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 200")]
    [InlineData("/user/pessoa@betrybe.com")]
    public async Task TestUserController(string url)
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
    }

    [Trait("Category", "6. Desenvolva o endpoint GET /user/:email")]
    [Theory(DisplayName = "Será validado que a resposta será um objeto")]
    [InlineData("/user/pessoa@betrybe.com", "pessoa@betrybe.com")]
    public async Task TestUserControllerResponse(string url, string name)
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        var responseString = await response.Content.ReadAsStringAsync();
        User? jsonResponse = JsonConvert.DeserializeObject<User>(responseString);
        Assert.Contains(name.ToLower(), jsonResponse?.Email.ToLower());
    }


    [Trait("Category", "6. Desenvolva o endpoint GET /user/:email")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 404 caso não encontrado")]
    [InlineData("/user/pessoa@betrybe.coms")]
    public async Task TestUserControllerError(string url)
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        Assert.Equal(System.Net.HttpStatusCode.NotFound, response?.StatusCode);
    }
}


public class TestReq7 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq7(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }


    [Trait("Category", "7. Desenvolva o endpoint POST /user")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 201")]
    [InlineData("/user")]
    public async Task TestUserController(string url)
    {
        var inputObj = new User { 
                        Email = "maria.silva@betrybe.com", 
                        Name = "Maria",
                        Password = "senhaDaMaria"
        };

        var client = _factory.CreateClient();
        var response = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        Assert.Equal(System.Net.HttpStatusCode.Created, response?.StatusCode);
    }

    [Trait("Category", "7. Desenvolva o endpoint POST /user")]
    [Theory(DisplayName = "Será validado que a resposta será igual ao objeto criado")]
    [InlineData("/user")]
    public async Task TestUserControllerResponse(string url)
    {
         var inputObj = new User { 
                        Email = "maria.silva@betrybe.com", 
                        Name = "Maria",
                        Password = "senhaDaMaria"
        };

        var client = _factory.CreateClient();
        var response = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        var responseString = await response.Content.ReadAsStringAsync();
        User? jsonResponse = JsonConvert.DeserializeObject<User>(responseString);
        Assert.Equal(inputObj.Name, jsonResponse?.Name);
        Assert.Equal(inputObj.Email, jsonResponse?.Email);
        Assert.Equal(inputObj.Password, jsonResponse?.Password);

    }

}



public class TestReq8 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq8(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }


    [Trait("Category", "8. Desenvolva o endpoint PUT /user")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 200")]
    [InlineData("/user/pessoa@betrybe.com")]
    public async Task TestUserController(string url)
    {
        var inputObj = new User { 
                        Name = "Maria", 
                        Email = "pessoa@betrybe.com",
                        Password = "senhaDaMaria"
        };

        var client = _factory.CreateClient();
        var response = await client.PutAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        Assert.Equal(System.Net.HttpStatusCode.OK, response?.StatusCode);
    }

    [Trait("Category", "8. Desenvolva o endpoint PUT /user")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 200")]
    [InlineData("/user/pessoa@betrybe.com")]
    public async Task TestUserControllerError(string url)
    {
        var inputObj = new User { 
                        Name = "maria@betrybe.com", 
                        Email = "Maria",
                        Password = "senhaDaMaria"
        };

        var client = _factory.CreateClient();
        var response = await client.PutAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        Assert.Equal(System.Net.HttpStatusCode.BadRequest, response?.StatusCode);
    }

    [Trait("Category", "8. Desenvolva o endpoint PUT /user")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 400")]
    [InlineData("/user/pessoa@betrybe.com")]
    public async Task TestUserControllerErrorBadRequest(string url)
    {
        var inputObj = new User { 
                        Name = "Maria", 
                        Email = "pessoam@betrybe.com",
                        Password = "senhaDaMaria"
        };

        var client = _factory.CreateClient();
        var response = await client.PutAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        Assert.Equal(System.Net.HttpStatusCode.BadRequest, response?.StatusCode);
    }


    [Trait("Category", "8. Desenvolva o endpoint PUT /user")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 404")]
    [InlineData("/user/pessoa.inexistente@betrybe.com")]
    public async Task TestUserControllerErrorNotFound(string url)
    {
        var inputObj = new User { 
                        Name = "Maria", 
                        Email = "pessoa.inexistente@betrybe.com",
                        Password = "senhaDaMaria"
        };

        var client = _factory.CreateClient();
        var response = await client.PutAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        Assert.Equal(System.Net.HttpStatusCode.NotFound, response?.StatusCode);
    }
}


public class TestReq9 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq9(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "9. Desenvolva o endpoint DEL /user")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 204")]
    [InlineData("/user/pessoa@betrybe.com")]
    public async Task TestUserController(string url)
    {

        var client = _factory.CreateClient();
        var response = await client.DeleteAsync(url);
        Assert.Equal(System.Net.HttpStatusCode.NoContent, response?.StatusCode);
    }

    [Trait("Category", "9. Desenvolva o endpoint DEL /user")]
    [Theory(DisplayName = "Será validado que não é possivel excluir uma pessoa usuária inexistente")]
    [InlineData("/user/pessoas@betrybe.com")]
    public async Task TestUserControllerError(string url)
    {

        var client = _factory.CreateClient();
        var response = await client.DeleteAsync(url);
        Assert.Equal(System.Net.HttpStatusCode.NotFound, response?.StatusCode);
    }


}

public class TestReq10 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq10(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }


    [Trait("Category", "10. Desenvolva o endpoint POST /comment")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 201")]
    [InlineData("/comment")]
    public async Task TestCommentController(string url)
    {
        var inputObj = new Comment { 
                        Email = "pessoa@betrybe.com", 
                        RecipeName = "Coxinha",
                        CommentText = "Fiz a receita de Coxinha na minha casa. Fiz o passo a passo e saiu certinho."
        };

        var client = _factory.CreateClient();
        var response = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        Assert.Equal(System.Net.HttpStatusCode.Created, response?.StatusCode);
    }

    [Trait("Category", "10. Desenvolva o endpoint POST /comment")]
    [Theory(DisplayName = "Será validado que a resposta será igual ao objeto criado")]
    [InlineData("/comment")]
    public async Task TestCommentControllerResponse(string url)
    {
        var inputObj = new Comment { 
                        Email = "pessoa@betrybe.com", 
                        RecipeName = "Coxinha",
                        CommentText = "Fiz a receita de Coxinha na minha casa. Fiz o passo a passo e saiu certinho."
        };


        var client = _factory.CreateClient();
        var response = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(inputObj), System.Text.Encoding.UTF8, "application/json"));
        var responseString = await response.Content.ReadAsStringAsync();
        Comment? jsonResponse = JsonConvert.DeserializeObject<Comment>(responseString);
        Assert.Equal(inputObj.RecipeName, jsonResponse?.RecipeName);
        Assert.Equal(inputObj.Email, jsonResponse?.Email);
        Assert.Equal(inputObj.CommentText, jsonResponse?.CommentText);

    }

}


public class TestReq11 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public TestReq11(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Trait("Category", "11. Desenvolva o endpoint GET /comment/:recipeName")]
    [Theory(DisplayName = "Será validado que a resposta será um status http 200")]
    [InlineData("/comment/coxinha")]
    public async Task TestCommentController(string url)
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
    }

}
