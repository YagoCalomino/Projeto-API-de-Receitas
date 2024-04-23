using recipes_api.Models;
using recipes_api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IRecipeService, RecipeService>();
builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<ICommentService, CommentService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }