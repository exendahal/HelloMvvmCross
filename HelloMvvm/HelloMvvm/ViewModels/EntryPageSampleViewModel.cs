using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HelloMvvm.ViewModels
{
    public class EntryPageSampleViewModel: MvxViewModel
    {
        private string _value1 = "Bajra";
        public string Value1
        {
            get { return _value1; }
            set { SetProperty(ref _value1, value); }
        }

        public ICommand TextChangedEvent { get; set; }
        public EntryPageSampleViewModel()
        {

        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here

            TextChangedEvent = new Command<string>(async items =>
            {
                if (items!=null && string.IsNullOrWhiteSpace(items))
                {
                    Value1 = items;
                }
                
            });

            return base.Initialize();

        }
    }
}
