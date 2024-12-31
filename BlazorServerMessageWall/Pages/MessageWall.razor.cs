using BlazorServerMessageWall.Models;

namespace BlazorServerMessageWall.Pages
{
    public partial class MessageWall
    {
        private MessageModel model = new();
        private List<string> messages = new List<string>();
        private void AddMessage()
        {
            messages.Add(model.Message);
            model = new();
        }
    }
}