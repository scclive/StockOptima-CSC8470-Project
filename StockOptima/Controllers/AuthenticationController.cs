using System.Security.Claims;
using System.Threading.Tasks;
using StockOptima.Models.Database;
using StockOptima.Operations;
using StockOptima.Services.Database;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StockOptima.Controllers
{
    /// <summary>
    /// Handles user authentication including login, logout, and authentication validation.
    /// </summary>
    public class AuthenticationController : Controller
    {
        private readonly UsersService _usersService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationController"/> class.
        /// </summary>
        /// <param name="usersService">Service for accessing user data.</param>
        public AuthenticationController(UsersService usersService)
        {
            _usersService = usersService;
        }

        /// <summary>
        /// Authenticates a user based on provided name and password.
        /// </summary>
        /// <param name="name">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>A redirection to the home page if successful, or the login page with an error message if unsuccessful.</returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("auth")]
        public async Task<IActionResult> Authenticate([FromForm] string name, [FromForm] string password)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
                return RedirectToFailedLogin();

            // Attempt to retrieve user
            User user = await _usersService.GetByNameAndPassword(name, password);
            if (user is null) return RedirectToFailedLogin();

            // Create user claims
            ClaimsIdentity claimsIdentity = new(new Claim[]
            {
                new(ClaimTypes.Name, user.Name),
                new(ClaimTypes.Role, user.Role)
            }, CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal claimsPrincipal = new(new[]
            {
                claimsIdentity
            });

            // Sign in the user
            await HttpContext.SignInAsync(claimsPrincipal);

            // Redirect to the home page
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Redirects to the login page with a failure message.
        /// </summary>
        /// <returns>A view representing the login page with an error message.</returns>
        private IActionResult RedirectToFailedLogin()
        {
            return View("Login", new MessageOperation("Wrong username or password"));
        }

        /// <summary>
        /// Returns the login view.
        /// </summary>
        /// <returns>A view representing the login page.</returns>
        [HttpGet]
        [AllowAnonymous]
        [Route("login")]
        public IActionResult Login()
        {
            return View(MessageOperation.Empty);
        }

        /// <summary>
        /// Logs out the current user.
        /// </summary>
        /// <returns>A redirection to the login page.</returns>
        [HttpGet]
        [Authorize]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            // Sign out the user
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Authentication");
        }
    }
}
