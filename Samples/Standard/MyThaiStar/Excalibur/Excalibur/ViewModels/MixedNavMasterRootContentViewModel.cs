using Excalibur.Cross.ViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;


namespace MyThaiStar.Core.ViewModels
{
    public class MixedNavMasterRootContentViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MixedNavMasterRootContentViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ShowModalCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<DishListViewModel>());
        }

        public IMvxAsyncCommand ShowModalCommand { get; private set; } 
    }
}
