using Excalibur.Cross.ViewModels;
using Excalibur.Shared.Presentation;

namespace Excalibur.Tests.Cross.Core.ViewModels
{
    public class UserDetailViewModel : DetailViewModel<int, Observable.User, IListPresentation<int, Observable.User, Observable.User>>
    {
    }
}
