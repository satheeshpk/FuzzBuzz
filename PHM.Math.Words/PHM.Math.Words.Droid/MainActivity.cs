//-----------------------------------------------------------------------
// <copyright file="MainActivity.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;

    /// <summary>
    /// Android main activity
    /// </summary>
    /// <seealso cref="Xamarin.Forms.Platform.Android.FormsAppCompatActivity" />
    [Activity(Label = "PHM Words", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        /// <summary>
        /// Called on create.
        /// </summary>
        /// <param name="savedInstanceState">State of the saved instance.</param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Xamarin.Forms.Forms.ViewInitialized += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.View.AutomationId))
                {
                    e.NativeView.ContentDescription = e.View.AutomationId;
                }
            };

            LoadApplication(new App());
        }
    }
}

