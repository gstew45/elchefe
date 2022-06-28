using ElChefe.Application.Services.Recipes;
using ElChefe.Domain.Entities;
using ElChefe.Infrastructure.Persistance;
using FluentAssertions;
using FluentAssertions.Execution;

namespace ElChefe.Application.Integration.Tests;

public class RecipeServiceTests
{
	private RecipeService _testSubject = null!;
	private RecipeRepository _recipeRepository = null!;
	
	[SetUp]
	public void Setup()
	{
		_recipeRepository = new RecipeRepository();
		_testSubject = new RecipeService(_recipeRepository);
	}

	[Test]
	public void Create_WithNameAndDescription_ReturnsRecipeResult()
	{
		// Arrange
		const string name = "Chicken Tikka Masala";
		const string description = "A masala curry dish with marinated tikka chicken pieces in a creamy yogurt sauce.";
		
		// Act
		RecipeResult result = _testSubject.Create(name, description);
		
		// Assert
		result.Name.Should().Be(name);
		result.Description.Should().Be(description);
	}

	[Test]
	public void Create_WithNameAndDescription_RecipeCreatedInRepository()
	{
		// Arrange
		const string name = "Chicken Tikka Masala";
		const string description = "A masala curry dish with marinated tikka chicken pieces in a creamy yogurt sauce.";
		
		// Act
		RecipeResult result = _testSubject.Create(name, description);
		Recipe? recipe = _recipeRepository.GetRecipeById(result.Id);
		
		// Assert
		using (var scope = new AssertionScope())
		{
			recipe.Should().NotBeNull();
			recipe?.Id.Should().Be(result.Id);
			recipe?.Name.Should().Be(name);
			recipe?.Description.Should().Be(description);
		}
	}
}