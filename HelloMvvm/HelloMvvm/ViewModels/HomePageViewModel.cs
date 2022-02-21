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
        public IMvxAsyncCommand TestAsyncCommandClickEventPage { get; set; }
        public IMvxAsyncCommand TestAsyncCommandNavigationSample { get; set; }

       

        public HomePageViewModel(IMvxNavigationService navigation)
        {
            _navigationService = navigation;
            TestAsyncCommandSimpleBinding = new MvxAsyncCommand(async () => {
               
                var result = await _navigationService.Navigate<GeneralBindingPageViewModel>();
            });
            TestAsyncCommandCollection = new MvxAsyncCommand(async () => {
               
                var result = await _navigationService.Navigate<CollectionViewSampleViewModel>();
            });

            TestAsyncCommandIsBusy = new MvxAsyncCommand(async () => {

                var result = await _navigationService.Navigate<MyBusyPageViewModel>();
            });

            TestAsyncCommandClickEventPage = new MvxAsyncCommand(async () => {

                var result = await _navigationService.Navigate<CLeckEventPageViewModel>();
            });

            TestAsyncCommandNavigationSample = new MvxAsyncCommand(async () => {

                var result = await _navigationService.Navigate<NavigationSamplePageViewModel>();
            });
        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here
           

            return base.Initialize();
        }

        

    }
}
