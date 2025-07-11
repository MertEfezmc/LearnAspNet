using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnAspNet.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        public bool ShowMessage { get; set; }

        public void OnGet()
        {
            ShowMessage = false;
        }

        public void OnPost()
        {
            ShowMessage = !string.IsNullOrWhiteSpace(Name);
        }
    }
}
