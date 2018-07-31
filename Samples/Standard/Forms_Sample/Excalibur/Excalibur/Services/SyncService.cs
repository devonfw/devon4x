using Excalibur.Domain;
using Excalibur.Services.Interfaces;
using Excalibur.Shared.Business;
using System;
using System.Threading;
using System.Threading.Tasks;
using XLabs.Ioc;

namespace Excalibur.Services
{
    public class SyncService : ISyncService
    {
        private static Timer _timer;
        private static bool _isSyncing = false;

        public SyncService()
        {
            var delayInMs = 10 * 60 * 1000; // 10 mins in milliseconds
            _timer = new Timer(CallbackAsync, null, delayInMs, delayInMs);
        }

        private async void CallbackAsync(object o)
        {
            if (_isSyncing) return;
            _isSyncing = true;

            await PartialSyncAsync();

            _isSyncing = false;
        }

        public async Task FullSyncAsync()
        {
            try
            {
                //await Resolver.Resolve<IListBusiness<int, Dish>>().UpdateFromServiceAsync();
                await Resolver.Resolve<IListBusiness<int, User>>().UpdateFromServiceAsync();
            }
            catch (Exception ex)
            {
                var msg = $"{ex.Message} : {ex.InnerException}";
            }

        }

        public async Task PartialSyncAsync()
        {
            await Task.Delay(5000);
            await FullSyncAsync();
        }
    }
}
