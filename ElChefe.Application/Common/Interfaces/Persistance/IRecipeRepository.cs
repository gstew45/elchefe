using ElChefe.Domain.Entities;

namespace ElChefe.Application.Common.Interfaces.Persistance;

public interface IRecipeRepository
{
	void Add(Recipe user);
	Recipe? GetRecipeById(Guid id);
}