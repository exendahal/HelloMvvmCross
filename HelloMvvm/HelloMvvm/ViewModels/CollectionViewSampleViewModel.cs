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
    public class CollectionViewSampleViewModel : MvxViewModel
    {

        public ICommand TapCommand { get; set; }

        private readonly IMvxNavigationService _navigationService;
        private ObservableCollection<GeneralModel> _obList;
        public ObservableCollection<GeneralModel> obList
        {
            get => _obList;
            set { _obList = value; }
        }

        public CollectionViewSampleViewModel(IMvxNavigationService navigation)
        {
            _navigationService = navigation;
            //TestAsyncCommandSimpleBinding = new MvxAsyncCommand(async () => {


            //    await Application.Current.MainPage.DisplayAlert("Clicked", "Clecked on Item", "ok");
            //});

            TapCommand = new Command<GeneralModel>(async items =>
            {
                await Application.Current.MainPage.DisplayAlert("Clicked", "Clecked on Item "+items.value1, "ok");
            });

            }
        public IMvxAsyncCommand TestAsyncCommandSimpleBinding { get; set; }
        public override Task Initialize()
        {
            //TODO: Add starting logic here

            obList = new ObservableCollection<GeneralModel>();
            for (int i=0;i<10;i++)
            {
                obList.Add(new GeneralModel
                {
                    value1 = "Item " + i,
                    TapCommand = TapCommand

                }) ;
            }
                       
            return base.Initialize();
        }

    }
}
