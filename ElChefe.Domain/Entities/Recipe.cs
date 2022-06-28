namespace ElChefe.Domain.Entities;

public class Recipe
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Name { get; set; } = null!;
	public string Description { get; set; } = null!;
}