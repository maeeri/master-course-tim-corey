using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MiniProjectRazor.Pages
{
    public class PersonInfoCollectionModel : PageModel
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            name = Request.Form["name"];
            phone = Request.Form["phone"];
            email = Request.Form["email"];

        }
    }
}
