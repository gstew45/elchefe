
using ElChefe.Application.Common.Interfaces.Persistance;
using ElChefe.Domain.Entities;

namespace ElChefe.Infrastructure.Persistance;

public class UserRepository : IUserRepository
{
	public readonly static List<User> _users = new();
	public void Add(User user)
	{
		_users.Add(user);
	}

	public User? GetUserByEmail(string email)
	{
		return _users.SingleOrDefault(x => x.Email == email);
	}
}
