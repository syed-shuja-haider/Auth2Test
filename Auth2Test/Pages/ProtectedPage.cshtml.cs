using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Auth2Test.Pages
{
    [Authorize]
    public class ProtectedPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
