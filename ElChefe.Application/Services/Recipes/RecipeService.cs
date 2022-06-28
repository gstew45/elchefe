using ElChefe.Application.Common.Interfaces.Persistance;
using ElChefe.Domain.Entities;

namespace ElChefe.Application.Services.Recipes;

public class RecipeService : IRecipeService
{
	private readonly IRecipeRepository _recipeRepository;

	public RecipeService(IRecipeRepository recipeRepository)
	{
		_recipeRepository = recipeRepository;
	}
	
	public RecipeResult Create(string name, string description)
	{
		var recipe = new Recipe()
		{
			Name = name,
			Description = description
		};

		_recipeRepository.Add(recipe);
		
		return new RecipeResult(recipe.Id, recipe.Name, recipe.Description);
	}
}