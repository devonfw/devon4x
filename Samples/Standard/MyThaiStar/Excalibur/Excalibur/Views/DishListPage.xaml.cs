using System.Collections.ObjectModel;
using Excalibur.Shared.Business;
using MvvmCross.Navigation;

using MvvmCross.Forms.Presenters.Attributes;
using MyThaiStar.Core.Domain;
using MyThaiStar.Core.Observable;
using MyThaiStar.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XLabs.Ioc;
using MvvmCross.Forms.Views;

namespace Excalibur.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, WrapInNavigationPage = true,  NoHistory = true)]
    public partial class DishListPage : MvxContentPage<DishListViewModel>
    {
        public ObservableCollection<string> Items { get; set; }
        private  IMvxNavigationService _navigationService;

        public DishListPage()
        {
            InitializeComponent();
            Setup();
            Img.Source = ImageSource.FromResource("Excalibur.Resources.bg.png");
            ListViewItems.ItemTapped += Handle_ItemTapped;            
            Resolver.Resolve<IListBusiness<int, MyThaiStar.Core.Domain.Dish>>().UpdateFromServiceAsync();
        }

        private void Setup()
        {
            ToolbarItems.Add(new ToolbarItem("Filter","filter.png", async () => { ViewModel.GoToTest(); }));
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            var item = (ListViewItems.SelectedItem as MyThaiStar.Core.Observable.Dish);            
            ((ListView)sender).SelectedItem = null;
            if (item != null) ViewModel.ShowDetailCommand(item);
        }
    }
}
