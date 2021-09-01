using CrmWebUi.EmailService;
using CrmWebUi.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrmWebUi.Controllers
{
    public class AccountController : Controller
    {
        private IEmailService _mailService;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public AccountController(IEmailService mailService, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _mailService = mailService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            IdentityUser user = new IdentityUser()
            {
                UserName = model.userName,
                Email = model.Email,

            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                //email token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });

                await _mailService.SendEmail(model.Email, "Hesabınızı Onaylayın", $"Linke <a href='https://localhost:44386{url}'>Tıkla</a>");

                return RedirectToAction("index", "company");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                    ModelState.AddModelError("", error.Description);
                return View();
            }





        }
        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new Login()
            {
                ReturnUrl = ReturnUrl
            });
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.userName);
            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı Adı Bulunamadı");
                return View(model);
            }


            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Lütfen Email gelen linki doğrulayınız");
                return View(model);
            }


            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);//cokie lockout son ikili
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }
            ModelState.AddModelError("", "Şifre Yanlış");
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/company/index");
        }


        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                ViewBag.hata = "Geçersiniz Token";
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    return View();
                }
            }
            return View();
        }






    }
}
