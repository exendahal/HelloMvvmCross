using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloMvvm.ViewModels
{
    public class CLeckEventPageViewModel: MvxViewModel
    {
        public IMvxAsyncCommand ClickMeCommand { get; set; }
        public CLeckEventPageViewModel()
        {

        }

        public override  Task Initialize()
        {
            //TODO: Add starting logic here

            ClickMeCommand = new MvxAsyncCommand(async () => {

                await Application.Current.MainPage.DisplayAlert("Clicked", "Yay Clicked", "ok");
            });

            return base.Initialize();
            
        }
    }
}
