using recipes_api.Models;
using System.Collections.Generic;
using System.Linq;

namespace recipes_api.Services;

public class RecipeService : IRecipeService
{
    public readonly List<Recipe> recipes;

    public RecipeService()
    {
        this.recipes = new List<Recipe>
        {
            new Recipe { Name = "Bolo de cenoura", 
                        RecipeType = RecipesType.sweet, 
                        PreparationTime = 0.4, 
                        Ingredients = new List<string> {"1/2 xícara (chá) de óleo", "3 cenouras médias raladas", "4 ovos", "2 xícaras (chá) de açúcar", "2 e 1/2 xícaras (chá) de farinha de trigo", "1 colher (sopa) de fermento em pó"},
                        Directions = "Em um liquidificador, adicione a cenoura, os ovos e o óleo, depois misture. Acrescente o açúcar e bata novamente por 5 minutos. Em uma tigela ou na batedeira, adicione a farinha de trigo e depois misture novamente. Acrescente o fermento e misture lentamente com uma colher. Asse em um forno preaquecido a 180° C por aproximadamente 40 minutos.",
                        Rating = 10},
            new Recipe { Name = "Coxinha", 
                        RecipeType = RecipesType.salty, 
                        PreparationTime = 0.4, 
                        Ingredients = new List<string> {"4 xícaras de trigo", "4 xícaras de leite", "1 caldo de galinha", "1/2 colher de margarina"},
                        Directions = "Leve ao fogo o leite, a margarina e o caldo. Deixe ferver. Despeje de uma só vez o trigo e mexa bem. Depois retire da panela e coloque sobre a mesa. Sove um pouco e comece a modelar as coxinhas. Coloque para fritar em óleo quente, espere dourar, retire e sirva.",
                        Rating = 7},
            new Recipe { Name = "Pudim de Leite", 
                        RecipeType = RecipesType.sweet, 
                        PreparationTime = 1.1, 
                        Ingredients = new List<string> {"1 xícara (chá) de açúcar", "1 lata de leite condensado", "2 latas de leite (medida da lata de leite condensado)", "3 ovos"},
                        Directions = "Bata todos os ingredientes do pudim no liquidificador e despeje na forma reservada. Asse em banho-maria, em forno médio (180º C), por cerca de 1 hora e 30 minutos. Depois de frio, leve para gelar por cerca de 6 horas. Desenforme e sirva a seguir.",
                        Rating = 9}                        
        };
    }

    public void AddRecipe(Recipe item)
    {        
        this.recipes.Add(item);                
    }

    public void DeleteRecipe(string name)
    {
        var toRemove = this.recipes.Where(x => x.Name.ToLower() == name.ToLower()).FirstOrDefault();
        this.recipes.Remove(toRemove);
    }

    public bool RecipeExists(string name)
    {
        return this.recipes.Any(x => x.Name.ToLower() == name.ToLower());
    }

    public Recipe GetRecipe(string name)
    {
        return this.recipes.Where(x => x.Name.ToLower() == name.ToLower()).FirstOrDefault();
    }

    public List<Recipe> GetRecipes()
    {        
        return this.recipes.ToList();
    }

    public void UpdateRecipe(Recipe item)
    {
        var toUpdate = this.recipes.Where(x => x.Name.ToLower() == item.Name.ToLower()).FirstOrDefault();

        toUpdate.Name = item.Name;
        toUpdate.RecipeType = item.RecipeType;
        toUpdate.PreparationTime = item.PreparationTime;
        toUpdate.Ingredients = item.Ingredients;
        toUpdate.Directions = item.Directions;
        toUpdate.Rating = item.Rating;
    }
}
