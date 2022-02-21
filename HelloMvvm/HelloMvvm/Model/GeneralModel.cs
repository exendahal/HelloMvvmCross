using MvvmCross.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace HelloMvvm.Model
{
    public class GeneralModel
    {
        public string value1 { get; set; }
        public string value2 { get; set; }
        public string value3 { get; set; }

        public ICommand TapCommand { get; set; }
    }
}
