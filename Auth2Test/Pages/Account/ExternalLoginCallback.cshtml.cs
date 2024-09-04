using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Auth2Test.Pages.Account
{
    public class ExternalLoginCallbackModel : PageModel
    {
        public async Task OnGetAsync()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            if (result.Succeeded)
            {
                // Use the access token or user information as needed
                // Redirect to the home page or wherever you want
                Response.Redirect("/");
            }
            else
            {
                // Handle failure
                Response.Redirect("/Error");
            }
        }
    }
}
