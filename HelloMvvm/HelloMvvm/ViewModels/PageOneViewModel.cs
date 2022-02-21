using MvvmCross.Forms.Views;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloMvvm.ViewModels
{
    public class PageOneViewModel : MvxViewModel<string>
    {
        private string _value1 = "Bajra";
        public string Value1
        {
            get { return _value1; }
            set { SetProperty(ref _value1, value); }
        }
        public PageOneViewModel()
        {
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }
        public override void Prepare(string parameter)
        {
            //Implementation
            Value1 = parameter;
        }
    }
}
