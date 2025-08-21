using CodeLink.Models;

namespace CodeLink.Services
{
	public interface IAuthService
	{
		AdminUser? ValidateCredentials(string username, string password);
	}

	public class AuthService : IAuthService
	{
		private readonly List<AdminUser> _users =
		[
			new AdminUser { Username = "admin", Password = "admin123" }
		];

		public AdminUser? ValidateCredentials(string username, string password)
		{
			return _users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);
		}
	}
}
