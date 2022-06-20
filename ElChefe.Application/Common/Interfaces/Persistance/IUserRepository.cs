using ElChefe.Domain.Entities;

namespace ElChefe.Application.Common.Interfaces.Persistance;

public interface IUserRepository
{
	User? GetUserByEmail(string email);
	void Add(User user);
}
