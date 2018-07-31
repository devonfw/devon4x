using System.Collections.Generic;
using Excalibur.Cross;
using Excalibur.Providers.File;
using Excalibur.Services;
using Excalibur.Services.Interfaces;
using Excalibur.Shared.Business;
using Excalibur.Shared.ObjectConverter;
using Excalibur.Shared.Presentation;
using Excalibur.Shared.Services;
using Excalibur.Shared.Storage;
using MvvmCross.IoC;
using MyThaiStar.Core.Business;
using MyThaiStar.Core.Observable;
using MyThaiStar.Core.Services;
using MyThaiStar.Core.Services.Interfaces;
using MyThaiStar.Core.State;
using MyThaiStar.Core.ViewModels;

using XLabs.Ioc;



namespace Excalibur
{
    public class App : ExApp
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes()
               .EndingWith("Service")
               .AsInterfaces()
               .RegisterAsLazySingleton();

            RegisterAppStart<LoginViewModel>();
        }

        public override void RegisterDependencies()
        {
            // Application Things
            Container.RegisterSingle<IApplicationState, ApplicationState>();
            Container.RegisterSingle<ISyncService, SyncService>();

            // User
            Container.Register<IObjectStorageProvider<int, MyThaiStar.Core.Domain.LoggedInUser>, ObjectAsFileStorageProvider<int, MyThaiStar.Core.Domain.LoggedInUser>>();
            Container.Register<IObjectMapper<MyThaiStar.Core.Domain.LoggedInUser, MyThaiStar.Core.Observable.LoggedInUser>, BaseObjectMapper<MyThaiStar.Core.Domain.LoggedInUser, MyThaiStar.Core.Observable.LoggedInUser>>();
            Container.Register<IObjectMapper<MyThaiStar.Core.Observable.LoggedInUser, MyThaiStar.Core.Observable.LoggedInUser>, BaseObjectMapper<MyThaiStar.Core.Observable.LoggedInUser, MyThaiStar.Core.Observable.LoggedInUser>>();
            Container.Register<MyThaiStar.Core.Business.Interfaces.ILoggedInUser, MyThaiStar.Core.Business.LoggedInUser>();
            Container.Register<IServiceBase<MyThaiStar.Core.Domain.LoggedInUser>, LoggedInUserService>();
            Container.RegisterSingle<ISinglePresentation<int, MyThaiStar.Core.Observable.LoggedInUser>, BaseSinglePresentation<int, MyThaiStar.Core.Domain.LoggedInUser, MyThaiStar.Core.Observable.LoggedInUser>>();

            // User
            Container.Register<IObjectStorageProvider<int, MyThaiStar.Core.Domain.User>, ObjectAsFileStorageProvider<int, MyThaiStar.Core.Domain.User>>();
            Container.Register<IObjectMapper<MyThaiStar.Core.Domain.User, MyThaiStar.Core.Observable.User>, BaseObjectMapper<MyThaiStar.Core.Domain.User, MyThaiStar.Core.Observable.User>>();
            Container.Register<IObjectMapper<MyThaiStar.Core.Observable.User, MyThaiStar.Core.Observable.User>, BaseObjectMapper<MyThaiStar.Core.Observable.User, MyThaiStar.Core.Observable.User>>();
            Container.Register<IListBusiness<int, MyThaiStar.Core.Domain.User>, BaseListBusiness<int, MyThaiStar.Core.Domain.User>>();
            Container.Register<IServiceBase<IList<MyThaiStar.Core.Domain.User>>, UserService>();
            Container.RegisterSingle<IListPresentation<int, MyThaiStar.Core.Observable.User, MyThaiStar.Core.Observable.User>, BaseListPresentation<int, MyThaiStar.Core.Domain.User, MyThaiStar.Core.Observable.User, MyThaiStar.Core.Observable.User>>();

            //Dish
            Container.Register<IObjectStorageProvider<int, MyThaiStar.Core.Domain.Dish>, ObjectAsFileStorageProvider<int, MyThaiStar.Core.Domain.Dish>>();
            Container.Register<IObjectMapper<MyThaiStar.Core.Domain.Dish, MyThaiStar.Core.Observable.Dish>, BaseObjectMapper<MyThaiStar.Core.Domain.Dish, MyThaiStar.Core.Observable.Dish>>();
            Container.Register<IObjectMapper<MyThaiStar.Core.Observable.Dish, MyThaiStar.Core.Observable.Dish>, BaseObjectMapper<MyThaiStar.Core.Observable.Dish, MyThaiStar.Core.Observable.Dish>>();
            Container.Register<IListBusiness<int, MyThaiStar.Core.Domain.Dish>, BaseListBusiness<int, MyThaiStar.Core.Domain.Dish>>();
            Container.Register<IServiceBase<IList<MyThaiStar.Core.Domain.Dish>>, DishService>();
            Container.RegisterSingle<IListPresentation<int, MyThaiStar.Core.Observable.Dish, MyThaiStar.Core.Observable.Dish>, BaseListPresentation<int, MyThaiStar.Core.Domain.Dish, MyThaiStar.Core.Observable.Dish, MyThaiStar.Core.Observable.Dish>>();

            //CartItem
            Container.Register<IObjectMapper<MyThaiStar.Core.Observable.ShoppingCartItem, MyThaiStar.Core.Observable.ShoppingCartItem>, BaseObjectMapper<MyThaiStar.Core.Observable.ShoppingCartItem, MyThaiStar.Core.Observable.ShoppingCartItem>>();
            Container.RegisterSingle<IListPresentation<int, MyThaiStar.Core.Observable.ShoppingCartItem, MyThaiStar.Core.Observable.ShoppingCartItem>, BaseListPresentation<int, MyThaiStar.Core.Domain.ShoppingCartItem, MyThaiStar.Core.Observable.ShoppingCartItem, MyThaiStar.Core.Observable.ShoppingCartItem>>();

        }
    }
}
