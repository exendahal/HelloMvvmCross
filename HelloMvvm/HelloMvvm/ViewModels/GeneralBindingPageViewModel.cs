using HelloMvvm.Model;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloMvvm.ViewModels
{
    public class GeneralBindingPageViewModel: MvxViewModel
    {
        private string _value1 = "Bajra";
        private string _value2 = "Technologies";
        private string _value3 = "3rd Floor, Shree Raj Bhawan Subidhanagar, Tinkune Kathmandu, Nepal";
        public string Value1
        {
            get { return _value1; }
            set { SetProperty(ref _value1, value); }
        }

        public string Value2
        {
            get { return _value2; }
            set { SetProperty(ref _value2, value); }
        }

        public string Value3
        {
            get { return _value3; }
            set { SetProperty(ref _value3, value); }
        }
        public GeneralBindingPageViewModel()
        {
           
        }

        public async Task Initialize(string parameter)
        {
            //Do something with parameter
           
            base.Initialize();
        }
       
    }
}
