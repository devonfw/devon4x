using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyThaiStar.Core.Business;
using Excalibur.Cross.ViewModels;
using Excalibur.Shared.Presentation;
using Xamarin.Forms;

using MvvmCross.Navigation;
using MvvmCross.Commands;
using MvvmCross;

namespace MyThaiStar.Core.ViewModels
{
    public class ShoppingCartListViewModel : ListViewModel<int, Observable.ShoppingCartItem, Observable.ShoppingCartItem, IListPresentation<int, Observable.ShoppingCartItem, Observable.ShoppingCartItem>, ShoppingCartListItemViewModel>
    {
        public List<Observable.ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCartListViewModel()
        {
            try
            {                
                
                ShoppingCartItems = ((Excalibur.Views.App)Application.Current).GetShoppingKart().GetItems();

            }
            catch (Exception ex)
            {
                var msg = $"{ex.Message} : {ex.InnerException}";
            } 
        }

        public bool CheckCart()
        {
            return ShoppingCartItems.Any();
        }

        public IMvxAsyncCommand GoShopCommand
        {
            get
            {
                return new MvxAsyncCommand(async () =>
                {
                    if (ShoppingCartItems != null && ShoppingCartItems.Any())
                    {
                        Mvx.Resolve<IMvxNavigationService>().Navigate<MasterDetailViewModel>();
                        Mvx.Resolve<IMvxNavigationService>().Navigate<OrderMenuViewModel>();
                    }
                });
            }
        }
    }
}
