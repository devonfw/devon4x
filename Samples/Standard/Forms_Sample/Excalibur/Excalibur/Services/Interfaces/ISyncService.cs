using System.Threading.Tasks;

namespace Excalibur.Services.Interfaces
{    public interface ISyncService
    {
        Task FullSyncAsync();
        Task PartialSyncAsync();
    }
}
