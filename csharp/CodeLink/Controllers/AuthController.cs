using CodeLink.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeLink.Controllers
{
	public class AuthController(IAuthService authService) : Controller
	{
		private readonly IAuthService _authService = authService;

		// GET: Auth/Login
		public IActionResult Login() => View();

		// POST: Auth/Login
		[HttpPost]
		public IActionResult Login(string username, string password)
		{
			var admin = _authService.ValidateCredentials(username, password);
			if (admin != null)
			{
				HttpContext.Session.SetString("AdminUsername", admin.Username);
				return RedirectToAction("Index", "Employee");
			}
			ModelState.AddModelError(string.Empty, "Invalid username or password.");
			return View();
		}

		// GET: Auth/Logout
		public IActionResult Logout()
		{
			HttpContext.Session.Remove("AdminUsername");
			return RedirectToAction("Login");
		}
	}
}
