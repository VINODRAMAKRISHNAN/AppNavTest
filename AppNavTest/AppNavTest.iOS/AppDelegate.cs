﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Octane.Xam.VideoPlayer.iOS;

namespace AppNavTest.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
           
            global::Xamarin.Forms.Forms.Init();
           
            FormsVideoPlayer.Init(null);
            LoadApplication(new App());
            //string primary = Microsoft.Intune.MAM.IntuneMAMPolicyManager.Instance.PrimaryUser;
            #if ENABLE_TEST_CLOUD
                        // requires Xamarin Test Cloud Agent
                        Xamarin.Calabash.Start();
            #endif
            return base.FinishedLaunching(app, options);
        }
    }
}
