using Excalibur.Shared.Business;
using System.Threading.Tasks;

namespace Excalibur.Business.Interfaces
{
    public interface ILoggedInUser : ISingleBusiness<Domain.LoggedInUser>
    {
        Task Store(Domain.LoggedInUser user);
    }
}
