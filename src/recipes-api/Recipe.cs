using recipes_api.Models;
using System.Collections.Generic;

namespace recipes_api;

public class Recipe
{
    public string Name { get; set; }

    public RecipesType RecipeType { get; set; }

    public double PreparationTime { get; set; }

    public List<string> Ingredients { get; set; }

    public string Directions { get; set; }

    public int Rating { get; set; }
}
