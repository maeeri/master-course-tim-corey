using ApiDBUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson.IO;
using System.Text;
using System.Text.Json;

namespace ApiDBUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task OnGet()
        {
            //await CreateContact();
            await GetAllContacts();
        }

        public async Task GetAllContacts()
        {
            var _client = _httpClientFactory.CreateClient();
            var response = await _client.GetAsync("https://localhost:7246/api/contacts");
            List<ContactModel> contacts = null;
            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                var content = await response.Content.ReadAsStringAsync();
                contacts = JsonSerializer.Deserialize<List<ContactModel>>(content, options);
            }
        }

        private async Task CreateContact()
        {
            ContactModel contact = new ContactModel
            {
                FirstName = "Mae",
                LastName = "E",
            };
            contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "..." });
            contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "000" });
            var _client = _httpClientFactory.CreateClient();
            var response = await _client.PostAsync(
                "https://localhost:7246/api/contacts", 
                new StringContent(JsonSerializer.Serialize(contact), 
                Encoding.UTF8, 
                "application/json"));

        }
    }
}
