using Microsoft.AspNetCore.SignalR;

namespace Donezo.Web.Hubs;

public class CollaborationHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("Recieved Message", user, message);
    }
}