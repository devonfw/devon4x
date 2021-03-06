using Excalibur.Cross.ViewModels;
using Excalibur.Shared.Presentation;

namespace Excalibur.ViewModels
{
    public class CurrentUserViewModel : DetailViewModel<int, Observable.LoggedInUser, ISinglePresentation<int, Observable.LoggedInUser>>
    {
    }
}
