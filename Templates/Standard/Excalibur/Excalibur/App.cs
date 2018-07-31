using Excalibur.Cross;
using Excalibur.Services;
using Excalibur.Services.Interfaces;
using Excalibur.ViewModels;
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

            RegisterAppStart<MainViewModel>();
        }

        public override void RegisterDependencies()
        {
            // Application Things            
            Container.RegisterSingle<ISyncService, SyncService>();
        }
    }
}
