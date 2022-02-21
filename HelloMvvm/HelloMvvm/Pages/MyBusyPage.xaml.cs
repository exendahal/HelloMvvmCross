using HelloMvvm.ViewModels;
using MvvmCross.Forms.Views;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloMvvm.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyBusyPage : MvxContentPage<MyBusyPageViewModel>
    {
       
        public MyBusyPage()
        {
            InitializeComponent();
        }
    }
}