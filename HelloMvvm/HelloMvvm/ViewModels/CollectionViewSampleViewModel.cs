using HelloMvvm.Model;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloMvvm.ViewModels
{
    public class CollectionViewSampleViewModel :  MvxViewModel<string, string>
    {
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
           
        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here


            obList = new ObservableCollection<GeneralModel>();
            obList.Add(new GeneralModel
            {
                value1 = "Simple Binding"
            });
            obList.Add(new GeneralModel
            {
                value1 = "Collection View"
            });
            obList.Add(new GeneralModel
            {
                value1 = "LOADING"
            });
            obList.Add(new GeneralModel
            {
                value1 = "CLICK EVENT"
            });
            obList.Add(new GeneralModel
            {
                value1 = "NAVIGATION"
            });
            return base.Initialize();
        }

        public override void Prepare(string parameter)
        {

        }
    }
}
