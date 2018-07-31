using MyThaiStar.Core.Business;
using MyThaiStar.Core.Business.Dto.DishManagement;
using MyThaiStar.Core.Business.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Excalibur.Views
{	
	public partial class App : Application
    {
        private static IStorableObject<MyThaiStar.Core.Observable.ShoppingCartItem> KartShop { get; set; }
        private static FilterDtoSearchObject GlobalDishFilter { get; set; }

        public App()
        {
            SetUp();
        }

        private void SetUp()
        {
            KartShop = new StorableObject<MyThaiStar.Core.Observable.ShoppingCartItem>();
            GlobalDishFilter = new FilterDtoSearchObject { };
        }

        #region Shoppingcart
        public IStorableObject<MyThaiStar.Core.Observable.ShoppingCartItem> GetShoppingKart()
        {
            return KartShop;
        }
        #endregion

        #region DishFilter
        public FilterDtoSearchObject GetDishFilter()
        {
            return GlobalDishFilter;
        }

        public void ResetDishFilter()
        {
            GlobalDishFilter = new FilterDtoSearchObject { Categories = new CategorySearchDto[0], MinLikes = "", MaxPrice = "", SearchBy = "", sort = new MyThaiStar.Core.Business.Dto.General.SortByDto[0] };
        }

        public void SetDishFilter(FilterDtoSearchObject filter)
        {
            GlobalDishFilter = filter;
        }
        #endregion



    }
}