using AccommoLinkResidenceAssistance.Areas.Identity.Data;
using AccommoLinkResidenceAssistance.Constants;
using AccommoLinkResidenceAssistance.Models.SystemUsers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AccommoLinkResidenceAssistance.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AuthenticationController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUserStore<ApplicationUser> _userStore;
        private readonly IUserEmailStore<ApplicationUser> _emailStore;
        private readonly IHttpContextAccessor _contextAccessor;

        public AuthenticationController(UserManager<ApplicationUser> userManager, IUserStore<ApplicationUser> userStore, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context, ILogger<AuthenticationController> logger, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor contextAccessor)
        {
            _userManager = userManager;
            _userStore = userStore;
            _signInManager = signInManager;
            _context = context;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _contextAccessor = contextAccessor;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(ApplicationUser model)
        {
            if (model.ImageFile != null)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                //string fileName = Path.GetFileNameWithoutExtension(model.ProfilePictureImageFile.FileName);
                string fileName = model.UserName.ToLower().ToString();
                string ext = Path.GetExtension(model.ImageFile.FileName);
                model.ProfilePicture = fileName = fileName + "_" + DateTime.Now.ToString("ddMMMyyyyHHmmss") + ext;
                string path = Path.Combine(wwwRootPath + "/img/uploads", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await model.ImageFile.CopyToAsync(fileStream);
                }
            }
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    Password = model.Password,
                    ConfirmPassword = model.ConfirmPassword,
                    CreatedOn = model.CreatedOn,
                    UserRole = model.UserRole,
                    ProfilePicture = model.ProfilePicture,
                    Status = model.Status
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, RoleConstants.Student);
                    await _context.SaveChangesAsync();
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    _logger.LogInformation("User created a new account with password.");
                    if(user.UserRole == UserRole.Student)
                    {
                        return RedirectToAction("Create", "Student");
                    }
                    else if(user.UserRole == UserRole.University)
                    {
                        return RedirectToAction("Create", "University");
                    }
                    else if(user.UserRole == UserRole.Landlord)
                    {
                        return RedirectToAction("Create", "Landlord");
                    }
                    else
                    {
                        return NotFound("User Role not found. Please sspecify a user role or contact system administrator.");
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }

        //[AllowAnonymous]
        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}
        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> Register(ApplicationUser model)
        //{
        //    if (model.ImageFile != null)
        //    {
        //        string wwwRootPath = _webHostEnvironment.WebRootPath;
        //        //string fileName = Path.GetFileNameWithoutExtension(model.ProfilePictureImageFile.FileName);
        //        string fileName = model.UserName.ToLower().ToString();
        //        string ext = Path.GetExtension(model.ImageFile.FileName);
        //        model.ProfilePicture = fileName = fileName + "_" + DateTime.Now.ToString("ddMMMyyyyHHmmss") + ext;
        //        string path = Path.Combine(wwwRootPath + "/img/uploads", fileName);
        //        using (var fileStream = new FileStream(path, FileMode.Create))
        //        {
        //            await model.ImageFile.CopyToAsync(fileStream);
        //        }
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        var user = new ApplicationUser
        //        {
        //            UserName = model.UserName,
        //            Name = model.Name,
        //            Email = model.Email,
        //            PhoneNumber = model.PhoneNumber,
        //            Password = model.Password,
        //            ConfirmPassword = model.ConfirmPassword,
        //            CreatedOn = model.CreatedOn,
        //            UserRole = model.UserRole,
        //            ProfilePicture = model.ProfilePicture,
        //            Status = false
        //        };

        //        var result = await _userManager.CreateAsync(user, model.Password);
        //        if (result.Succeeded)
        //        {
        //            await _userManager.AddToRoleAsync(user, RoleConstants.Student);
        //            await _context.SaveChangesAsync();
        //            await _signInManager.SignInAsync(user, isPersistent: false);
        //            _logger.LogInformation("User created a new account with password.");
        //            if(user.UserRole == UserRole.Student)
        //            {
        //                return RedirectToAction("Create", "Student");
        //            }
        //            else if(user.UserRole == UserRole.University)
        //            {
        //                return RedirectToAction("Create", "University");
        //            }
        //            else if(user.UserRole == UserRole.Landlord)
        //            {
        //                return RedirectToAction("Create", "Landlord");
        //            }
        //            else
        //            {
        //                return NotFound();
        //            }
        //        }
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError(string.Empty, error.Description);
        //        }
        //    }
        //    return View(model);
        //}
    }
}
