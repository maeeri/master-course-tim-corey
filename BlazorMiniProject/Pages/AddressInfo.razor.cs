using BlazorMiniProject.Models;

namespace BlazorMiniProject.Pages
{
    public partial class AddressInfo
    {
        Address model = new Address();
        List<Address> addresses = new();
        private void ValidSubmit()
        {
            addresses.Add(model);
            model = new();
        }
    }
}