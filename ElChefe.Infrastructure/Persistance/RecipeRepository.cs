using ElChefe.Application.Common.Interfaces.Persistance;
using ElChefe.Domain.Entities;

namespace ElChefe.Infrastructure.Persistance;

public class RecipeRepository : IRecipeRepository
{
	private static readonly List<Recipe> _recipes = new();

	public void Add(Recipe recipe)
	{
		_recipes.Add(recipe);
	}
	
	public Recipe? GetRecipeById(Guid id)
	{
		return _recipes.SingleOrDefault(x => x.Id == id);
	}
}