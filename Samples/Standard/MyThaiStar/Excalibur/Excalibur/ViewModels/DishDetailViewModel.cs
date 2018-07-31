using System;
using Excalibur.Cross.ViewModels;
using Excalibur.Shared.Presentation;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;


using MyThaiStar.Core.Business;
using MyThaiStar.Core.Observable;
using Xamarin.Forms;

namespace MyThaiStar.Core.ViewModels
{
    //public class DishDetailViewModel : DetailViewModel<int, Observable.Dish, IListPresentation<int, Dish, Dish>>
    public class DishDetailViewModel : BaseViewModel<Observable.Dish>
    {
        public Observable.Dish DishDetail { get; set; }
        public int Quantity { get; set; }
        private IMvxNavigationService NavigationService { get; set; }


        public DishDetailViewModel(IMvxNavigationService navigationService)
        {
            Quantity = 1;
            NavigationService = navigationService;
        }

        public override void Prepare(Dish parameter)
        {
            DishDetail = parameter;
            //throw new System.NotImplementedException();
        }

        public IMvxAsyncCommand AddItemCommand
        {
            get
            {
                return new MvxAsyncCommand(async () =>
                {
                    if (DishDetail != null)
                    {
                        var item = new Observable.ShoppingCartItem {Quantity = Quantity, Dish = DishDetail};                    
                        await ((Excalibur.Views.App) Application.Current).GetShoppingKart().AddItem(item);
                    }

                    Mvx.Resolve<IMvxNavigationService>().Navigate<MasterDetailViewModel>();
                    Mvx.Resolve<IMvxNavigationService>().Navigate<DishListViewModel>();
                });
            }
        }
    }
}