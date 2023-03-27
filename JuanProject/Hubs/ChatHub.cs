using JuanProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace JuanProject.Hubs
{
    public class ChatHub:Hub
    {

        private readonly UserManager<AppUser> _userManager;


        public ChatHub(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user, message);
        }

        public override Task OnConnectedAsync()
        {
            if (Context.User.Identity.IsAuthenticated)
            {
                AppUser user = _userManager.FindByNameAsync(Context.User.Identity.Name).Result;
                user.ConnectionId = Context.ConnectionId;
            }
            return base.OnConnectedAsync();
        }

    }
}
