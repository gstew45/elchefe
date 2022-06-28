namespace ElChefe.Application.Services.Recipes;

public interface IRecipeService
{
	RecipeResult Create(string name, string description);
}