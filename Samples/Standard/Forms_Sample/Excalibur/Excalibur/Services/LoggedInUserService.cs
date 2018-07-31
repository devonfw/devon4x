using Excalibur.Domain;
using Excalibur.Shared.Services;
using System;
using System.Threading.Tasks;

namespace Excalibur.Services
{
    public class LoggedInUserService : ServiceBase<LoggedInUser>
    {
        public override Task<LoggedInUser> SyncDataAsync()
        {
            throw new NotImplementedException();
        }
    }
}
