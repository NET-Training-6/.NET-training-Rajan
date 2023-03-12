using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WorkforceManagement.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public IActionResult Roles()
        {
            //RoleManager<>
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);
            return RedirectToAction("Roles");
        }

        public IActionResult Users()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        public async Task<IActionResult> AssignRole(string userId)
        {            
            var user = await _userManager.FindByIdAsync(userId);
            var allRoles = _roleManager.Roles.ToList();

            var assignedUserRoles = await _userManager.GetRolesAsync(user) as List<string>;
            return View((user, assignedUserRoles, allRoles));
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(string userId, string[] roles)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.AddToRolesAsync(user, roles);

            return RedirectToAction("Users");
        }
    }
}
