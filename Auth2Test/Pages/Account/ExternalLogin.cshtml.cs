using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Auth2Test.Pages.Account
{
    public class ExternalLoginModel : PageModel
    {
        public IActionResult OnGet()
        {
            var redirectUrl = Url.Page("/Account/ExternalLoginCallback");
            var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }
    }
}
