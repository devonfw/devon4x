using Excalibur.Business.Interfaces;
using Excalibur.Shared.Business;
using System.Threading.Tasks;

namespace Excalibur.Business
{
    public class LoggedInUser : BaseSingleBusiness<int, Domain.LoggedInUser>, ILoggedInUser
    {
        public async Task Store(Domain.LoggedInUser user)
        {
            await StoreItemAsync(user).ConfigureAwait(false);

            PublishUpdated(user);
        }
    }
}
