using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloMvvm.ViewModels
{
    public class MyBusyPageViewModel: MvxViewModel
    {
        private bool _isBusy = true;

        public bool IsBusy
        {
            get { return _isBusy; }            
            set { SetProperty(ref _isBusy, value); }
        }

        private bool _isVisible = false;

        public bool IsVisibleData
        {
            get { return _isVisible; }
            set { SetProperty(ref _isVisible, value); }
        }
        public MyBusyPageViewModel()
        {
             
        }

        public override async Task Initialize()
        {
            //TODO: Add starting logic here
            await base.Initialize();
            await Task.Delay(5000);
            IsBusy = false;
            IsVisibleData = true;
        }

        
       
    }
}
