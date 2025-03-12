using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using RealTimeMonitoring.API.Models;

namespace RealTimeMonitoring.API.Hubs
{
    public class ProductionHub : Hub
    {
        public async Task SendProductionUpdate(ProductionData data)
        {
            await Clients.All.SendAsync("ReceiveProductionUpdate", data);
        }
    }
}
