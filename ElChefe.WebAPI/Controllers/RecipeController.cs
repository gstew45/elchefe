using ElChefe.Application.Services.Recipes;
using ElChefe.Contracts.Recipes;
using Microsoft.AspNetCore.Mvc;

namespace ElChefe.WebAPI.Controllers;

[ApiController]
[Route("recipe")]
public class RecipeController : ControllerBase
{
	private readonly IRecipeService _recipeService;

	public RecipeController(IRecipeService recipeService)
	{
		_recipeService = recipeService;
	}
	
	[HttpPost("add")]
	public IActionResult Create([FromBody] RecipeRequest request)
	{
		RecipeResult recipeResult = _recipeService.Create(request.Name, request.Description);

		var response = new RecipeResponse(recipeResult.Id, recipeResult.Name, recipeResult.Description);
		
		return Ok(response);
	}
}