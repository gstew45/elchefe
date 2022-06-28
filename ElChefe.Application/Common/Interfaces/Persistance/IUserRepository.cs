using ElChefe.Domain.Entities;

namespace ElChefe.Application.Common.Interfaces.Persistance;

public interface IUserRepository
{
	void Add(User user);
	User? GetUserByEmail(string email);
}
