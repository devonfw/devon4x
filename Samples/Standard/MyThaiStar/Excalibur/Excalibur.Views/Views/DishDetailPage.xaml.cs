using System;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MyThaiStar.Core.ViewModels;
using MyThaiStar.Core.Observable;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Excalibur.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, WrapInNavigationPage = true, NoHistory = true)]
    public partial class DishDetailPage : MvxContentPage<DishDetailViewModel>
    {
        public DishDetailPage()
        {
            InitializeComponent();            
            //ImgBackground.Source = ImageSource.FromResource("Excalibur.Resources.wood.jpg");
            SetUp();
            StepperDishNumber.ValueChanged += OnStepperValueChanged;            
        }

        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            NumberDishes.Text = $"Total {e.NewValue}";
        }

        private void SetUp()
        {
            //StepperDishNumber.Value = 1;
            NumberDishes.Text = $"Total {1}";
        }

        private void OnSelectedExtraItem(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView) sender).SelectedItem = null;
        }

        private void BtnAddToOrder(object sender, EventArgs e)
        {
            var item = new ShoppingCartItem { Quantity = Convert.ToInt32(StepperDishNumber.Value), Dish = ViewModel.DishDetail };
            ((Excalibur.Views.App)Application.Current).GetShoppingKart().AddItem(item);
        }

        //protected override bool OnBackButtonPressed()
        //{

        //    // If you want to stop the back button
        //    return true;

        //}
    }
}