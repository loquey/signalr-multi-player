using Microsoft.AspNetCore.SignalR;

namespace SignalRClass.Hubs
{
    public interface IClientProxy
    {
        Task ReceiveMessage(string message);
    }

    public class UserHub(ILogger<UserHub> logger) : Hub<IClientProxy>
    {

        public async Task SendMessage(string user)
        {
           
            logger.LogInformation("Send message called");
            await Clients.All.ReceiveMessage(user);
        }

    }
}
