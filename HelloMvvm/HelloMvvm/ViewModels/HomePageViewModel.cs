using HelloMvvm.Model;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HelloMvvm.ViewModels
{
    public class HomePageViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxAsyncCommand TestAsyncCommandSimpleBinding { get; set; }
        public IMvxAsyncCommand TestAsyncCommandCollection { get; set; }
        public IMvxAsyncCommand TestAsyncCommandIsBusy { get; set; }

       

        public HomePageViewModel(IMvxNavigationService navigation)
        {
            _navigationService = navigation;
            TestAsyncCommandSimpleBinding = new MvxAsyncCommand(async () => {
               
                var result = await _navigationService.Navigate<GeneralBindingPageViewModel>();
            });
            TestAsyncCommandCollection = new MvxAsyncCommand(async () => {

                string nextData = "Hello From Homepage";
                var result = await _navigationService.Navigate<CollectionViewSampleViewModel, string, string>(nextData);
            });

            TestAsyncCommandIsBusy = new MvxAsyncCommand(async () => {

                var result = await _navigationService.Navigate<MyBusyPageViewModel>();
            });
        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here
           

            return base.Initialize();
        }

        

    }
}
