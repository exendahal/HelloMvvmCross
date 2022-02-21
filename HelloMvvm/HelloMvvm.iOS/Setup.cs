using Foundation;
using Microsoft.Extensions.Logging;
using MvvmCross.Forms.Platforms.Ios.Core;
using Serilog;
using Serilog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace HelloMvvm.iOS
{
    public class Setup : MvxFormsIosSetup<CoreApp, App>
    {
        protected override ILoggerProvider CreateLogProvider()
        {
            return new SerilogLoggerProvider();
        }

        protected override ILoggerFactory CreateLogFactory()
        {
            // serilog configuration
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                // add more sinks here
                .CreateLogger();

            return new SerilogLoggerFactory();
        }
    }
}