using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace PHM.Math.Words.Droid.UI.Tests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
                    .ApkFile(@"C:\Users\satheesh.kumar\AppData\Local\Xamarin\Mono for Android\Archives\2017-02-16\PHM.Math.Words.Droid 2-16-17 4.12 PM.apkarchive\PHM_Math_Word_App.PHM_Math_Word_App.apk")
                    .WaitTimes(new WaitTimes())
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

