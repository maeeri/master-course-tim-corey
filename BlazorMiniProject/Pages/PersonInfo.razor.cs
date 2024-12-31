using BlazorMiniProject.Models;

namespace BlazorMiniProject.Pages
{
    public partial class PersonInfo
    {
        Person model = new();
        private List<Person> people = new();
        private void ValidSubmit()
        {
            people.Add(model);
            model = new();
        }
    }
}