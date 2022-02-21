using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloMvvm.ViewModels
{
    public class NavigationSamplePageViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public IMvxAsyncCommand ClickMeCommand { get; set; }
        public NavigationSamplePageViewModel(IMvxNavigationService navigation)
        {
            _navigationService = navigation;
        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here

            ClickMeCommand = new MvxAsyncCommand(async () => {

                string nextData = "Hello From Navigation Page";
                var result = await _navigationService.Navigate<PageOneViewModel, string>(nextData);
            });

            return base.Initialize();

        }
    }
}
