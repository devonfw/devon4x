﻿using Excalibur.Tests.FormsCross.Services.Interfaces;
using Excalibur.Tests.FormsCross.ViewModels;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using XLabs.Ioc;

namespace Excalibur.Tests.FormsCross
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        private readonly ILoginService _loginService;

        public AppStart(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public void Start(object hint = null)
        {
            // login things
            if (_loginService.ValidateAsync().GetAwaiter().GetResult())
            {
                // todo init sync and loading of data
                Resolver.Resolve<ISyncService>().PartialSyncAsync().ConfigureAwait(false);

                var navigationService = Mvx.Resolve<IMvxNavigationService>();

                navigationService.Navigate<MainViewModel>();
                navigationService.Navigate<DashboardViewModel>();
            }
            else
            {
                Mvx.Resolve<IMvxNavigationService>().Navigate<LoginViewModel>();
            }
        }
    }
}
