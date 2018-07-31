using Excalibur.Cross;
using Excalibur.Services;
using Excalibur.Services.Interfaces;
using Excalibur.Shared.Business;
using Excalibur.Shared.ObjectConverter;
using Excalibur.Shared.Presentation;
using Excalibur.Shared.Services;
using Excalibur.Shared.Storage;
using Excalibur.State;
using Excalibur.ViewModels;
using Excalibur.Providers.File;
using System.Collections.Generic;
using XLabs.Ioc;
using MvvmCross.IoC;

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
            Container.Register<IObjectStorageProvider<int, Domain.LoggedInUser>, ObjectAsFileStorageProvider<int, Domain.LoggedInUser>>();
            Container.Register<IObjectMapper<Domain.LoggedInUser, Observable.LoggedInUser>, BaseObjectMapper<Domain.LoggedInUser, Observable.LoggedInUser>>();
            Container.Register<IObjectMapper<Observable.LoggedInUser, Observable.LoggedInUser>, BaseObjectMapper<Observable.LoggedInUser, Observable.LoggedInUser>>();
            Container.Register<Business.Interfaces.ILoggedInUser, Business.LoggedInUser>();
            Container.Register<IServiceBase<Domain.LoggedInUser>, LoggedInUserService>();
            Container.RegisterSingle<ISinglePresentation<int, Observable.LoggedInUser>, BaseSinglePresentation<int, Domain.LoggedInUser, Observable.LoggedInUser>>();

            // User
            Container.Register<IObjectStorageProvider<int, Domain.User>, ObjectAsFileStorageProvider<int, Domain.User>>();
            Container.Register<IObjectMapper<Domain.User, Observable.User>, BaseObjectMapper<Domain.User, Observable.User>>();
            Container.Register<IObjectMapper<Observable.User, Observable.User>, BaseObjectMapper<Observable.User, Observable.User>>();
            Container.Register<IListBusiness<int, Domain.User>, BaseListBusiness<int, Domain.User>>();
            Container.Register<IServiceBase<IList<Domain.User>>, UserService>();
            Container.RegisterSingle<IListPresentation<int, Observable.User, Observable.User>, BaseListPresentation<int, Domain.User, Observable.User, Observable.User>>();

            // Todo
            Container.Register<IObjectStorageProvider<int, Domain.Todo>, ObjectAsFileStorageProvider<int, Domain.Todo>>();
            Container.Register<IObjectMapper<Domain.Todo, Observable.Todo>, BaseObjectMapper<Domain.Todo, Observable.Todo>>();
            Container.Register<IObjectMapper<Observable.Todo, Observable.Todo>, BaseObjectMapper<Observable.Todo, Observable.Todo>>();
            Container.Register<IListBusiness<int, Domain.Todo>, BaseListBusiness<int, Domain.Todo>>();
            Container.Register<IServiceBase<IList<Domain.Todo>>, TodoService>();
            Container.RegisterSingle<Presentation.Interfaces.ITodo, Presentation.Todo>();
        }
    }
}
