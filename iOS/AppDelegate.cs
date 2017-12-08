using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace sampleAppXamarin.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            #if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
            #endif
            AppCenter.Start("93a26a3a-c24e-4c95-9901-47e87d580801", typeof(Analytics), typeof(Crashes));

			return base.FinishedLaunching(app, options);

            
        }
    }
}
