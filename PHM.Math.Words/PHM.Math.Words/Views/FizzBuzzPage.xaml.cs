//-----------------------------------------------------------------------
// <copyright file="FizzBuzzPage.xaml.cs" company="PHM">
//     Copyright (c) PHM. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PHM.Math.Words.Views
{
    using Xamarin.Forms;

    /// <summary>
    /// Fizz buzz content page
    /// </summary>
    /// <seealso cref="Xamarin.Forms.ContentPage" />
    public partial class FizzBuzzPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzPage"/> class.
        /// </summary>
        public FizzBuzzPage()
        {
            this.InitializeComponent();
            this.InitPage();
        }

        /// <summary>
        /// Initializes the content page.
        /// </summary>
        private void InitPage()
        {
            var fizzBuzzLayout = this.FindByName<StackLayout>("layoutFizzBuzz");
            fizzBuzzLayout.BindingContext = new ViewModels.FizzBuzzViewModel();
        }
    }
}
