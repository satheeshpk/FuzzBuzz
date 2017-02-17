//-----------------------------------------------------------------------
// <copyright file="NumberEntryRenderer.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

[assembly: Xamarin.Forms.ExportRenderer
    (typeof(PHM.Math.Words.Controls.NumberEntry),
    typeof(PHM.Math.Words.Droid.NumberEntryRenderer))]

namespace PHM.Math.Words.Droid
{
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    /// <summary>
    /// Number Entry Renderer
    /// </summary>
    /// <seealso cref="Xamarin.Forms.Platform.Android.EntryRenderer" />
    public class NumberEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
        }
    }
}