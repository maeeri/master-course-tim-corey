using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMessageWall2.Pages
{
    public class MessageWallModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();

        public MessageWallModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("MessageWall");
            }
            return Page();
        }
    }
}
