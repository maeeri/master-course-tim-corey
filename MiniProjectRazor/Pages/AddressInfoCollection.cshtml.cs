using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MiniProjectRazor.Pages
{
    public class AddressInfoCollectionModel : PageModel
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        [BindProperty]
        public Address address { get; set; }
        public List<Address> addresses = new List<Address>();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("/Index");
        }

        public struct Address(string streetAddress, string city, string postalCode)
        {
            public string streetAddress;
            public string city;
            public string postalCode;
        }
    }
}
