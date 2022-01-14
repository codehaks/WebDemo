using Microsoft.AspNetCore.SignalR;

namespace WebApp.Hubs
{
    public class CounterHub:Hub
    {
        public void SendNumber(int number)
        {
            Clients.Others.SendAsync("UpdateNumber", number);
        }
    }
}
