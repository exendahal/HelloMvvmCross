using HelloMvvm.ViewModels;
using MvvmCross.Forms.Views;
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
    public partial class Page1 : MvxContentPage<PageOneViewModel>
    {
        public Page1()
        {
            InitializeComponent();
        }
    }
}